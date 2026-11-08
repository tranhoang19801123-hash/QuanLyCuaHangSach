using QuanLyCuaHangSach;
using System;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    /// <summary>Quản lý nhà cung cấp (CRUD bằng LINQ thông qua NhaCungCapRepository).</summary>
    public partial class frmSupplier : Form
    {
        private readonly NhaCungCapRepository _repo = new NhaCungCapRepository();
        private string _maDangChon;

        public frmSupplier()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            try { LoadData(); LamMoi(); }
            catch (Exception ex) { UiHelper.Error("Không tải được dữ liệu: " + ex.Message); }
        }

        private void LoadData()
        {
            var ds = _repo.GetAll(txtTimKiem.Text);
            dgv.DataSource = ds;
            dgv.ClearSelection();
            lblTongSo.Text = "Tổng: " + ds.Count + " nhà cung cấp";
        }

        private void LamMoi()
        {
            _maDangChon = null;
            txtMaNCC.Clear(); txtTenNCC.Clear(); txtDienThoai.Clear(); txtDiaChi.Clear();
            txtMaNCC.Enabled = true;
            dgv.ClearSelection();
            txtMaNCC.Focus();
        }

        private bool HopLe(bool them)
        {
            if (them && !UiHelper.IsMa(txtMaNCC.Text.Trim()))
            { UiHelper.Warn("Mã nhà cung cấp gồm chữ/số (tối đa 20 ký tự, không có khoảng trắng)."); txtMaNCC.Focus(); return false; }
            if (txtTenNCC.Text.Trim() == "")
            { UiHelper.Warn("Vui lòng nhập tên nhà cung cấp."); txtTenNCC.Focus(); return false; }
            if (!UiHelper.IsPhone(txtDienThoai.Text))
            { UiHelper.Warn("Số điện thoại không hợp lệ."); txtDienThoai.Focus(); return false; }
            return true;
        }

        private NhaCungCap DocForm()
        {
            return new NhaCungCap
            {
                MaNCC = txtMaNCC.Text.Trim(),
                TenNCC = txtTenNCC.Text.Trim(),
                DienThoai = UiHelper.NullIfEmpty(txtDienThoai.Text),
                DiaChi = UiHelper.NullIfEmpty(txtDiaChi.Text)
            };
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgv.Rows[e.RowIndex].DataBoundItem as NhaCungCapRow;
            if (row == null) return;
            _maDangChon = row.MaNCC;
            txtMaNCC.Text = row.MaNCC;
            txtTenNCC.Text = row.TenNCC;
            txtDienThoai.Text = row.DienThoai;
            txtDiaChi.Text = row.DiaChi;
            txtMaNCC.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!HopLe(true)) return;
            try
            {
                if (_repo.Exists(txtMaNCC.Text.Trim()))
                { UiHelper.Warn("Mã nhà cung cấp đã tồn tại."); return; }
                _repo.Add(DocForm());
                UiHelper.Info("Đã thêm nhà cung cấp.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không thêm được: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một nhà cung cấp trong danh sách để sửa."); return; }
            if (!HopLe(false)) return;
            try
            {
                _repo.Update(DocForm());
                UiHelper.Info("Đã cập nhật nhà cung cấp.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không sửa được: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một nhà cung cấp trong danh sách để xóa."); return; }
            try
            {
                if (_repo.DaPhatSinhDuLieu(_maDangChon))
                { UiHelper.Warn("Nhà cung cấp này đã có sách hoặc phiếu nhập, không thể xóa."); return; }
                if (!UiHelper.Confirm("Xóa nhà cung cấp \"" + txtTenNCC.Text + "\"?")) return;
                _repo.Delete(_maDangChon);
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không xóa được: " + ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { txtTimKiem.Clear(); LoadData(); LamMoi(); }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadData(); }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.XuatDataGridView(dgv, "Danh sách nhà cung cấp", "DanhSachNhaCungCap");
        }
    }
}
