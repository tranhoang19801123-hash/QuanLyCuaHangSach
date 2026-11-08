using QuanLyCuaHangSach;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Helpers;
using System.Data;

namespace WindowsFormsApp2.Repositories
{
    /// <summary> Lỗi nghiệp vụ (hết hàng, dữ liệu sai...) - hiển thị thẳng cho người dùng, khác với lỗi hệ thống. </summary>
    public class NghiepVuException : Exception
    {
        public NghiepVuException(string message) : base(message) { }
    }

    //----------------Các lớp dữ liệu hiển thị ---------------
    public class SachBanRow
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string TacGia { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
    }

    /// <summary> Một dòng trong giỏ hàng của frmSales. </summary>
    public class GioHangItem
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public int Ton { get; set; }
        public decimal ThanhTien { get { return DonGia * SoLuong; } }
    }

    public class NhanVienInfo
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
    }

    public class KhachHangGiamGia
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string TenHang { get; set; }
        public decimal PhanTramGiam { get; set; }
        public int Diem { get; set; }
    }

    public class KetQuaBanHang
    {
        public string MaHD { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
        public int DiemCong { get; set; }
        public string HangMoi { get; set; } // Khác null nếu khách vừa được nâng hạng
    }

    public class HoaDonRow
    {
        public string MaHD { get; set; }
        public DateTime? NgayLap { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
    }

    public class ChiTietHoaDonRow
    {
        public int STT { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string SanPham
        {
            get { return TenSP; }
        }
    }

    public class HoaDonInfo
    {
        public string MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
        public List<ChiTietHoaDonRow> ChiTiet { get; set; }
    }

    /// <summary>
    /// Nghiệp vụ bán hàng (TV3): kiểm tra tổn kho -> giảm giá theo hạng thành viên ->
    /// Lưu hóa đơn + chi tiết -> trừ tồn kho -> cộng điểm / nâng hạng. Tất cả nằm trong MỘT TransactionScope.
    /// Form chỉ gọi lớp này, không viết LINQ trực tiếp.
    /// </summary>

    internal class BanHangRepository
    {
        /// <summary> Cứ mỗi 10.000đ thanh toán được 1 điểm tích lũy.</summary>
        public const decimal DongMoiDiem = 10000;

        //--------------Tra cứu phục vụ màn hình bán hàng------------
        public List<SachBanRow> TimSach(string tuKhoa)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var q = db.SanPhams.AsQueryable();
                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    string k = tuKhoa.Trim();
                    q = q.Where(s => s.MaSP.Contains(k) || s.TenSP.Contains(k) || (s.TacGia != null && s.TacGia.Contains(k)));
                }
                return q.OrderBy(s => s.TenSP)
                        .Select(s => new SachBanRow
                        {
                            MaSP = s.MaSP,
                            TenSP = s.TenSP,
                            TacGia = s.TacGia,
                            GiaBan = s.GiaBan ?? 0,
                            SoLuongTon = s.SoLuongTon ?? 0
                        }).ToList();
            }
        }

        /// <summary> Danh sách khách hàng cho ComboBox; phần tử đầu là "khách lẻ" (Value rỗng). </summary>
        public List<ComboItem> GetKhachHangItems()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var ds = db.KhachHangs.OrderBy(k => k.HoTen)
                           .Select(k => new { k.MaKH, k.HoTen, k.DienThoai }).ToList();
                var items = ds.Select(k => new ComboItem
                {
                    Value = k.MaKH,
                    Text = k.HoTen + (string.IsNullOrEmpty(k.DienThoai) ? "" : " - " + k.DienThoai)
                }).ToList();
                items.Insert(0, new ComboItem { Value = "", Text = "Khách lẻ (không tích điểm)" });
                return items;
            }
        }

        /// <summary> Hạng + % giảm giá + điểm hiện có của khách (null nếu là khách lẻ).</summary>
        public KhachHangGiamGia GetGiamGia(string maKH)
        {
            if (string.IsNullOrEmpty(maKH)) return null;
            using (var db = ConnectionHelper.CreateContext())
            {
                var kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == maKH);
                if (kh == null) return null;

                string maHang = kh.MaHang;
                HangThanhVien hang = maHang == null ? null : db.HangThanhViens.FirstOrDefault(h => h.MaHang == maHang);
                return new KhachHangGiamGia
                {
                    MaKH = kh.MaKH,
                    HoTen = kh.HoTen,
                    TenHang = hang == null ? null : hang.TenHang,
                    PhanTramGiam = hang == null ? 0m : (decimal)hang.PhanTramGiam,
                    Diem = kh.DiemTichLuy ?? 0
                };
            }
        }

        /// <summary> Nhân viên gắn với tài khoản đăng nhập (NhanVien.TenDangNhap). Null nếu chưa gắn.</summary>
        public NhanVienInfo GetNhanVienByTaiKhoan(string tenDangNhap)
        {
            if (string.IsNullOrEmpty(tenDangNhap)) return null;
            using (var db = ConnectionHelper.CreateContext())
            {
                return db.NhanViens.Where(n => n.TenDangNhap == tenDangNhap)
                    .Select(n => new NhanVienInfo
                    {
                        MaNV = n.MaNV,
                        HoTen = n.HoTen
                    }).FirstOrDefault();
            }
        }

        public static decimal TinhGiamGia(decimal tongTien, decimal phanTram)
        {
            return Math.Round(tongTien * phanTram / 100m, 0, MidpointRounding.AwayFromZero);
        }

        //-----------------Sinh mã hóa đơn: HD + yyyyMMdd + 3 chữ số -------------
        public string TaoMaHD()
        {
            using (var db = ConnectionHelper.CreateContext())
                return TaoMaHD(db, DateTime.Now);
        }

        private static string TaoMaHD(QLSachDataContext db, DateTime ngay)
        {
            string tiento = "HD" + ngay.ToString("yyyyMMdd");
            string cuoi = db.HoaDons.Where(h => h.MaHD.StartsWith(tiento))
                                     .Select(h => h.MaHD)
                                     .OrderByDescending(m => m)
                                     .FirstOrDefault();
            int so = 0;
            if (cuoi != null) int.TryParse(cuoi.Substring(tiento.Length), out so);
            return tiento + (so + 1).ToString("000");
        }

        //--------------NGHIỆP VỤ CHÍNH: LẬP HÓA ĐƠN----------------
        /// <summary> 
        /// Một giao dịch duy nhất (TransactionScope) gồm: kiểm tra tồn kho -> tính tiền/giảm giá -> lưu HoaDon + ChiTietHoaDon 
        /// -> trừ SoLuongTon -> cộng điểm , nâng hạng. Có lỗi ở bất kỳ bước nào thì ROLLBACK toàn bộ.
        /// </summary>
        public KetQuaBanHang LapHoaDon(string maHDdeNghi, DateTime ngayLap, string maNV, string maKH, IList<GioHangItem> gio)
        {
            if (gio == null || gio.Count == 0)
                throw new NghiepVuException("Giỏ hàng đang trống");

            // Gộp các dòng trùng sách (phong trường hợp thêm 2 lần)
            var dong = gio.GroupBy(g => g.MaSP)
                          .Select(g => new { MaSP = g.Key, SoLuong = g.Sum(x => x.SoLuong) }).ToList();
            if (dong.Any(d => d.SoLuong <= 0))
                throw new NghiepVuException("Số lượng phải lớn hơn 0");

            var tuyChon = new TransactionOptions
            {
                IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromSeconds(30)
            };

            using (var scope = new TransactionScope(TransactionScopeOption.Required, tuyChon))
            {
                KetQuaBanHang kq;
                //Dùng DUY NHẤT một DataContext/kết nối trong scope để không bị đẩy lên MSDTC
                using (var db = ConnectionHelper.CreateContext())
                {
                    // 1. Ràng buộc tồn kho + 2. trừ tồn kho
                    var ids = dong.Select(d => d.MaSP).ToList();
                    var sachs = db.SanPhams.Where(s => ids.Contains(s.MaSP)).ToDictionary(s => s.MaSP);

                    decimal tong = 0m;
                    var chiTiet = new List<ChiTietHoaDon>();
                    foreach (var d in dong)
                    {
                        SanPham sp;
                        if (!sachs.TryGetValue(d.MaSP, out sp))
                            throw new NghiepVuException("Sách mã " + d.MaSP + " không còn trong hệ thống.");

                        int ton = sp.SoLuongTon ?? 0;
                        if (ton < d.SoLuong)
                            throw new NghiepVuException("Không đủ tồn kho cho sách \"" + sp.TenSP + "\".\n"
                                                         + "Còn lại: " + ton + " - Yêu cầu: " + d.SoLuong);

                        decimal gia = sp.GiaBan ?? 0m;
                        if (gia <= 0)
                            throw new NghiepVuException("Sách \"" + sp.TenSP + "\" chưa có giá bán.");

                        decimal tt = gia * d.SoLuong;
                        tong += tt;
                        sp.SoLuongTon = ton - d.SoLuong;
                        chiTiet.Add(new ChiTietHoaDon { MaSP = sp.MaSP, SoLuong = d.SoLuong, DonGia = gia, ThanhTien = tt });
                    }

                    // 3. Giảm giá theo hạng thành viên
                    KhachHang kh = null;
                    HangThanhVien hangHienTai = null;
                    decimal phanTram = 0m;
                    if (!string.IsNullOrEmpty(maKH))
                    {
                        kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == maKH);
                        if (kh == null)
                            throw new NghiepVuException("Không tìm thấy khách hàng " + maKH + ".");
                        string maHang = kh.MaHang;
                        if (maHang != null)
                        {
                            hangHienTai = db.HangThanhViens.FirstOrDefault(h => h.MaHang == maHang);
                        }
                        if (hangHienTai != null) phanTram = (decimal)hangHienTai.PhanTramGiam;
                    }
                    decimal giam = TinhGiamGia(tong, phanTram);
                    decimal thanhTien = tong - giam;

                    // 4. Tích điểm + tự động nâng hạng (chỉ nâng, không hạ)
                    int diemCong = 0;
                    string hangMoi = null;
                    if (kh != null)
                    {
                        diemCong = (int)(thanhTien / DongMoiDiem);
                        int diemMoi = (kh.DiemTichLuy ?? 0) + diemCong;
                        kh.DiemTichLuy = diemMoi;

                        HangThanhVien hangDat = db.HangThanhViens.Where(h => (h.DiemToiThieu ?? 0) <= diemMoi)
                                                                 .OrderByDescending(h => h.DiemToiThieu ?? 0)
                                                                 .FirstOrDefault();
                        int nguongHienTai = hangHienTai == null ? -1 : (hangHienTai.DiemToiThieu ?? 0);
                        if (hangDat != null && (hangDat.DiemToiThieu ?? 0) > nguongHienTai)
                        {
                            kh.MaHang = hangDat.MaHang;
                            kh.HangThanhVien = hangDat.TenHang;
                            hangMoi = hangDat.TenHang;
                        }
                    }

                    // 5. Lưu hóa đơn + chi tiết
                    string maHD = maHDdeNghi;
                    if (string.IsNullOrEmpty(maHD) || db.HoaDons.Any(h => h.MaHD == maHD))
                    {
                        maHD = TaoMaHD(db, ngayLap);
                    }
                    var hd = new HoaDon
                    {
                        MaHD = maHD,
                        NgayLap = ngayLap,
                        MaKH = string.IsNullOrEmpty(maKH) ? null : maKH,
                        MaNV = string.IsNullOrEmpty(maNV) ? null : maNV,
                        TongTien = tong,
                        GiamGia = giam,
                        ThanhTien = thanhTien
                    };
                    foreach (var ct in chiTiet) hd.ChiTietHoaDons.Add(ct);
                    db.HoaDons.InsertOnSubmit(hd);

                    try
                    {
                        db.SubmitChanges();

                    }
                    catch (ChangeConflictException)
                    {
                        // Có người khác vừa sửa tồn kho của cùng cuốn sách 
                        throw new NghiepVuException("Tồn kho vừa được cập nhật ở máy khác. Vui lòng thử lại.");
                    }
                    kq = new KetQuaBanHang
                    {
                        MaHD = maHD,
                        TongTien = tong,
                        GiamGia = giam,
                        ThanhTien = thanhTien,
                        DiemCong = diemCong,
                        HangMoi = hangMoi
                    };
                }
                scope.Complete();
                return kq;
            }
        }

        //--------------TRA CỨU HÓA ĐƠN----------------
        ///<summary> Lọc theo mã HD, tên khách, khoảng ngày lập (gồm cả ngày cuối). Join KhachHang + NhanVien.</summary>
        public List<HoaDonRow> TimHoaDon(string maHD, string tenKH, DateTime tuNgay, DateTime denNgay)
        {
            DateTime d0 = tuNgay.Date;
            DateTime d1 = denNgay.Date.AddDays(1);
            using (var db = ConnectionHelper.CreateContext())
            {
                var q = from h in db.HoaDons
                        where h.NgayLap >= d0 && h.NgayLap < d1
                        join k in db.KhachHangs on h.MaKH equals k.MaKH into gk
                        from k in gk.DefaultIfEmpty()
                        join n in db.NhanViens on h.MaNV equals n.MaNV into gn
                        from n in gn.DefaultIfEmpty()
                        select new { H = h, TenKH = k.HoTen, TenNV = n.HoTen };

                if (!string.IsNullOrWhiteSpace(maHD))
                {
                    string m = maHD.Trim();
                    q = q.Where(x => x.H.MaHD.Contains(m));
                }
                if (!string.IsNullOrWhiteSpace(tenKH))
                {
                    string t = tenKH.Trim();

                    q = q.Where(x => (x.TenKH ?? "Khách lẻ").Contains(t));
                }

                return q.OrderByDescending(x => x.H.NgayLap)
                        .Select(x => new HoaDonRow
                        {
                            MaHD = x.H.MaHD,
                            NgayLap = x.H.NgayLap,
                            TenKH = x.TenKH ?? "Khách lẻ",
                            TenNV = x.TenNV,
                            TongTien = x.H.TongTien ?? 0,
                            GiamGia = x.H.GiamGia ?? 0,
                            ThanhTien = x.H.ThanhTien ?? 0
                        }).ToList();
            }
        }
        /// <summary> Toàn bộ thông tin 1 hóa đơn (đầu phiếu + chi tiết) - dùng cho xem chi tiết và in RDLC.</summary>
        public HoaDonInfo GetHoaDon(string maHD)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var h = db.HoaDons.FirstOrDefault(x => x.MaHD == maHD);
                if (h == null) return null;

                string maKH = h.MaKH;
                string maNV = h.MaNV;
                string tenKH = maKH == null ? null
                    : db.KhachHangs.Where(k => k.MaKH == maKH).Select(k => k.HoTen).FirstOrDefault();
                string tenNV = maNV == null ? null
                    : db.NhanViens.Where(n => n.MaNV == maNV).Select(n => n.HoTen).FirstOrDefault();

                var ct = (from c in db.ChiTietHoaDons
                          where c.MaHD == maHD
                          join s in db.SanPhams on c.MaSP equals s.MaSP
                          orderby c.MaSP
                          select new ChiTietHoaDonRow
                          {
                              MaSP = c.MaSP,
                              TenSP = s.TenSP,
                              SoLuong = c.SoLuong,
                              DonGia = c.DonGia,
                              ThanhTien = c.ThanhTien
                          }).ToList();
                for (int i = 0; i < ct.Count; i++) ct[i].STT = i + 1;

                return new HoaDonInfo
                {
                    MaHD = h.MaHD,
                    NgayLap = h.NgayLap ?? DateTime.MinValue,
                    TenKH = tenKH ?? "Khách lẻ",
                    TenNV = tenNV ?? "",
                    TongTien = h.TongTien ?? 0,
                    GiamGia = h.GiamGia ?? 0,
                    ThanhTien = h.ThanhTien ?? 0,
                    ChiTiet = ct
                };
            }
        }
    }
}

