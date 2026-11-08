using System.Collections.Generic;

namespace WindowsFormsApp2.Helpers
{
    public static class Session
    {
        public static string TenDangNhap { get; set; }

        public static string HoTen { get; set; }

        public static int? MaQuyen { get; set; }

        public static HashSet<string> Quyen { get; set; }
            = new HashSet<string>();

        public static bool HasPermission(string maChucNang)
        {
            return Quyen.Contains(maChucNang);
        }

        public static void Clear()
        {
            TenDangNhap = null;
            HoTen = null;
            MaQuyen = null;
            Quyen = new HashSet<string>();
        }
    }
}