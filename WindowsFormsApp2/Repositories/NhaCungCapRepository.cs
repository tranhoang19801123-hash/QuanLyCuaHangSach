using QuanLyCuaHangSach;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Repositories
{
    public class NhaCungCapRow
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public int SoSach { get; set; }
    }

    public class NhaCungCapRepository
    {
        public List<NhaCungCapRow> GetAll(string tuKhoa = null)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var src = db.NhaCungCaps.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    string k = tuKhoa.Trim();
                    src = src.Where(n => n.MaNCC.Contains(k) || n.TenNCC.Contains(k)
                                         || (n.DienThoai != null && n.DienThoai.Contains(k)));
                }
                return src.OrderBy(n => n.MaNCC)
                          .Select(n => new NhaCungCapRow
                          {
                              MaNCC = n.MaNCC,
                              TenNCC = n.TenNCC,
                              DienThoai = n.DienThoai,
                              DiaChi = n.DiaChi,
                              SoSach = n.SanPhams.Count()
                          }).ToList();
            }
        }

        /// <summary>Danh sách cho ComboBox; coMucTrong = true thì thêm dòng "(Không chọn)" ở đầu.</summary>
        public List<ComboItem> GetItems(bool coMucTrong)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var ds = db.NhaCungCaps.OrderBy(n => n.TenNCC)
                           .Select(n => new ComboItem { Value = n.MaNCC, Text = n.TenNCC }).ToList();
                if (coMucTrong) ds.Insert(0, new ComboItem { Value = "", Text = "(Không chọn)" });
                return ds;
            }
        }

        public NhaCungCap GetById(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.NhaCungCaps.FirstOrDefault(n => n.MaNCC == ma);
        }

        public bool Exists(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.NhaCungCaps.Any(n => n.MaNCC == ma);
        }

        public void Add(NhaCungCap ncc)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                db.NhaCungCaps.InsertOnSubmit(ncc);
                db.SubmitChanges();
            }
        }

        public void Update(NhaCungCap moi)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var n = db.NhaCungCaps.Single(x => x.MaNCC == moi.MaNCC);
                n.TenNCC = moi.TenNCC;
                n.DienThoai = moi.DienThoai;
                n.DiaChi = moi.DiaChi;
                db.SubmitChanges();
            }
        }

        /// <summary>Nhà cung cấp đã có sách hoặc phiếu nhập thì không xóa được.</summary>
        public bool DaPhatSinhDuLieu(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.SanPhams.Any(s => s.MaNCC == ma) || db.PhieuNhaps.Any(p => p.MaNCC == ma);
        }

        public void Delete(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var n = db.NhaCungCaps.SingleOrDefault(x => x.MaNCC == ma);
                if (n == null) return;
                db.NhaCungCaps.DeleteOnSubmit(n);
                db.SubmitChanges();
            }
        }
    }
}
