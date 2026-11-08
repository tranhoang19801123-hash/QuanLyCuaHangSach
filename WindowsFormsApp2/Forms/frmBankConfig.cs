using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Forms
{
    public partial class frmBankConfig : Form
    {
        public frmBankConfig()
        {
            InitializeComponent();
        }

        private void frmBankConfig_Load(object sender, EventArgs e)
        {
            BankInfo info = BankSecret.Load();

            if(info != null)
            {
                txtBin.Text = info.Bin;
                txtTenNganHang.Text = info.BankName;
                txtSoTaiKhoan.Text = info.AccountNo;
                txtTenTaiKhoan.Text = info.AccountName;
            }
        }

        private void chkHienSo_CheckedChanged(object sender, EventArgs e)
        {
            txtSoTaiKhoan.UseSystemPasswordChar = !chkHienSo.Checked;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string bin = txtBin.Text.Trim();
            string tenNganHang = txtTenNganHang.Text.Trim();
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();
            string tenTaiKhoan = txtTenTaiKhoan.Text.Trim();

            if(string.IsNullOrWhiteSpace(bin) || string.IsNullOrWhiteSpace(tenNganHang) || string.IsNullOrWhiteSpace(soTaiKhoan) || string.IsNullOrWhiteSpace(tenTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ngân hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bin.Length != 6 || !bin.All(c => c >= '0' && c <= '9'))
            {
                MessageBox.Show("Mã BIN phải gồm đúng 6 chữ số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtBin.Focus();
                return;
            }

            if (!Regex.IsMatch(soTaiKhoan, @"^\d{6,19}$"))
            {
                MessageBox.Show("Số tài khoản gồm từ 6 đến 19 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSoTaiKhoan.Focus();
                return;
            }

            try
            {
                BankInfo info = new BankInfo
                {
                    Bin = bin,
                    BankName = tenNganHang,
                    AccountNo = soTaiKhoan,
                    AccountName = tenTaiKhoan.ToUpper()
                };

                BankSecret.Save(info);

                MessageBox.Show("Lưu cấu hình tài khoản ngân hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể lưu cấu hình ngân hàng!\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
