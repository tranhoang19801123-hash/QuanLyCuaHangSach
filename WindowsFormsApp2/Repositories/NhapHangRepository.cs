using QuanLyCuaHangSach;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Helpers;
using System.Web.UI;
using System.Web.WebSockets;

namespace WindowsFormsApp2.Repositories
{
    public class SachNhapRow
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string Text { get { return MaSP + " - " + TenSP; } } // hiển thị trong combobox
    }

    //<summary> Một dòng trong phiếu nhập đang lập (frmImport).</summary>
    public class NhapItem
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal ThanhTien { get { return GiaNhap * SoLuong; } }
    }

    /// <summary> Nghiệp vụ nhập hàng: Lưu PhieuNhap + ChiTietPhieuNhap và CỘNG tồn kho trong một TransactionScope.</summary>
    public class NhapHangRepository
    {
        public List<SachNhapRow> GetSach()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                return db.SanPhams.OrderBy(s => s.TenSP)
                         .Select(s => new SachNhapRow
                         {
                             MaSP = s.MaSP,
                             TenSP = s.TenSP,
                             GiaNhap = s.GiaNhap ?? 0,
                             GiaBan = s.GiaBan ?? 0,
                             SoLuongTon = s.SoLuongTon ?? 0
                         }).ToList();
            }
        }

        public List<ComboItem> GetNhaCungCapItems()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var items = db.NhaCungCaps.OrderBy(n => n.TenNCC)
                              .Select(n => new ComboItem { Value = n.MaNCC, Text = n.TenNCC }).ToList();
                items.Insert(0, new ComboItem { Value = "", Text = "-- Chọn nhà cung cấp --" });
                return items;
            }
        }

        ///<summary> Mã phiếu nhập: PN + yyyyMMdd + 3 chữ số.</summary>
        public string TaoMaPN()
        {
            using (var db = ConnectionHelper.CreateContext())
                return TaoMaPN(db, DateTime.Now);
        }

        private static string TaoMaPN(QLSachDataContext db, DateTime ngay)
        {
            string tienTo = "PN" + ngay.ToString("yyyyMMdd");
            string cuoi = db.PhieuNhaps.Where(p => p.MaPN.StartsWith(tienTo))
                                       .Select(p => p.MaPN).OrderByDescending(m => m).FirstOrDefault();
            int so = 0;
            if (cuoi != null) int.TryParse(cuoi.Substring(tienTo.Length), out so);
            return tienTo + (so + 1).ToString("000");
        }

        public string LapPhieuNhap(string maPNDeNghi, DateTime ngayNhap, string maNV, string maNCC, IList<NhapItem> dong)
        {
            if (string.IsNullOrEmpty(maNV))
                throw new NghiepVuException("Tài khoản đăng nhập chưa được gắn với nhân viên nào nên không thể lập phiếu nhập.");
            if (string.IsNullOrEmpty(maNCC))
                throw new NghiepVuException("Vui lòng chọn nhà cung cấp.");
            if (dong == null || dong.Count == 0)
                throw new NghiepVuException("Phiếu nhập chưa có sách nào.");
            if (dong.Any(d => d.SoLuong <= 0 || d.GiaNhap <= 0))
                throw new NghiepVuException("Số lượng và giá nhập phải lớn hơn 0.");

            var tuyCHon = new TransactionOptions
            {
                IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromSeconds(30)
            };

            using (var scope = new TransactionScope(TransactionScopeOption.Required, tuyCHon))
            {
                string maPN;
                using (var db = ConnectionHelper.CreateContext())
                {
                    if (!db.NhaCungCaps.Any(n => n.MaNCC == maNCC))
                        throw new NghiepVuException("Nhà cung cấp không tồn tại.");

                    var ids = dong.Select(d => d.MaSP).ToList();
                    var sachs = db.SanPhams.Where(s => ids.Contains(s.MaSP)).ToDictionary(s => s.MaSP);

                    maPN = maPNDeNghi;
                    if (string.IsNullOrWhiteSpace(maPN) || db.PhieuNhaps.Any(p => p.MaPN == maPN))
                        maPN = TaoMaPN(db, ngayNhap);

                    var pn = new PhieuNhap
                    {
                        MaPN = maPN,
                        NgayNhap = ngayNhap,
                        MaNCC = maNCC,
                        MaNV = maNV,
                    };
                    decimal tong = 0m;
                    foreach (var d in dong)
                    {
                        SanPham sp;
                        if (!sachs.TryGetValue(d.MaSP, out sp))
                            throw new NghiepVuException("Sách mã " + d.MaSP + " không còn trong hệ thống.");

                        decimal gia = Math.Round(d.GiaNhap, 0);
                        sp.SoLuongTon = (sp.SoLuongTon ?? 0) + d.SoLuong;
                        sp.GiaNhap = gia;
                        pn.ChiTietPhieuNhaps.Add(new ChiTietPhieuNhap
                        {
                            MaSP = d.MaSP,
                            SoLuong = d.SoLuong,
                            GiaNhap = gia
                        });
                        tong += gia * d.SoLuong;
                    }
                    pn.TongTien = tong;
                    db.PhieuNhaps.InsertOnSubmit(pn);

                    try { db.SubmitChanges(); }
                    catch (ChangeConflictException)
                    {
                        throw new NghiepVuException("Dữ liệu sách vừa được cập nhật ở máy khác. Vui lòng thử lại.");
                    }
                }
                scope.Complete();
                return maPN;
            }
        }

    }
}
