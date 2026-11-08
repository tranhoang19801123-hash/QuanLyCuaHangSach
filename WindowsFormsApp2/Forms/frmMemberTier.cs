using QuanLyCuaHangSach;
using System;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    /// <summary>Hộp thoại quản lý hạng thành viên (mở từ frmCustomer): tên hạng, % giảm giá, điểm tối thiểu.</summary>
    public partial class frmMemberTier : Form
    {
        private readonly HangThanhVienRepository _repo = new HangThanhVienRepository();
        private string _maDangChon;

        public frmMemberTier()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
        }

        private void frmMemberTier_Load(object sender, EventArgs e)
        {
            try { LoadData(); LamMoi(); }
            catch (Exception ex) { UiHelper.Error("Không tải được dữ liệu: " + ex.Message); }
        }

        private void LoadData()
        {
            var ds = _repo.GetAll(txtTimKiem.Text);
            dgv.DataSource = ds;
            dgv.ClearSelection();
            lblTongSo.Text = "Tổng: " + ds.Count + " hạng";
        }

        private void LamMoi()
        {
            _maDangChon = null;
            txtMaHang.Clear(); txtTenHang.Clear();
            nudGiam.Value = 0; nudDiemToiThieu.Value = 0;
            txtMaHang.Enabled = true;
            dgv.ClearSelection();
            txtMaHang.Focus();
        }

        private bool HopLe(bool them)
        {
            if (them && !UiHelper.IsMa(txtMaHang.Text.Trim()))
            { UiHelper.Warn("Mã hạng gồm chữ/số (tối đa 20 ký tự, không có khoảng trắng)."); txtMaHang.Focus(); return false; }
            if (txtTenHang.Text.Trim() == "")
            { UiHelper.Warn("Vui lòng nhập tên hạng."); txtTenHang.Focus(); return false; }
            return true;
        }

        private HangThanhVien DocForm()
        {
            return new HangThanhVien
            {
                MaHang = txtMaHang.Text.Trim(),
                TenHang = txtTenHang.Text.Trim(),
                PhanTramGiam = (float)nudGiam.Value,
                DiemToiThieu = (int)nudDiemToiThieu.Value
            };
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgv.Rows[e.RowIndex].DataBoundItem as HangRow;
            if (row == null) return;
            _maDangChon = row.MaHang;
            txtMaHang.Text = row.MaHang;
            txtTenHang.Text = row.TenHang;
            UiHelper.SetNum(nudGiam, (decimal)row.PhanTramGiam);
            UiHelper.SetNum(nudDiemToiThieu, row.DiemToiThieu);
            txtMaHang.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!HopLe(true)) return;
            try
            {
                if (_repo.Exists(txtMaHang.Text.Trim())) { UiHelper.Warn("Mã hạng đã tồn tại."); return; }
                _repo.Add(DocForm());
                UiHelper.Info("Đã thêm hạng thành viên.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không thêm được: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một hạng trong danh sách để sửa."); return; }
            if (!HopLe(false)) return;
            try
            {
                _repo.Update(DocForm());
                UiHelper.Info("Đã cập nhật hạng thành viên.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không sửa được: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một hạng trong danh sách để xóa."); return; }
            try
            {
                if (_repo.CoKhachHang(_maDangChon))
                { UiHelper.Warn("Hạng này đang có khách hàng, không thể xóa."); return; }
                if (!UiHelper.Confirm("Xóa hạng \"" + txtTenHang.Text + "\"?")) return;
                _repo.Delete(_maDangChon);
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không xóa được: " + ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { txtTimKiem.Clear(); LoadData(); LamMoi(); }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadData(); }

        private void btnDong_Click(object sender, EventArgs e) { Close(); }
    }
}
