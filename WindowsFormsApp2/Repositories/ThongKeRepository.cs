using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Repositories
{
    public class ThongKeRepository
    {
        // ------------------------------------------------------------
        // 1. Doanh thu 12 tháng: CHỈ dùng HoaDon.ThanhTien (đã trừ giảm giá)
        // ------------------------------------------------------------
        public Dictionary<int, decimal> GetDoanhThu12Thang(int nam)
        {
            var result = new Dictionary<int, decimal>();
            for (int i = 1; i <= 12; i++)
            {
                result[i] = 0m;
            }

            using (var db = ConnectionHelper.CreateContext())
            {
                var data = db.HoaDons
                    .Where(hd => hd.NgayLap.HasValue && hd.NgayLap.Value.Year == nam)
                    .GroupBy(hd => hd.NgayLap.Value.Month)
                    .Select(g => new
                    {
                        Thang = g.Key,
                        DoanhThu = g.Sum(hd => (decimal?)hd.ThanhTien) ?? 0m
                    })
                    .ToList();

                foreach (var item in data)
                {
                    result[item.Thang] = item.DoanhThu;
                }
            }

            return result;
        }

        // ------------------------------------------------------------
        // 2. Top 5 sách bán chạy theo tháng
        // ------------------------------------------------------------
        public List<TopSachDTO> GetTop5SachTheoThang(int thang, int nam)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var query = (from cthd in db.ChiTietHoaDons
                             join hd in db.HoaDons on cthd.MaHD equals hd.MaHD
                             join s in db.SanPhams on cthd.MaSP equals s.MaSP
                             where hd.NgayLap.HasValue
                                && hd.NgayLap.Value.Month == thang
                                && hd.NgayLap.Value.Year == nam
                             group cthd by new { s.MaSP, s.TenSP } into g
                             select new TopSachDTO
                             {
                                 TenSach = g.Key.TenSP,
                                 SoLuongBan = g.Sum(x => x.SoLuong)
                             })
                            .OrderByDescending(x => x.SoLuongBan)
                            .ThenBy(x => x.TenSach)
                            .Take(5)
                            .ToList();

                return query;
            }
        }

        // ------------------------------------------------------------
        // 3. Doanh thu theo thể loại, đã PHÂN BỔ giảm giá theo tỷ lệ
        //    => tổng các thể loại khớp với tổng ThanhTien của biểu đồ đường
        // ------------------------------------------------------------
        public List<TheLoaiDTO> GetDoanhThuTheoTheLoai(int nam)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var rows = (from cthd in db.ChiTietHoaDons
                            join hd in db.HoaDons on cthd.MaHD equals hd.MaHD
                            join s in db.SanPhams on cthd.MaSP equals s.MaSP
                            join tl in db.TheLoais on s.MaTL equals tl.MaTL
                            where hd.NgayLap.HasValue && hd.NgayLap.Value.Year == nam
                            select new
                            {
                                TenTL = tl.TenTL,
                                Tien = (decimal)(cthd.SoLuong * cthd.DonGia),
                                TongHD = hd.TongTien,
                                ThanhToan = hd.ThanhTien
                            }).ToList();

                // Hệ số = ThanhTien / TongTien của hóa đơn (nếu không có giảm giá thì = 1)
                var result = rows
                    .GroupBy(r => r.TenTL)
                    .Select(g => new TheLoaiDTO
                    {
                        TenTheLoai = g.Key,
                        DoanhThu = g.Sum(r =>
                        {
                            decimal tong = r.TongHD ?? 0m;
                            decimal thanh = r.ThanhToan ?? tong;
                            return tong > 0m ? r.Tien * thanh / tong : r.Tien;
                        })
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                return result;
            }
        }

        // ------------------------------------------------------------
        // 4. Báo cáo doanh thu theo khoảng ngày + lọc theo tiêu chí
        //    (nhân viên, khách hàng, thể loại). Tiêu chí rỗng = tất cả.
        // ------------------------------------------------------------
        public List<ThongKeHoaDonRow> GetHoaDonTheoTieuChi(
            DateTime tuNgay, DateTime denNgay, string maNV, string maKH, string maTL)
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

                if (!string.IsNullOrEmpty(maNV))
                    q = q.Where(x => x.H.MaNV == maNV);

                if (!string.IsNullOrEmpty(maKH))
                    q = q.Where(x => x.H.MaKH == maKH);

                if (!string.IsNullOrEmpty(maTL))
                {
                    // Chỉ lấy hóa đơn có ít nhất 1 dòng chi tiết thuộc thể loại đã chọn (truy vấn con, không tải danh sách về bộ nhớ)
                    q = q.Where(x => db.ChiTietHoaDons.Any(c =>
                            c.MaHD == x.H.MaHD && c.SanPham.MaTL == maTL));
                }

                return q.OrderBy(x => x.H.NgayLap)
                        .Select(x => new ThongKeHoaDonRow
                        {
                            MaHD = x.H.MaHD,
                            NgayLap = x.H.NgayLap,
                            KhachHang = x.TenKH ?? "Khách lẻ",
                            NhanVien = x.TenNV,
                            ThanhTien = x.H.ThanhTien ?? 0m
                        }).ToList();
            }
        }

        // ------------------------------------------------------------
        // 5. Danh sách cho các ComboBox lọc (phần tử đầu = "Tất cả")
        // ------------------------------------------------------------
        public List<LocItem> GetNhanVienLoc()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var ds = db.NhanViens.OrderBy(n => n.HoTen)
                           .Select(n => new LocItem { Value = n.MaNV, Text = n.HoTen })
                           .ToList();
                ds.Insert(0, new LocItem { Value = "", Text = "Tất cả" });
                return ds;
            }
        }

        public List<LocItem> GetKhachHangLoc()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var ds = db.KhachHangs.OrderBy(k => k.HoTen)
                           .Select(k => new LocItem { Value = k.MaKH, Text = k.HoTen })
                           .ToList();
                ds.Insert(0, new LocItem { Value = "", Text = "Tất cả" });
                return ds;
            }
        }

        public List<LocItem> GetTheLoaiLoc()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var ds = db.TheLoais.OrderBy(t => t.TenTL)
                           .Select(t => new LocItem { Value = t.MaTL, Text = t.TenTL })
                           .ToList();
                ds.Insert(0, new LocItem { Value = "", Text = "Tất cả" });
                return ds;
            }
        }
    }

    public class TopSachDTO
    {
        public string TenSach { get; set; }
        public int SoLuongBan { get; set; }
    }

    public class TheLoaiDTO
    {
        public string TenTheLoai { get; set; }
        public decimal DoanhThu { get; set; }
    }

    public class ThongKeHoaDonRow
    {
        public string MaHD { get; set; }
        public DateTime? NgayLap { get; set; }
        public string KhachHang { get; set; }
        public string NhanVien { get; set; }
        public decimal ThanhTien { get; set; }
    }

    public class LocItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}