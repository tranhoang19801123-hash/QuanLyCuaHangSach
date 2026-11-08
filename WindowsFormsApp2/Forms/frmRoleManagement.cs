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
    public partial class frmRoleManagement : Form
    {
        public frmRoleManagement()
        {
            InitializeComponent();
            this.Load += frmRoleManagement_Load;

            // Đăng ký sự kiện các nút bấm và danh sách
            btnThemNhom.Click += btnThemNhom_Click;
            btnSuaNhom.Click += btnSuaNhom_Click;
            btnXoaNhom.Click += btnXoaNhom_Click;
            btnLuuQuyen.Click += btnLuuQuyen_Click;
            lstNhom.SelectedIndexChanged += lstNhom_SelectedIndexChanged;
        }
        private void frmRoleManagement_Load(object sender, EventArgs e)
        {
            LoadDanhSachChucNang();
            LoadDanhSachNhom();
        }

        // Tải danh sách nhóm quyền vào ListBox
        private void LoadDanhSachNhom()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                lstNhom.DataSource = db.PhanQuyens.ToList();
                lstNhom.DisplayMember = "TenQuyen";
                lstNhom.ValueMember = "MaQuyen";
            }
        }

        // Tải toàn bộ danh sách chức năng vào CheckedListBox
        private void LoadDanhSachChucNang()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var dsChucNang = db.ChucNangs.ToList();

                clbChucNang.DataSource = null;
                clbChucNang.Items.Clear();

                clbChucNang.DisplayMember = "TenChucNang";

                foreach (var chucNang in dsChucNang)
                {
                    clbChucNang.Items.Add(chucNang);
                }
            }
        }

        private void btnSuaNhom_Click(object sender, EventArgs e)
        {
            if (lstNhom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm quyền cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRole = lstNhom.SelectedItem as PhanQuyen;
            using (var db = ConnectionHelper.CreateContext())
            {
                var role = db.PhanQuyens.FirstOrDefault(r => r.MaQuyen == selectedRole.MaQuyen);
                if (role != null)
                {
                    role.TenQuyen = txtTenNhom.Text.Trim();
                    role.MoTa = txtMoTa.Text.Trim();

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật nhóm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhom();
                }
            }
        }


        private void lstNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNhom.SelectedItem != null)
            {
                // Lấy thông tin nhóm quyền đang chọn
                var selectedRole = lstNhom.SelectedItem as PhanQuyen;
                if (selectedRole != null)
                {
                    txtTenNhom.Text = selectedRole.TenQuyen;
                    txtMoTa.Text = selectedRole.MoTa; // Đảm bảo bảng PhanQuyen có cột MoTa, nếu không có bạn có thể bỏ dòng này

                    // Load các quyền đã được gán cho nhóm này vào CheckedListBox
                    using (var db = ConnectionHelper.CreateContext())
                    {
                        var assignedPermissions = db.PhanQuyen_ChucNangs
                            .Where(p => p.MaQuyen == selectedRole.MaQuyen)
                            .Select(p => p.MaChucNang)
                            .ToList();

                        for (int i = 0; i < clbChucNang.Items.Count; i++)
                        {
                            var chucNang = clbChucNang.Items[i] as ChucNang;
                            if (chucNang != null && assignedPermissions.Contains(chucNang.MaChucNang))
                            {
                                clbChucNang.SetItemChecked(i, true);
                            }
                            else
                            {
                                clbChucNang.SetItemChecked(i, false);
                            }
                        }
                    }
                }
            }
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            string tenNhom = txtTenNhom.Text.Trim();
            if (string.IsNullOrEmpty(tenNhom))
            {
                MessageBox.Show("Vui lòng nhập tên nhóm quyền!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = ConnectionHelper.CreateContext())
            {
                var newRole = new PhanQuyen
                {
                    TenQuyen = tenNhom,
                    MoTa = txtMoTa.Text.Trim()
                };

                db.PhanQuyens.InsertOnSubmit(newRole);
                db.SubmitChanges();

                MessageBox.Show("Thêm nhóm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNhom();
                ClearForm();
            }
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (lstNhom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm quyền cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRole = lstNhom.SelectedItem as PhanQuyen;
            if (MessageBox.Show($"Bạn có chắc chắn muốn xoá nhóm quyền '{selectedRole.TenQuyen}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = ConnectionHelper.CreateContext())
                {
                    var role = db.PhanQuyens.FirstOrDefault(r => r.MaQuyen == selectedRole.MaQuyen);
                    if (role != null)
                    {
                        // Xoá các phân quyền chi tiết liên quan trước để tránh lỗi khóa ngoại
                        var details = db.PhanQuyen_ChucNangs.Where(p => p.MaQuyen == role.MaQuyen);
                        db.PhanQuyen_ChucNangs.DeleteAllOnSubmit(details);

                        db.PhanQuyens.DeleteOnSubmit(role);
                        db.SubmitChanges();

                        MessageBox.Show("Xoá nhóm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNhom();
                        ClearForm();
                    }
                }
            }
        }

        private void btnLuuQuyen_Click(object sender, EventArgs e)
        {
            if (lstNhom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm quyền cần lưu phân quyền!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRole = lstNhom.SelectedItem as PhanQuyen;
            using (var db = ConnectionHelper.CreateContext())
            {
                // Xoá toàn bộ quyền cũ của nhóm này
                var oldPermissions = db.PhanQuyen_ChucNangs.Where(p => p.MaQuyen == selectedRole.MaQuyen);
                db.PhanQuyen_ChucNangs.DeleteAllOnSubmit(oldPermissions);

                // Thêm các quyền mới được tích chọn trong CheckedListBox
                foreach (var item in clbChucNang.CheckedItems)
                {
                    var chucNang = item as ChucNang;
                    if (chucNang != null)
                    {
                        var newPerm = new PhanQuyen_ChucNang
                        {
                            MaQuyen = selectedRole.MaQuyen,
                            MaChucNang = chucNang.MaChucNang,
                            CoQuyen = true
                        };
                        db.PhanQuyen_ChucNangs.InsertOnSubmit(newPerm);
                    }
                }

                db.SubmitChanges();
                MessageBox.Show("Lưu phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearForm()
        {
            txtTenNhom.Clear();
            txtMoTa.Clear();
            for (int i = 0; i < clbChucNang.Items.Count; i++)
            {
                clbChucNang.SetItemChecked(i, false);
            }
        }

        private void frmRoleManagement_Load_1(object sender, EventArgs e)
        {

        }
    }
}
