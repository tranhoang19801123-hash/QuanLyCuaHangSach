
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp2.Helpers
{
    /// <summary>
    /// Thông tin tài khoản nhận tiền VietQR.
    /// </summary>
    public class BankInfo
    {
        public string Bin { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
    }

    /// <summary>
    /// Lưu và đọc thông tin tài khoản VietQR bằng Windows DPAPI.
    /// Dữ liệu được mã hóa trước khi ghi xuống ổ đĩa.
    /// </summary>
    public static class BankSecret
    {
        // Entropy dùng để phân biệt dữ liệu của ứng dụng.
        private static readonly byte[] Entropy =
            Encoding.UTF8.GetBytes("QuanLyCuaHangSach.VietQR.v1");

        // Đường dẫn lưu dữ liệu mã hóa trong AppData.
        private static string DuongDanFile
        {
            get
            {
                string thuMuc = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.ApplicationData),
                    "QuanLyCuaHangSach");

                return Path.Combine(thuMuc, "vietqr.dat");
            }
        }

        // Kiểm tra đã có cấu hình ngân hàng hay chưa.
        public static bool DaCauHinh
        {
            get { return Load() != null; }
        }

        // Mã hóa và lưu thông tin ngân hàng.
        public static void Save(BankInfo info)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            if (string.IsNullOrWhiteSpace(info.Bin) ||
                string.IsNullOrWhiteSpace(info.BankName) ||
                string.IsNullOrWhiteSpace(info.AccountNo) ||
                string.IsNullOrWhiteSpace(info.AccountName))
            {
                throw new ArgumentException(
                    "Thông tin tài khoản ngân hàng không được để trống.");
            }

            string noiDung = string.Join("\n", new[]
            {
                info.Bin,
                info.BankName,
                info.AccountNo,
                info.AccountName
            }.Select(s => (s ?? "")
                .Replace("\r", " ")
                .Replace("\n", " ")
                .Trim()));

            byte[] daMaHoa = ProtectedData.Protect(
                Encoding.UTF8.GetBytes(noiDung),
                Entropy,
                DataProtectionScope.CurrentUser);

            Directory.CreateDirectory(
                Path.GetDirectoryName(DuongDanFile));

            File.WriteAllBytes(DuongDanFile, daMaHoa);
        }

        // Đọc và giải mã thông tin ngân hàng.
        // Trả về null nếu chưa cấu hình hoặc không giải mã được.
        public static BankInfo Load()
        {
            try
            {
                if (!File.Exists(DuongDanFile))
                    return null;

                byte[] raw = ProtectedData.Unprotect(
                    File.ReadAllBytes(DuongDanFile),
                    Entropy,
                    DataProtectionScope.CurrentUser);

                string[] p = Encoding.UTF8.GetString(raw).Split('\n');

                if (p.Length < 4 ||
                    p.Take(4).Any(string.IsNullOrWhiteSpace))
                    return null;

                return new BankInfo
                {
                    Bin = p[0],
                    BankName = p[1],
                    AccountNo = p[2],
                    AccountName = p[3]
                };
            }
            catch (CryptographicException)
            {
                return null;
            }
            catch (IOException)
            {
                return null;
            }
            catch (UnauthorizedAccessException)
            {
                return null;
            }
        }

        // Xóa cấu hình ngân hàng.
        public static void Clear()
        {
            if (File.Exists(DuongDanFile))
                File.Delete(DuongDanFile);
        }
    }
}
