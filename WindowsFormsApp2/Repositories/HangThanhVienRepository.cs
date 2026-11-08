using QuanLyCuaHangSach;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Repositories
{
    public class HangRow
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public double PhanTramGiam { get; set; }
        public int DiemToiThieu { get; set; }
        public int SoKhach { get; set; }
    }

    public class HangThanhVienRepository
    {
        public List<HangRow> GetAll(string tuKhoa = null)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var src = db.HangThanhViens.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    string k = tuKhoa.Trim();
                    src = src.Where(h => h.MaHang.Contains(k) || h.TenHang.Contains(k));
                }
                return src.OrderBy(h => h.DiemToiThieu ?? 0)
                          .Select(h => new HangRow
                          {
                              MaHang = h.MaHang,
                              TenHang = h.TenHang,
                              PhanTramGiam = h.PhanTramGiam,
                              DiemToiThieu = h.DiemToiThieu ?? 0,
                              SoKhach = h.KhachHangs.Count()
                          }).ToList();
            }
        }

        public HangThanhVien GetById(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.HangThanhViens.FirstOrDefault(h => h.MaHang == ma);
        }

        public bool Exists(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.HangThanhViens.Any(h => h.MaHang == ma);
        }

        public void Add(HangThanhVien h)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                db.HangThanhViens.InsertOnSubmit(h);
                db.SubmitChanges();
            }
        }

        public void Update(HangThanhVien moi)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var h = db.HangThanhViens.Single(x => x.MaHang == moi.MaHang);
                h.TenHang = moi.TenHang;
                h.PhanTramGiam = moi.PhanTramGiam;
                h.DiemToiThieu = moi.DiemToiThieu;
                // Đồng bộ cột chữ HangThanhVien của khách hàng khi đổi tên hạng
                foreach (var k in db.KhachHangs.Where(x => x.MaHang == moi.MaHang))
                    k.HangThanhVien = moi.TenHang;
                db.SubmitChanges();
            }
        }

        public bool CoKhachHang(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.KhachHangs.Any(k => k.MaHang == ma);
        }

        public void Delete(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var h = db.HangThanhViens.SingleOrDefault(x => x.MaHang == ma);
                if (h == null) return;
                db.HangThanhViens.DeleteOnSubmit(h);
                db.SubmitChanges();
            }
        }
    }
}
