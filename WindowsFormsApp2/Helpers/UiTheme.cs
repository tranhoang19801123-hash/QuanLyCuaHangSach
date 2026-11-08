using System.Drawing;

namespace WindowsFormsApp2.Helpers
{
    /// <summary>Bảng màu & font chuẩn của toàn ứng dụng (khớp với giá trị đã đặt trong Designer).</summary>
    public static class UiTheme
    {
        public const string FontName = "Segoe UI";

        public static readonly Color Primary   = Color.FromArgb(37, 99, 235);   // xanh chủ đạo
        public static readonly Color PrimaryDark = Color.FromArgb(30, 58, 138); // header / tiêu đề
        public static readonly Color Danger    = Color.FromArgb(220, 38, 38);   // xóa, cảnh báo
        public static readonly Color Success   = Color.FromArgb(22, 163, 74);   // xuất Excel, lưu
        public static readonly Color Warning   = Color.FromArgb(217, 119, 6);   // sửa
        public static readonly Color Gray      = Color.FromArgb(107, 114, 128); // làm mới, hủy
        public static readonly Color Background = Color.FromArgb(243, 244, 246);// nền form
        public static readonly Color Text      = Color.FromArgb(17, 24, 39);
        public static readonly Color Side      = Color.FromArgb(17, 24, 39);    // nền menu trái
        public static readonly Color SideHover = Color.FromArgb(31, 41, 55);
    }
}
