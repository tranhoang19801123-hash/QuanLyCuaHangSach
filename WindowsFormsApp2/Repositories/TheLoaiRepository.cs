using QuanLyCuaHangSach;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Repositories
{
    public class TheLoaiRow
    {
        public string MaTL { get; set; }
        public string TenTL { get; set; }
        public string MoTa { get; set; }
        public int SoSach { get; set; }
    }

    public class TheLoaiRepository
    {
        public List<TheLoaiRow> GetAll(string tuKhoa = null)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var src = db.TheLoais.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    string k = tuKhoa.Trim();
                    src = src.Where(t => t.MaTL.Contains(k) || t.TenTL.Contains(k));
                }
                return src.OrderBy(t => t.MaTL)
                          .Select(t => new TheLoaiRow
                          {
                              MaTL = t.MaTL,
                              TenTL = t.TenTL,
                              MoTa = t.MoTa,
                              SoSach = t.SanPhams.Count()
                          }).ToList();
            }
        }

        /// <summary>Danh sách cho ComboBox.</summary>
        public List<ComboItem> GetItems()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                return db.TheLoais.OrderBy(t => t.TenTL)
                         .Select(t => new ComboItem { Value = t.MaTL, Text = t.TenTL }).ToList();
            }
        }

        public TheLoai GetById(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.TheLoais.FirstOrDefault(t => t.MaTL == ma);
        }

        public bool Exists(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.TheLoais.Any(t => t.MaTL == ma);
        }

        public void Add(TheLoai tl)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                db.TheLoais.InsertOnSubmit(tl);
                db.SubmitChanges();
            }
        }

        public void Update(TheLoai moi)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var tl = db.TheLoais.Single(t => t.MaTL == moi.MaTL);
                tl.TenTL = moi.TenTL;
                tl.MoTa = moi.MoTa;
                // Đồng bộ cột chữ TheLoai trong bảng SanPham khi đổi tên thể loại
                foreach (var sp in db.SanPhams.Where(s => s.MaTL == moi.MaTL))
                    sp.TheLoai = moi.TenTL;
                db.SubmitChanges();
            }
        }

        public bool CoSach(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.SanPhams.Any(s => s.MaTL == ma);
        }

        public void Delete(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var tl = db.TheLoais.SingleOrDefault(t => t.MaTL == ma);
                if (tl == null) return;
                db.TheLoais.DeleteOnSubmit(tl);
                db.SubmitChanges();
            }
        }
    }
}
