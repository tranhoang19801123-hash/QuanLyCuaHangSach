
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnThoat.Click += btnThoat_Click;
            lnkCauHinh.LinkClicked += lnkCauHinh_LinkClicked;
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = ConnectionHelper.CreateContext())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == username);

                if (user == null)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại trong hệ thống!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (user.TrangThai == false)
                {
                    MessageBox.Show("Tài khoản này đã bị khóa!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra mật khẩu
                bool isLoginSuccess =
                    PasswordHelper.Verify(password, user.Salt, user.MatKhau);

                if (!isLoginSuccess)
                {
                    MessageBox.Show("Mật khẩu không chính xác!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lưu thông tin người đăng nhập
                Session.TenDangNhap = user.TenDangNhap;
                Session.HoTen = user.HoTen;
                Session.MaQuyen = user.MaQuyen;

                // Nạp danh sách chức năng được cấp quyền
                Session.Quyen = new HashSet<string>(
                    db.PhanQuyen_ChucNangs
                      .Where(p => p.MaQuyen == user.MaQuyen && p.CoQuyen)
                      .Select(p => p.MaChucNang)
                );

                MessageBox.Show("Đăng nhập thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain mainForm = new frmMain();
                mainForm.Show();

                this.Hide();
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkCauHinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form cấu hình kết nối CSDL
            frmConnectionConfig frm = new frmConnectionConfig();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
