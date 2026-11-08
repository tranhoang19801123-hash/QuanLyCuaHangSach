
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2.Forms
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
            btnDoi.Click += btnDoi_Click;
            btnHuy.Click += btnHuy_Click;
        }


        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (txtCu.Text == "" || txtMoi.Text == "" || txtXacNhan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            if (txtMoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.");
                return;
            }
            if (txtMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.");
                return;
            }
            if (txtMoi.Text == txtCu.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ.");
                return;
            }

            try
            {
                using (var db = ConnectionHelper.CreateContext())
                {
                    var nd = db.NguoiDungs.Single(x => x.TenDangNhap == Session.TenDangNhap);

                    if (!PasswordHelper.Verify(txtCu.Text, nd.Salt, nd.MatKhau))
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    nd.Salt = PasswordHelper.GenerateSalt();   // salt mới mỗi lần đổi
                    nd.MatKhau = PasswordHelper.HashPassword(txtMoi.Text, nd.Salt);
                    db.SubmitChanges();
                }

                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
    
}
