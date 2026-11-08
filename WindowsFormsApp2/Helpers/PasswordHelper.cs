using System;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp2.Helpers
{
    public class PasswordHelper
    {
        // Hàm tạo Salt (hỗ trợ cả 2 tên gọi GenerateSalt và CreateSalt để tránh lỗi)
        public static string GenerateSalt()
        {
            return CreateSalt();
        }

        public static string CreateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Hàm băm mật khẩu
        public static string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string combined = password + salt;
                byte[] bytes = Encoding.UTF8.GetBytes(combined);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Hàm kiểm tra mật khẩu cũ (Verify) được gọi ở frmChangePassword
        public static bool Verify(string password, string salt, string hash)
        {
            string newHash = HashPassword(password, salt);
            return newHash == hash;
        }
    }
}