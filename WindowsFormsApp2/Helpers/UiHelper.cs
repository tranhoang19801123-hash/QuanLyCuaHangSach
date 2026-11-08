using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp2.Helpers
{
    /// <summary>Các hàm tiện ích dùng chung cho giao diện: thông báo, kiểm tra dữ liệu nhập.</summary>
    public static class UiHelper
    {
        public static void Info(string msg)
        {
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warn(string msg)
        {
            MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string msg)
        {
            MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirm(string msg)
        {
            return MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Mã: 1-20 ký tự chữ, số, gạch dưới, gạch ngang; không có khoảng trắng.</summary>
        public static bool IsMa(string s)
        {
            return !string.IsNullOrEmpty(s) && Regex.IsMatch(s, @"^[A-Za-z0-9_\-]{1,20}$");
        }

        /// <summary>Số điện thoại VN: để trống hoặc 9-11 chữ số (có thể bắt đầu bằng 0 hoặc +84).</summary>
        public static bool IsPhone(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            return Regex.IsMatch(s.Trim(), @"^(\+84|0)\d{8,10}$");
        }

        public static bool IsEmail(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            return Regex.IsMatch(s.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static string NullIfEmpty(string s)
        {
            return string.IsNullOrWhiteSpace(s) ? null : s.Trim();
        }

        /// <summary>Gán giá trị cho NumericUpDown nhưng luôn nằm trong khoảng cho phép (tránh ngoại lệ).</summary>
        public static void SetNum(NumericUpDown nud, decimal value)
        {
            if (value < nud.Minimum) value = nud.Minimum;
            if (value > nud.Maximum) value = nud.Maximum;
            nud.Value = value;
        }
    }
}
