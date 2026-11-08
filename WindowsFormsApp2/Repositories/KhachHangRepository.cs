using QuanLyCuaHangSach;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Repositories
{
    public class KhachHangRow
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public int DiemTichLuy { get; set; }
        public string TenHang { get; set; }
        public double PhanTramGiam { get; set; }
    }

    public class KhachHangRepository
    {
        /// <summary>Tìm theo mã / họ tên / điện thoại; JOIN hạng thành viên để lấy tên hạng và % giảm.</summary>
        public List<KhachHangRow> GetAll(string tuKhoa = null)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var src = db.KhachHangs.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    string tk = tuKhoa.Trim();
                    src = src.Where(x => x.MaKH.Contains(tk) || x.HoTen.Contains(tk)
                                         || (x.DienThoai != null && x.DienThoai.Contains(tk)));
                }

                var q = from k in src
                        join h in db.HangThanhViens on k.MaHang equals h.MaHang into gh
                        from h in gh.DefaultIfEmpty()
                        orderby k.MaKH
                        select new KhachHangRow
                        {
                            MaKH = k.MaKH,
                            HoTen = k.HoTen,
                            DienThoai = k.DienThoai,
                            DiemTichLuy = k.DiemTichLuy ?? 0,
                            TenHang = h.TenHang,
                            PhanTramGiam = (double?)h.PhanTramGiam ?? 0
                        };
                return q.ToList();
            }
        }

        /// <summary>Danh sách hạng cho ComboBox: "Tên hạng (x%)".</summary>
        public List<ComboItem> GetHangItems()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var ds = db.HangThanhViens.OrderBy(h => h.DiemToiThieu ?? 0).ToList();
                var items = ds.Select(h => new ComboItem
                {
                    Value = h.MaHang,
                    Text = h.TenHang + " (giảm " + h.PhanTramGiam.ToString("0.##") + "%)"
                }).ToList();
                items.Insert(0, new ComboItem { Value = "", Text = "(Chưa có hạng)" });
                return items;
            }
        }

        /// <summary>Hạng cao nhất mà số điểm hiện có đạt được (null nếu chưa có hạng nào phù hợp).</summary>
        public string GoiYHang(int diem)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                return db.HangThanhViens
                         .Where(h => (h.DiemToiThieu ?? 0) <= diem)
                         .OrderByDescending(h => h.DiemToiThieu ?? 0)
                         .Select(h => h.MaHang)
                         .FirstOrDefault();
            }
        }

        /// <summary>Thống kê số khách theo hạng (GroupBy + Count).</summary>
        public string ThongKeTheoHang()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var nhom = db.KhachHangs.GroupBy(k => k.MaHang)
                             .Select(g => new { MaHang = g.Key, SoKhach = g.Count() }).ToList();
                var ten = db.HangThanhViens.ToDictionary(h => h.MaHang, h => h.TenHang);
                return string.Join("   •   ",
                    nhom.OrderByDescending(x => x.SoKhach)
                        .Select(x => ((x.MaHang != null && ten.ContainsKey(x.MaHang)) ? ten[x.MaHang] : "Chưa có hạng")
                                     + ": " + x.SoKhach));
            }
        }

        public KhachHang GetById(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.KhachHangs.FirstOrDefault(k => k.MaKH == ma);
        }

        public bool Exists(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.KhachHangs.Any(k => k.MaKH == ma);
        }

        public void Add(KhachHang kh)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
            }
        }

        public void Update(KhachHang moi)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var k = db.KhachHangs.Single(x => x.MaKH == moi.MaKH);
                k.HoTen = moi.HoTen;
                k.DienThoai = moi.DienThoai;
                k.DiemTichLuy = moi.DiemTichLuy;
                k.MaHang = moi.MaHang;
                k.HangThanhVien = moi.HangThanhVien;
                db.SubmitChanges();
            }
        }

        public bool DaCoHoaDon(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.HoaDons.Any(h => h.MaKH == ma);
        }

        public void Delete(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var k = db.KhachHangs.SingleOrDefault(x => x.MaKH == ma);
                if (k == null) return;
                db.KhachHangs.DeleteOnSubmit(k);
                db.SubmitChanges();
            }
        }
    }
}
