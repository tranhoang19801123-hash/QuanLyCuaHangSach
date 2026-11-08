using QuanLyCuaHangSach;
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
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
            dgvUser.AutoGenerateColumns = false;   // cột đã thiết kế sẵn trong Designer
            this.Load += frmUserManagement_Load;

            // Đăng ký sự kiện các nút bấm (nếu chưa gán trong Designer)
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnKhoa.Click += btnKhoa_Click;
            btnMoi.Click += btnMoi_Click;
            btnResetMK.Click += btnResetMK_Click;
            dgvUser.CellClick += dgvUser_CellContentClick; // Khớp với hàm dgvUser_CellContentClick
            txtTimKiem.TextChanged += textBox5_TextChanged; // Khớp với hàm textBox5_TextChanged
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text.Trim());
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            LoadNhomQuyen();
            LoadData();
        }
        // Tải danh sách nhóm quyền vào ComboBox
        private void LoadNhomQuyen()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                cboNhom.DataSource = db.PhanQuyens.ToList();
                cboNhom.DisplayMember = "TenQuyen";
                cboNhom.ValueMember = "MaQuyen";
            }
        }

        // Tải danh sách người dùng lên DataGridView
        private void LoadData(string keyword = "")
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var query = db.NguoiDungs.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(u => u.TenDangNhap.Contains(keyword) || (u.HoTen != null && u.HoTen.Contains(keyword)));
                }

                dgvUser.DataSource = query.Select(u => new
                {
                    u.TenDangNhap,
                    u.HoTen,
                    u.Email,
                    u.MaQuyen,
                    TrangThai = (u.TrangThai ?? false) ? "Hoạt động" : "Đã khóa"
                }).ToList();
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                txtUser.Text = row.Cells["TenDangNhap"].Value?.ToString();
                txtUser.Enabled = false; // Khóa tên đăng nhập khi sửa

                using (var db = ConnectionHelper.CreateContext())
                {
                    var user = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == txtUser.Text.Trim());
                    if (user != null)
                    {
                        txtHoTen.Text = user.HoTen;
                        txtEmail.Text = user.Email;
                        if (user.MaQuyen != null) cboNhom.SelectedValue = user.MaQuyen;
                        chkHoatDong.Checked = user.TrangThai ?? false;
                    }
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = ConnectionHelper.CreateContext())
            {
                var existing = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == username);
                if (existing != null)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo Salt và mã hóa mật khẩu chuẩn bảo mật SHA-256
                string salt = PasswordHelper.CreateSalt();
                string hashedPassword = PasswordHelper.HashPassword(password, salt);

                var newUser = new NguoiDung
                {
                    TenDangNhap = username,
                    MatKhau = hashedPassword,
                    Salt = salt,
                    HoTen = txtHoTen.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MaQuyen = cboNhom.SelectedValue != null ? (int?)int.Parse(cboNhom.SelectedValue.ToString()) : null,
                    TrangThai = chkHoatDong.Checked
                };

                db.NguoiDungs.InsertOnSubmit(newUser);
                db.SubmitChanges();

                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnMoi_Click(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = ConnectionHelper.CreateContext())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == username);
                if (user != null)
                {
                    user.HoTen = txtHoTen.Text.Trim();
                    user.Email = txtEmail.Text.Trim();
                    user.MaQuyen = cboNhom.SelectedValue != null ? (int?)int.Parse(cboNhom.SelectedValue.ToString()) : null;
                    user.TrangThai = chkHoatDong.Checked;

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnMoi_Click(sender, e);
                }
            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần khoá/mở khoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = ConnectionHelper.CreateContext())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == username);
                if (user != null)
                {
                    user.TrangThai = !(user.TrangThai ?? false);
                    db.SubmitChanges();

                    MessageBox.Show(user.TrangThai == true ? "Đã mở khóa tài khoản thành công!" : "Đã khóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void btnResetMK_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần đặt lại mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn đặt lại mật khẩu của tài khoản này thành '123456'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = ConnectionHelper.CreateContext())
                {
                    var user = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == username);
                    if (user != null)
                    {
                        string newSalt = PasswordHelper.CreateSalt();
                        user.Salt = newSalt;
                        user.MatKhau = PasswordHelper.HashPassword("123456", newSalt);

                        db.SubmitChanges();
                        MessageBox.Show("Đặt lại mật khẩu thành công thành '123456'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtUser.Enabled = true; // Mở lại khóa tên đăng nhập để nhập mới
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtTimKiem.Clear();
            chkHoatDong.Checked = true;
            if (cboNhom.Items.Count > 0) cboNhom.SelectedIndex = 0;
            LoadData();
        }

        private void frmUserManagement_Load_1(object sender, EventArgs e)
        {

        }
    }
}
