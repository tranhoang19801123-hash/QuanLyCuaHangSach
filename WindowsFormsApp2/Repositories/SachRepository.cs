using QuanLyCuaHangSach;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Repositories
{
    /// <summary>Một dòng hiển thị trên lưới danh sách sách.</summary>
    public class SachRow
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string TacGia { get; set; }
        public string TheLoai { get; set; }
        public string NhaCungCap { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
    }

    /// <summary>Truy vấn LINQ to SQL cho bảng SanPham (sách). Form chỉ gọi lớp này, không viết LINQ trực tiếp.</summary>
    public class SachRepository
    {
        /// <summary>Tìm theo mã / tên / tác giả; JOIN thể loại và nhà cung cấp.</summary>
        public List<SachRow> GetAll(string tuKhoa = null)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var src = db.SanPhams.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    string k = tuKhoa.Trim();
                    src = src.Where(s => s.MaSP.Contains(k) || s.TenSP.Contains(k)
                                         || (s.TacGia != null && s.TacGia.Contains(k)));
                }

                var q = from s in src
                        join t in db.TheLoais on s.MaTL equals t.MaTL into gt
                        from t in gt.DefaultIfEmpty()
                        join n in db.NhaCungCaps on s.MaNCC equals n.MaNCC into gn
                        from n in gn.DefaultIfEmpty()
                        orderby s.MaSP
                        select new SachRow
                        {
                            MaSP = s.MaSP,
                            TenSP = s.TenSP,
                            TacGia = s.TacGia,
                            TheLoai = t.TenTL ?? s.TheLoai,
                            NhaCungCap = n.TenNCC,
                            GiaNhap = s.GiaNhap ?? 0,
                            GiaBan = s.GiaBan ?? 0,
                            SoLuongTon = s.SoLuongTon ?? 0
                        };
                return q.ToList();
            }
        }

        /// <summary>Các sách sắp hết hàng (dùng cho Dashboard): Where + OrderBy + Take.</summary>
        public List<SachRow> GetSapHet(int nguong, int soDong)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                return db.SanPhams
                         .Where(s => (s.SoLuongTon ?? 0) < nguong)
                         .OrderBy(s => s.SoLuongTon)
                         .ThenBy(s => s.TenSP)
                         .Take(soDong)
                         .Select(s => new SachRow
                         {
                             MaSP = s.MaSP,
                             TenSP = s.TenSP,
                             TacGia = s.TacGia,
                             SoLuongTon = s.SoLuongTon ?? 0
                         }).ToList();
            }
        }

        public SanPham GetById(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.SanPhams.FirstOrDefault(s => s.MaSP == ma);
        }

        public bool Exists(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.SanPhams.Any(s => s.MaSP == ma);
        }

        public void Add(SanPham sp)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                db.SanPhams.InsertOnSubmit(sp);
                db.SubmitChanges();
            }
        }

        public void Update(SanPham moi)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var sp = db.SanPhams.Single(s => s.MaSP == moi.MaSP);
                sp.TenSP = moi.TenSP;
                sp.TacGia = moi.TacGia;
                sp.TheLoai = moi.TheLoai;
                sp.MaTL = moi.MaTL;
                sp.MaNCC = moi.MaNCC;
                sp.GiaNhap = moi.GiaNhap;
                sp.GiaBan = moi.GiaBan;
                sp.SoLuongTon = moi.SoLuongTon;
                db.SubmitChanges();
            }
        }

        /// <summary>Sách đã nằm trong hóa đơn hoặc phiếu nhập thì không được xóa.</summary>
        public bool DaPhatSinhGiaoDich(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.ChiTietHoaDons.Any(c => c.MaSP == ma)
                    || db.ChiTietPhieuNhaps.Any(c => c.MaSP == ma);
        }

        public void Delete(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var sp = db.SanPhams.SingleOrDefault(s => s.MaSP == ma);
                if (sp == null) return;
                db.SanPhams.DeleteOnSubmit(sp);
                db.SubmitChanges();
            }
        }
    }
}
