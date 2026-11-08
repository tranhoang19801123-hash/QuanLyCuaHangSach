using QuanLyCuaHangSach;
using System;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    /// <summary>Quản lý thể loại sách (CRUD bằng LINQ thông qua TheLoaiRepository).</summary>
    public partial class frmCategory : Form
    {
        private readonly TheLoaiRepository _repo = new TheLoaiRepository();
        private string _maDangChon;          // null = đang ở chế độ thêm mới

        public frmCategory()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;  // cột đã được thiết kế sẵn trong Designer
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            try { LoadData(); LamMoi(); }
            catch (Exception ex) { UiHelper.Error("Không tải được dữ liệu: " + ex.Message); }
        }

        private void LoadData()
        {
            var ds = _repo.GetAll(txtTimKiem.Text);
            dgv.DataSource = ds;
            dgv.ClearSelection();
            lblTongSo.Text = "Tổng: " + ds.Count + " thể loại";
        }

        private void LamMoi()
        {
            _maDangChon = null;
            txtMaTL.Clear(); txtTenTL.Clear(); txtMoTa.Clear();
            txtMaTL.Enabled = true;
            dgv.ClearSelection();
            txtMaTL.Focus();
        }

        private bool HopLe(bool them)
        {
            if (them && !UiHelper.IsMa(txtMaTL.Text.Trim()))
            { UiHelper.Warn("Mã thể loại gồm chữ/số (tối đa 20 ký tự, không có khoảng trắng)."); txtMaTL.Focus(); return false; }
            if (txtTenTL.Text.Trim() == "")
            { UiHelper.Warn("Vui lòng nhập tên thể loại."); txtTenTL.Focus(); return false; }
            return true;
        }

        private TheLoai DocForm()
        {
            return new TheLoai
            {
                MaTL = txtMaTL.Text.Trim(),
                TenTL = txtTenTL.Text.Trim(),
                MoTa = UiHelper.NullIfEmpty(txtMoTa.Text)
            };
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgv.Rows[e.RowIndex].DataBoundItem as TheLoaiRow;
            if (row == null) return;
            _maDangChon = row.MaTL;
            txtMaTL.Text = row.MaTL;
            txtTenTL.Text = row.TenTL;
            txtMoTa.Text = row.MoTa;
            txtMaTL.Enabled = false;          // không cho sửa khóa chính
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!HopLe(true)) return;
            try
            {
                if (_repo.Exists(txtMaTL.Text.Trim()))
                { UiHelper.Warn("Mã thể loại đã tồn tại."); return; }
                _repo.Add(DocForm());
                UiHelper.Info("Đã thêm thể loại.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không thêm được: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một thể loại trong danh sách để sửa."); return; }
            if (!HopLe(false)) return;
            try
            {
                _repo.Update(DocForm());
                UiHelper.Info("Đã cập nhật thể loại.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không sửa được: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một thể loại trong danh sách để xóa."); return; }
            try
            {
                if (_repo.CoSach(_maDangChon))
                { UiHelper.Warn("Thể loại này đang có sách, không thể xóa."); return; }
                if (!UiHelper.Confirm("Xóa thể loại \"" + txtTenTL.Text + "\"?")) return;
                _repo.Delete(_maDangChon);
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không xóa được: " + ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { txtTimKiem.Clear(); LoadData(); LamMoi(); }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadData(); }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.XuatDataGridView(dgv, "Danh sách thể loại sách", "DanhSachTheLoai");
        }
    }
}
