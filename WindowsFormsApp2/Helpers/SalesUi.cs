using System;
using System.Configuration;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Helpers
{
    /// <summary>Đọc khóa trong thẻ appSetting của App.config (có giá trị mặc định)</summary>
    public static class AppCfg
    {
        public static string Get(string key, string macDinh)
        {
            string v = ConfigurationManager.AppSettings[key];
            return string.IsNullOrWhiteSpace(v) ? macDinh : v.Trim();
        }
    }

    /// <summary>Định dạng / đọc tiền VNĐ (dấu chấm ngắn cách hàng nghìn, không có số lẻ. </summary>
    public static class Money
    {
        public static void LiveFormat(Guna.UI2.WinForms.Guna2TextBox txt, EventHandler eventHandler)
        {
            txt.TextChanged += eventHandler;
        }
        public static readonly CultureInfo VN = new CultureInfo("vi-VN");
        public static string Fmt(decimal v)
        {
            return v.ToString("N0", VN);
        }

        ///<sumary> Lấy các chữ số trong chuỗi (1.250.000đ -> 1250000), Chuỗi rỗng/ sai -> 0.</sumary>
        public static decimal Parse(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0m;
            string digits = new string(s.Where(char.IsDigit).ToArray());
            decimal v;
            return decimal.TryParse(digits, NumberStyles.None, CultureInfo.InvariantCulture, out v) ? v : 0m;
        }

        ///<sumary>Gắn cho TextBox: chỉ cho gõ số, tự thêm dấu chấm hàng nghìn khi đang gõ</sumary>
        public static void LiveFormat(TextBox t, Action khiDoi)
        {
            bool dangSua = false;
            t.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
            t.TextChanged += (s, e) =>
            {
                if (dangSua) return;
                dangSua = true;
                try
                {
                    if (t.Text.Length > 0)
                    {
                        t.Text = Fmt(Parse(t.Text));
                        t.SelectionStart = t.Text.Length;
                    }
                }
                finally { dangSua = false; }
                if (khiDoi != null) khiDoi();
            };
        }
    }
}
