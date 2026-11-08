namespace WindowsFormsApp2.Helpers
{
    /// <summary>
    /// Mã chức năng dùng để phân quyền menu trên frmMain (khớp cột MaChucNang của bảng ChucNang).
    /// Thành viên phụ trách phân quyền cần chèn đúng các mã này vào bảng ChucNang.
    /// </summary>
    public static class ChucNangCode
    {
        public const string Sach = "DM_SACH";
        public const string TheLoai = "DM_THELOAI";
        public const string KhachHang = "DM_KHACHHANG";
        public const string NhanVien = "DM_NHANVIEN";
        public const string NhaCungCap = "DM_NCC";
        public const string BanHang = "BAN_HANG";
        public const string NhapHang = "NHAP_HANG";
        public const string HoaDon = "DS_HOADON";
        public const string BaoCao = "BAO_CAO";
        public const string NguoiDung = "HT_NGUOIDUNG";
        public const string PhanQuyen = "HT_PHANQUYEN";
    }
}
