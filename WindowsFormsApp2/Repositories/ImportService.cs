using QuanLyCuaHangSach;
using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Repositories
{
    /// <summary>Kết quả của một lần nhập Excel.</summary>
    public class ImportResult
    {
        public int Added { get; set; }
        public List<string> Errors { get; } = new List<string>();     // các dòng bị bỏ qua + lý do

        public string TomTat()
        {
            string s = "Đã nhập thành công: " + Added + " dòng.\nBị bỏ qua: " + Errors.Count + " dòng.";
            if (Errors.Count > 0)
            {
                s += "\n\nChi tiết (tối đa 15 dòng đầu):\n" + string.Join("\n", Errors.Take(15));
                if (Errors.Count > 15) s += "\n... và " + (Errors.Count - 15) + " dòng khác.";
            }
            return s;
        }
    }

    /// <summary>
    /// Nhập danh mục từ Excel vào DB bằng LINQ. Mỗi dòng được kiểm tra riêng; dòng lỗi/trùng bị bỏ qua và báo lý do.
    /// Các dòng hợp lệ được lưu bằng một lần SubmitChanges (LINQ to SQL tự bọc trong một giao dịch).
    /// </summary>
    public class ImportService
    {
        // ---------- Sách ----------
        public static readonly string[] SachCot =
            { "Mã sách", "Tên sách", "Tác giả", "Thể loại (mã hoặc tên)", "Nhà cung cấp (mã hoặc tên)", "Giá nhập", "Giá bán", "Tồn kho" };

        public static readonly object[][] SachViDu =
        {
            new object[] { "S101", "Truyện Kiều", "Nguyễn Du", "Văn học Việt Nam", "NXB Trẻ", 40000, 60000, 20 },
            new object[] { "S102", "Lược sử thời gian", "Stephen Hawking", "TL04", "", 90000, 130000, 10 }
        };

        public ImportResult ImportSach(List<ExcelRow> rows)
        {
            var kq = new ImportResult();
            using (var db = ConnectionHelper.CreateContext())
            {
                var daCo = new HashSet<string>(db.SanPhams.Select(s => s.MaSP).ToList(), StringComparer.OrdinalIgnoreCase);
                var theLoai = db.TheLoais.ToList();
                var ncc = db.NhaCungCaps.ToList();
                var moi = new List<SanPham>();

                foreach (var r in rows)
                {
                    string loi = null;
                    string ma = ExcelHelper.Chuoi(r.Cells[0]);
                    string ten = ExcelHelper.Chuoi(r.Cells[1]);
                    string tg = ExcelHelper.Chuoi(r.Cells[2]);
                    string tlKey = ExcelHelper.Chuoi(r.Cells[3]);
                    string nccKey = ExcelHelper.Chuoi(r.Cells[4]);
                    decimal gn, gb, ton;

                    if (!UiHelper.IsMa(ma)) loi = "mã sách không hợp lệ";
                    else if (daCo.Contains(ma)) loi = "mã sách đã tồn tại";
                    else if (ten == null) loi = "thiếu tên sách";
                    else if (!ExcelHelper.TryDecimal(r.Cells[5], out gn) || gn < 0) loi = "giá nhập không hợp lệ";
                    else if (!ExcelHelper.TryDecimal(r.Cells[6], out gb) || gb <= 0) loi = "giá bán không hợp lệ";
                    else if (gb < gn) loi = "giá bán nhỏ hơn giá nhập";
                    else if (!ExcelHelper.TryDecimal(r.Cells[7], out ton) || ton < 0 || ton != Math.Floor(ton)) loi = "tồn kho phải là số nguyên ≥ 0";

                    TheLoai tl = null; NhaCungCap nc = null;
                    if (loi == null)
                    {
                        tl = theLoai.FirstOrDefault(x => string.Equals(x.MaTL, tlKey, StringComparison.OrdinalIgnoreCase)
                                                      || string.Equals(x.TenTL, tlKey, StringComparison.OrdinalIgnoreCase));
                        if (tl == null) loi = "không tìm thấy thể loại \"" + tlKey + "\"";
                    }
                    if (loi == null && nccKey != null)
                    {
                        nc = ncc.FirstOrDefault(x => string.Equals(x.MaNCC, nccKey, StringComparison.OrdinalIgnoreCase)
                                                  || string.Equals(x.TenNCC, nccKey, StringComparison.OrdinalIgnoreCase));
                        if (nc == null) loi = "không tìm thấy nhà cung cấp \"" + nccKey + "\"";
                    }

                    if (loi != null) { kq.Errors.Add("Dòng " + r.Row + ": " + loi); continue; }

                    ExcelHelper.TryDecimal(r.Cells[5], out gn);
                    ExcelHelper.TryDecimal(r.Cells[6], out gb);
                    ExcelHelper.TryDecimal(r.Cells[7], out ton);
                    moi.Add(new SanPham
                    {
                        MaSP = ma, TenSP = ten, TacGia = tg,
                        MaTL = tl.MaTL, TheLoai = tl.TenTL,
                        MaNCC = nc == null ? null : nc.MaNCC,
                        GiaNhap = gn, GiaBan = gb, SoLuongTon = (int)ton
                    });
                    daCo.Add(ma);                 // phát hiện trùng mã ngay trong file
                }

                if (moi.Count > 0)
                {
                    db.SanPhams.InsertAllOnSubmit(moi);
                    db.SubmitChanges();
                }
                kq.Added = moi.Count;
            }
            return kq;
        }

        // ---------- Khách hàng ----------
        public static readonly string[] KhachHangCot =
            { "Mã khách hàng", "Họ tên", "Điện thoại", "Điểm tích lũy", "Hạng (mã hoặc tên, để trống = tự tính theo điểm)" };

        public static readonly object[][] KhachHangViDu =
        {
            new object[] { "KH101", "Nguyễn Thị Lan", "0909123456", 300, "" },
            new object[] { "KH102", "Trần Văn Nam", "0911222333", 0, "Thành viên" }
        };

        public ImportResult ImportKhachHang(List<ExcelRow> rows)
        {
            var kq = new ImportResult();
            using (var db = ConnectionHelper.CreateContext())
            {
                var daCo = new HashSet<string>(db.KhachHangs.Select(k => k.MaKH).ToList(), StringComparer.OrdinalIgnoreCase);
                var hang = db.HangThanhViens.ToList();
                var moi = new List<KhachHang>();

                foreach (var r in rows)
                {
                    string loi = null;
                    string ma = ExcelHelper.Chuoi(r.Cells[0]);
                    string ten = ExcelHelper.Chuoi(r.Cells[1]);
                    string sdt = ExcelHelper.Chuoi(r.Cells[2]);
                    string hangKey = ExcelHelper.Chuoi(r.Cells[4]);
                    decimal diem;

                    if (!UiHelper.IsMa(ma)) loi = "mã khách hàng không hợp lệ";
                    else if (daCo.Contains(ma)) loi = "mã khách hàng đã tồn tại";
                    else if (ten == null) loi = "thiếu họ tên";
                    else if (sdt != null && !UiHelper.IsPhone(sdt)) loi = "số điện thoại không hợp lệ";
                    else if (r.Cells[3] != null && (!ExcelHelper.TryDecimal(r.Cells[3], out diem) || diem < 0 || diem != Math.Floor(diem)))
                        loi = "điểm tích lũy phải là số nguyên ≥ 0";

                    HangThanhVien h = null;
                    int d = 0;
                    if (loi == null)
                    {
                        decimal dd;
                        if (ExcelHelper.TryDecimal(r.Cells[3], out dd)) d = (int)dd;
                        if (hangKey != null)
                        {
                            h = hang.FirstOrDefault(x => string.Equals(x.MaHang, hangKey, StringComparison.OrdinalIgnoreCase)
                                                      || string.Equals(x.TenHang, hangKey, StringComparison.OrdinalIgnoreCase));
                            if (h == null) loi = "không tìm thấy hạng \"" + hangKey + "\"";
                        }
                        else
                        {
                            // Tự tính hạng cao nhất mà số điểm đạt được
                            h = hang.Where(x => (x.DiemToiThieu ?? 0) <= d)
                                    .OrderByDescending(x => x.DiemToiThieu ?? 0).FirstOrDefault();
                        }
                    }

                    if (loi != null) { kq.Errors.Add("Dòng " + r.Row + ": " + loi); continue; }

                    moi.Add(new KhachHang
                    {
                        MaKH = ma, HoTen = ten, DienThoai = sdt, DiemTichLuy = d,
                        MaHang = h == null ? null : h.MaHang,
                        HangThanhVien = h == null ? null : h.TenHang
                    });
                    daCo.Add(ma);
                }

                if (moi.Count > 0)
                {
                    db.KhachHangs.InsertAllOnSubmit(moi);
                    db.SubmitChanges();
                }
                kq.Added = moi.Count;
            }
            return kq;
        }
    }
}
