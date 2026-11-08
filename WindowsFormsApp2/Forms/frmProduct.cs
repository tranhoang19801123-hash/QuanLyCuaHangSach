using QuanLyCuaHangSach;
using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    /// <summary>Quản lý sách: thêm, sửa, xóa, tìm kiếm theo mã/tên/tác giả, xuất Excel.</summary>
    public partial class frmProduct : Form
    {
        private readonly SachRepository _repo = new SachRepository();
        private readonly TheLoaiRepository _tlRepo = new TheLoaiRepository();
        private readonly NhaCungCapRepository _nccRepo = new NhaCungCapRepository();
        private string _maDangChon;

        public frmProduct()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            try { NapComboBox(); LoadData(); LamMoi(); }
            catch (Exception ex) { UiHelper.Error("Không tải được dữ liệu: " + ex.Message); }
        }

        private void NapComboBox()
        {
            cboTheLoai.DisplayMember = "Text"; cboTheLoai.ValueMember = "Value";
            cboTheLoai.DataSource = _tlRepo.GetItems();

            cboNCC.DisplayMember = "Text"; cboNCC.ValueMember = "Value";
            cboNCC.DataSource = _nccRepo.GetItems(true);
        }

        private void LoadData()
        {
            var ds = _repo.GetAll(txtTimKiem.Text);
            dgv.DataSource = ds;
            dgv.ClearSelection();
            lblTongSo.Text = "Tổng: " + ds.Count + " đầu sách   •   Tồn kho: " + ds.Sum(x => x.SoLuongTon).ToString("N0") + " cuốn";
        }

        private void LamMoi()
        {
            _maDangChon = null;
            txtMaSP.Clear(); txtTenSP.Clear(); txtTacGia.Clear();
            nudGiaNhap.Value = 0; nudGiaBan.Value = 0; nudTonKho.Value = 0;
            if (cboTheLoai.Items.Count > 0) cboTheLoai.SelectedIndex = 0;
            if (cboNCC.Items.Count > 0) cboNCC.SelectedIndex = 0;
            txtMaSP.Enabled = true;
            dgv.ClearSelection();
            txtMaSP.Focus();
        }

        private bool HopLe(bool them)
        {
            if (them && !UiHelper.IsMa(txtMaSP.Text.Trim()))
            { UiHelper.Warn("Mã sách gồm chữ/số (tối đa 20 ký tự, không có khoảng trắng)."); txtMaSP.Focus(); return false; }
            if (txtTenSP.Text.Trim() == "")
            { UiHelper.Warn("Vui lòng nhập tên sách."); txtTenSP.Focus(); return false; }
            if (string.IsNullOrEmpty(cboTheLoai.SelectedValue as string))
            { UiHelper.Warn("Vui lòng chọn thể loại (nếu chưa có, hãy thêm ở mục Thể loại sách)."); cboTheLoai.Focus(); return false; }
            if (nudGiaBan.Value <= 0)
            { UiHelper.Warn("Giá bán phải lớn hơn 0."); nudGiaBan.Focus(); return false; }
            if (nudGiaBan.Value < nudGiaNhap.Value)
            { UiHelper.Warn("Giá bán không được nhỏ hơn giá nhập."); nudGiaBan.Focus(); return false; }
            return true;
        }

        private SanPham DocForm()
        {
            return new SanPham
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                TacGia = UiHelper.NullIfEmpty(txtTacGia.Text),
                MaTL = cboTheLoai.SelectedValue as string,
                TheLoai = cboTheLoai.Text,
                MaNCC = UiHelper.NullIfEmpty(cboNCC.SelectedValue as string),
                GiaNhap = nudGiaNhap.Value,
                GiaBan = nudGiaBan.Value,
                SoLuongTon = (int)nudTonKho.Value
            };
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgv.Rows[e.RowIndex].DataBoundItem as SachRow;
            if (row == null) return;
            var sp = _repo.GetById(row.MaSP);
            if (sp == null) return;

            _maDangChon = sp.MaSP;
            txtMaSP.Text = sp.MaSP;
            txtTenSP.Text = sp.TenSP;
            txtTacGia.Text = sp.TacGia;
            UiHelper.SetNum(nudGiaNhap, sp.GiaNhap ?? 0);
            UiHelper.SetNum(nudGiaBan, sp.GiaBan ?? 0);
            UiHelper.SetNum(nudTonKho, sp.SoLuongTon ?? 0);
            cboTheLoai.SelectedValue = sp.MaTL ?? "";
            cboNCC.SelectedValue = sp.MaNCC ?? "";
            txtMaSP.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!HopLe(true)) return;
            try
            {
                var sp = DocForm();
                if (_repo.Exists(sp.MaSP)) { UiHelper.Warn("Mã sách đã tồn tại."); return; }
                _repo.Add(sp);
                UiHelper.Info("Đã thêm sách.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không thêm được: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một cuốn sách trong danh sách để sửa."); return; }
            if (!HopLe(false)) return;
            try
            {
                _repo.Update(DocForm());
                UiHelper.Info("Đã cập nhật sách.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không sửa được: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một cuốn sách trong danh sách để xóa."); return; }
            try
            {
                if (_repo.DaPhatSinhGiaoDich(_maDangChon))
                { UiHelper.Warn("Sách này đã có trong hóa đơn / phiếu nhập, không thể xóa."); return; }
                if (!UiHelper.Confirm("Xóa sách \"" + txtTenSP.Text + "\"?")) return;
                _repo.Delete(_maDangChon);
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không xóa được: " + ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { txtTimKiem.Clear(); LoadData(); LamMoi(); }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadData(); }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.XuatDataGridView(dgv, "Danh sách sách", "DanhSachSach");
        }

        // ---------- Nhập Excel ----------
        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            var rows = ExcelHelper.DocFile("Nhập sách từ Excel", 8);
            if (rows == null) return;
            if (!UiHelper.Confirm("Tìm thấy " + rows.Count + " dòng dữ liệu. Tiến hành nhập vào hệ thống?")) return;
            try
            {
                var kq = new ImportService().ImportSach(rows);
                if (kq.Errors.Count == 0) UiHelper.Info(kq.TomTat());
                else UiHelper.Warn(kq.TomTat());
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Lỗi khi nhập: " + ex.Message); }
        }

        private void btnFileMau_Click(object sender, EventArgs e)
        {
            ExcelHelper.TaoFileMau("MauNhapSach", "Nhập sách từ Excel", ImportService.SachCot, ImportService.SachViDu,
                "Dòng 1 là tiêu đề. Thể loại / nhà cung cấp có thể ghi mã hoặc tên (phải có sẵn trong hệ thống). Mã sách không được trùng.");
        }
    }
}
