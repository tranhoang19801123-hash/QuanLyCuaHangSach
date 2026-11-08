
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Forms
{
    public partial class frmQRPayment : Form
    {
        private string _maHD;
        private decimal _soTien;
        private Bitmap _anhQR;

        // Constructor mặc định để Visual Studio mở Designer
        public frmQRPayment()
        {
            InitializeComponent();

            _maHD = string.Empty;
            _soTien = 0m;
        }

        // Constructor nhận mã hóa đơn và số tiền cần thanh toán
        public frmQRPayment(string maHD, decimal soTien) : this()
        {
            _maHD = maHD;
            _soTien = soTien;
        }

        // Khi Form được mở
        private void frmQRPayment_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_maHD))
                {
                    throw new InvalidOperationException(
                        "Không có mã hóa đơn để tạo mã QR."
                    );
                }

                if (_soTien <= 0)
                {
                    throw new InvalidOperationException(
                        "Số tiền thanh toán phải lớn hơn 0."
                    );
                }

                // Lấy thông tin ngân hàng đã lưu
                BankInfo bankInfo = BankSecret.Load();

                if (bankInfo == null)
                {
                    throw new InvalidOperationException(
                        "Bạn chưa cấu hình tài khoản nhận tiền VietQR. " +
                        "Vui lòng vào phần cấu hình ngân hàng để cập nhật."
                    );
                }

                // Lấy mã BIN và số tài khoản
                string bin = bankInfo.Bin;
                string taiKhoan = bankInfo.AccountNo;

                // Kiểm tra thông tin ngân hàng
                if (string.IsNullOrWhiteSpace(bin) ||
                    !System.Text.RegularExpressions.Regex.IsMatch(bin, @"^\d{6}$") ||
                    string.IsNullOrWhiteSpace(taiKhoan) ||
                    !System.Text.RegularExpressions.Regex.IsMatch(taiKhoan, @"^\d{6,19}$"))
                {
                    throw new InvalidOperationException(
                        "Mã ngân hàng hoặc số tài khoản VietQR không hợp lệ."
                    );
                }

                // Hiển thị thông tin hóa đơn
                txtTimMaHD.Text = _maHD;
                txtThanhTien.Text = Money.Fmt(_soTien) + " đ";

                lblNguoiNhan.Text =
                    "Người nhận: " +
                    bankInfo.AccountName +
                    " - " +
                    bankInfo.BankName;

                // Tạo nội dung thanh toán
                string noiDung = "THANH TOAN " + _maHD;

                string payload = VietQRHelper.BuildPayload(
                    bin,
                    taiKhoan,
                    _soTien,
                    noiDung
                );

                // Tạo ảnh QR
                _anhQR = VietQRHelper.CreateQr(payload, 8);

                picQR.Image = _anhQR;
            }
            catch (Exception ex)
            {
                UiHelper.Error(
                    "Không tạo được mã QR: " + ex.Message
                );

                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        // Nút đóng
        private void btnDong_Click_1(object sender, EventArgs e)
        {
            // Đóng màn hình QR (sau khi khách quét xong): frmSales sẽ hỏi lại xác nhận đã nhận tiền chưa
            DialogResult = DialogResult.OK;
            Close();
        }

        // Giải phóng ảnh QR khi đóng Form
        private void frmQRPayment_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            picQR.Image = null;

            if (_anhQR != null)
            {
                _anhQR.Dispose();
                _anhQR = null;
            }
        }


    }
}
