using QuanLyCuaHangSach;
using System;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    /// <summary>Quản lý nhân viên (CRUD bằng LINQ thông qua NhanVienRepository).</summary>
    public partial class frmEmployee : Form
    {
        private readonly NhanVienRepository _repo = new NhanVienRepository();
        private string _maDangChon;

        public frmEmployee()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            try { LoadData(); LamMoi(); }
            catch (Exception ex) { UiHelper.Error("Không tải được dữ liệu: " + ex.Message); }
        }

        private void NapTaiKhoan(string giuLai)
        {
            cboTaiKhoan.DisplayMember = "Text";
            cboTaiKhoan.ValueMember = "Value";
            cboTaiKhoan.DataSource = _repo.GetTaiKhoanItems(giuLai);
            cboTaiKhoan.SelectedValue = giuLai ?? "";
        }

        private void LoadData()
        {
            var ds = _repo.GetAll(txtTimKiem.Text);
            dgv.DataSource = ds;
            dgv.ClearSelection();
            lblTongSo.Text = "Tổng: " + ds.Count + " nhân viên";
        }

        private void LamMoi()
        {
            _maDangChon = null;
            txtMaNV.Clear(); txtHoTen.Clear(); txtDienThoai.Clear(); txtEmail.Clear(); txtDiaChi.Clear();
            txtMaNV.Enabled = true;
            NapTaiKhoan(null);
            dgv.ClearSelection();
            txtMaNV.Focus();
        }

        private bool HopLe(bool them)
        {
            if (them && !UiHelper.IsMa(txtMaNV.Text.Trim()))
            { UiHelper.Warn("Mã nhân viên gồm chữ/số (tối đa 20 ký tự, không có khoảng trắng)."); txtMaNV.Focus(); return false; }
            if (txtHoTen.Text.Trim() == "")
            { UiHelper.Warn("Vui lòng nhập họ tên nhân viên."); txtHoTen.Focus(); return false; }
            if (!UiHelper.IsPhone(txtDienThoai.Text))
            { UiHelper.Warn("Số điện thoại không hợp lệ."); txtDienThoai.Focus(); return false; }
            if (!UiHelper.IsEmail(txtEmail.Text))
            { UiHelper.Warn("Email không hợp lệ."); txtEmail.Focus(); return false; }
            return true;
        }

        private NhanVien DocForm()
        {
            return new NhanVien
            {
                MaNV = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                DienThoai = UiHelper.NullIfEmpty(txtDienThoai.Text),
                Email = UiHelper.NullIfEmpty(txtEmail.Text),
                DiaChi = UiHelper.NullIfEmpty(txtDiaChi.Text),
                TenDangNhap = UiHelper.NullIfEmpty(cboTaiKhoan.SelectedValue as string)
            };
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgv.Rows[e.RowIndex].DataBoundItem as NhanVienRow;
            if (row == null) return;
            _maDangChon = row.MaNV;
            txtMaNV.Text = row.MaNV;
            txtHoTen.Text = row.HoTen;
            txtDienThoai.Text = row.DienThoai;
            txtEmail.Text = row.Email;
            txtDiaChi.Text = row.DiaChi;
            NapTaiKhoan(row.TenDangNhap);
            txtMaNV.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!HopLe(true)) return;
            try
            {
                var nv = DocForm();
                if (_repo.Exists(nv.MaNV)) { UiHelper.Warn("Mã nhân viên đã tồn tại."); return; }
                if (_repo.TaiKhoanDaDung(nv.TenDangNhap, null))
                { UiHelper.Warn("Tài khoản này đã gắn với nhân viên khác."); return; }
                _repo.Add(nv);
                UiHelper.Info("Đã thêm nhân viên.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không thêm được: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một nhân viên trong danh sách để sửa."); return; }
            if (!HopLe(false)) return;
            try
            {
                var nv = DocForm();
                if (_repo.TaiKhoanDaDung(nv.TenDangNhap, nv.MaNV))
                { UiHelper.Warn("Tài khoản này đã gắn với nhân viên khác."); return; }
                _repo.Update(nv);
                UiHelper.Info("Đã cập nhật nhân viên.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không sửa được: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một nhân viên trong danh sách để xóa."); return; }
            try
            {
                if (_repo.DaPhatSinhGiaoDich(_maDangChon))
                { UiHelper.Warn("Nhân viên này đã lập hóa đơn / phiếu nhập, không thể xóa."); return; }
                if (!UiHelper.Confirm("Xóa nhân viên \"" + txtHoTen.Text + "\"?")) return;
                _repo.Delete(_maDangChon);
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không xóa được: " + ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { txtTimKiem.Clear(); LoadData(); LamMoi(); }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadData(); }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.XuatDataGridView(dgv, "Danh sách nhân viên", "DanhSachNhanVien");
        }
    }
}
