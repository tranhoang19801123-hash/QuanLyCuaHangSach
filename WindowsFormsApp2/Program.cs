using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// Thêm namespace chứa form đăng nhập của bạn vào đây (ví dụ: WindowsFormsApp2.Forms)
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy form đăng nhập khi ứng dụng vừa bật lên
            Application.Run(new frmLogin());
        }
    }
}