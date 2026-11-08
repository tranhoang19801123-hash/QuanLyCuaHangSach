using QuanLyCuaHangSach;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Repositories
{
    public class NhanVienRow
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string TenDangNhap { get; set; }
    }

    public class NhanVienRepository
    {
        public List<NhanVienRow> GetAll(string tuKhoa = null)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var src = db.NhanViens.AsQueryable();
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    string k = tuKhoa.Trim();
                    src = src.Where(n => n.MaNV.Contains(k) || n.HoTen.Contains(k)
                                         || (n.DienThoai != null && n.DienThoai.Contains(k)));
                }
                return src.OrderBy(n => n.MaNV)
                          .Select(n => new NhanVienRow
                          {
                              MaNV = n.MaNV,
                              HoTen = n.HoTen,
                              DienThoai = n.DienThoai,
                              Email = n.Email,
                              DiaChi = n.DiaChi,
                              TenDangNhap = n.TenDangNhap
                          }).ToList();
            }
        }

        /// <summary>
        /// Tài khoản có thể gán cho nhân viên: chưa gắn với nhân viên nào,
        /// hoặc chính là tài khoản đang gắn với nhân viên đang sửa (giuLai).
        /// </summary>
        public List<ComboItem> GetTaiKhoanItems(string giuLai)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var ds = db.NguoiDungs
                           .Where(u => !db.NhanViens.Any(n => n.TenDangNhap == u.TenDangNhap)
                                       || u.TenDangNhap == giuLai)
                           .OrderBy(u => u.TenDangNhap)
                           .Select(u => new ComboItem { Value = u.TenDangNhap, Text = u.TenDangNhap + " - " + u.HoTen })
                           .ToList();
                ds.Insert(0, new ComboItem { Value = "", Text = "(Không có tài khoản)" });
                return ds;
            }
        }

        public NhanVien GetById(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.NhanViens.FirstOrDefault(n => n.MaNV == ma);
        }

        public bool Exists(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.NhanViens.Any(n => n.MaNV == ma);
        }

        /// <summary>Tài khoản đã gắn với nhân viên khác chưa (bỏ qua nhân viên đang sửa).</summary>
        public bool TaiKhoanDaDung(string tenDangNhap, string boQuaMaNV)
        {
            if (string.IsNullOrEmpty(tenDangNhap)) return false;
            using (var db = ConnectionHelper.CreateContext())
                return db.NhanViens.Any(n => n.TenDangNhap == tenDangNhap && n.MaNV != boQuaMaNV);
        }

        public void Add(NhanVien nv)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
            }
        }

        public void Update(NhanVien moi)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var n = db.NhanViens.Single(x => x.MaNV == moi.MaNV);
                n.HoTen = moi.HoTen;
                n.DienThoai = moi.DienThoai;
                n.Email = moi.Email;
                n.DiaChi = moi.DiaChi;
                n.TenDangNhap = moi.TenDangNhap;
                db.SubmitChanges();
            }
        }

        public bool DaPhatSinhGiaoDich(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
                return db.HoaDons.Any(h => h.MaNV == ma) || db.PhieuNhaps.Any(p => p.MaNV == ma);
        }

        public void Delete(string ma)
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var n = db.NhanViens.SingleOrDefault(x => x.MaNV == ma);
                if (n == null) return;
                db.NhanViens.DeleteOnSubmit(n);
                db.SubmitChanges();
            }
        }
    }
}
