using QRCoder;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Helpers
{
    /// <summary>
    /// Sinh chuỗi VietQR (chuẫn EMVCo / NAPAS 247) và ảnh mã QR để khách quét bằng app ngân hàng
    /// Chạy hoàn toàn offline (không gọi API bên ngoài). Thông tin tài khoản nhận tiền được quản lý riêng bằng BankSecret 
    /// </summary>
    public static class VietQRHelper
    {

        // Mỗi trường: ID (2 ký tự) + độ dài (2 chữ số) + giá trị
        private static string Tlv(string id, string value)
        {
            return id + value.Length.ToString("00", CultureInfo.InvariantCulture) + value;
        }

        ///<param name="soTien"> &lt; = 0 thì tạo QR tĩnh (khách tự nhập số tiền)</param>
        ///<param name="noiDung"> Nội dung chuyển khoản (tự bỏ dấu, tối đa 25 ký tự).</param>
        public static string BuildPayload(string bin, string taiKhoan, decimal soTien, string noiDung)
        {
            string toChuc = Tlv("00", bin) + Tlv("01", taiKhoan);
            string merchant = Tlv("38", Tlv("00", "A000000727") + Tlv("01", toChuc) + Tlv("02", "QRIBFTTA"));

            var sb = new StringBuilder();
            sb.Append(Tlv("00", "01"));
            sb.Append(Tlv("01", soTien > 0 ? "12" : "11"));
            sb.Append(merchant);
            sb.Append(Tlv("53", "704"));
            if (soTien > 0)
                sb.Append(Tlv("54", ((long)Math.Round(soTien)).ToString(CultureInfo.InvariantCulture)));
            sb.Append(Tlv("58", "VN"));

            string nd = LamSach(noiDung);
            if (nd.Length > 0) sb.Append(Tlv("62", Tlv("08", nd)));

            sb.Append("6304");
            sb.Append(Crc16(sb.ToString()));
            return sb.ToString();
        }

        ///<summary> CEC-16/CCITT-FALSE (poly 0x1021, init 0xFFFF). Kiểm thử: "123456789" -> "29B1".</summary>
        public static string Crc16(string s)
        {
            ushort crc = 0xFFFF;
            foreach (byte b in Encoding.ASCII.GetBytes(s))
            {
                crc ^= (ushort)(b << 8);
                for (int i = 0; i < 8; i++)
                    crc = (crc & 0x8000) != 0 ? (ushort)((crc << 1) ^ 0x1021) : (ushort)(crc << 1);
            }
            return crc.ToString("X4", CultureInfo.InvariantCulture);
        }

        private static string LamSach(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "";
            string d = s.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char c in d)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark) continue;
                if (c == 'đ') sb.Append('d');
                else if (c == 'Đ') sb.Append('D');
                else if (c < 128 && (char.IsLetterOrDigit(c) || c == ' ')) sb.Append(c);
            }
            string kq = sb.ToString().Trim();
            return kq.Length > 25 ? kq.Substring(0, 25) : kq;
        }

        public static Bitmap CreateQr(string payload, int pixelPerModule = 8)
        {
            using (var gen = new QRCodeGenerator())
            using (QRCodeData data = gen.CreateQrCode(payload, QRCodeGenerator.ECCLevel.M))
            using (var qr = new QRCode(data))
            {
                return qr.GetGraphic(pixelPerModule);
            }
        }
    }
}
