using QuanLyCuaHangSach;
using System;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    /// <summary>Quản lý khách hàng và hạng thành viên (hạng tự gợi ý theo điểm tích lũy).</summary>
    public partial class frmCustomer : Form
    {
        private readonly KhachHangRepository _repo = new KhachHangRepository();
        private string _maDangChon;
        private bool _dangNap;               // true khi đang nạp dữ liệu lên form (không tự gợi ý hạng)

        public frmCustomer()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            try { NapHang(); LoadData(); LamMoi(); }
            catch (Exception ex) { UiHelper.Error("Không tải được dữ liệu: " + ex.Message); }
        }

        private void NapHang()
        {
            cboHang.DisplayMember = "Text";
            cboHang.ValueMember = "Value";
            cboHang.DataSource = _repo.GetHangItems();
        }

        private void LoadData()
        {
            var ds = _repo.GetAll(txtTimKiem.Text);
            dgv.DataSource = ds;
            dgv.ClearSelection();
            string tk = _repo.ThongKeTheoHang();
            lblTongSo.Text = "Tổng: " + ds.Count + " khách hàng" + (tk == "" ? "" : "   •   " + tk);
        }

        private void LamMoi()
        {
            _maDangChon = null;
            _dangNap = true;
            txtMaKH.Clear(); txtHoTen.Clear(); txtDienThoai.Clear();
            nudDiem.Value = 0;
            if (cboHang.Items.Count > 0) cboHang.SelectedIndex = 0;
            _dangNap = false;
            txtMaKH.Enabled = true;
            dgv.ClearSelection();
            txtMaKH.Focus();
        }

        /// <summary>Đổi điểm thì tự chọn hạng tương ứng (người dùng vẫn có thể đổi tay sau đó).</summary>
        private void nudDiem_ValueChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            try
            {
                string ma = _repo.GoiYHang((int)nudDiem.Value);
                cboHang.SelectedValue = ma ?? "";
            }
            catch { /* bỏ qua lỗi gợi ý, không ảnh hưởng nhập liệu */ }
        }

        private bool HopLe(bool them)
        {
            if (them && !UiHelper.IsMa(txtMaKH.Text.Trim()))
            { UiHelper.Warn("Mã khách hàng gồm chữ/số (tối đa 20 ký tự, không có khoảng trắng)."); txtMaKH.Focus(); return false; }
            if (txtHoTen.Text.Trim() == "")
            { UiHelper.Warn("Vui lòng nhập họ tên khách hàng."); txtHoTen.Focus(); return false; }
            if (!UiHelper.IsPhone(txtDienThoai.Text))
            { UiHelper.Warn("Số điện thoại không hợp lệ."); txtDienThoai.Focus(); return false; }
            return true;
        }

        private KhachHang DocForm()
        {
            string maHang = UiHelper.NullIfEmpty(cboHang.SelectedValue as string);
            string tenHang = null;
            if (maHang != null)
            {
                var h = new HangThanhVienRepository().GetById(maHang);
                if (h != null) tenHang = h.TenHang;
            }
            return new KhachHang
            {
                MaKH = txtMaKH.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                DienThoai = UiHelper.NullIfEmpty(txtDienThoai.Text),
                DiemTichLuy = (int)nudDiem.Value,
                MaHang = maHang,
                HangThanhVien = tenHang
            };
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgv.Rows[e.RowIndex].DataBoundItem as KhachHangRow;
            if (row == null) return;
            var kh = _repo.GetById(row.MaKH);
            if (kh == null) return;

            _dangNap = true;
            _maDangChon = kh.MaKH;
            txtMaKH.Text = kh.MaKH;
            txtHoTen.Text = kh.HoTen;
            txtDienThoai.Text = kh.DienThoai;
            UiHelper.SetNum(nudDiem, kh.DiemTichLuy ?? 0);
            cboHang.SelectedValue = kh.MaHang ?? "";
            _dangNap = false;
            txtMaKH.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!HopLe(true)) return;
            try
            {
                var kh = DocForm();
                if (_repo.Exists(kh.MaKH)) { UiHelper.Warn("Mã khách hàng đã tồn tại."); return; }
                _repo.Add(kh);
                UiHelper.Info("Đã thêm khách hàng.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không thêm được: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một khách hàng trong danh sách để sửa."); return; }
            if (!HopLe(false)) return;
            try
            {
                _repo.Update(DocForm());
                UiHelper.Info("Đã cập nhật khách hàng.");
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không sửa được: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maDangChon == null) { UiHelper.Warn("Hãy chọn một khách hàng trong danh sách để xóa."); return; }
            try
            {
                if (_repo.DaCoHoaDon(_maDangChon))
                { UiHelper.Warn("Khách hàng này đã có hóa đơn, không thể xóa."); return; }
                if (!UiHelper.Confirm("Xóa khách hàng \"" + txtHoTen.Text + "\"?")) return;
                _repo.Delete(_maDangChon);
                LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Không xóa được: " + ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) { txtTimKiem.Clear(); LoadData(); LamMoi(); }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadData(); }

        private void btnQuanLyHang_Click(object sender, EventArgs e)
        {
            using (var f = new frmMemberTier())
                f.ShowDialog(this);
            try { NapHang(); LoadData(); LamMoi(); }      // nạp lại hạng sau khi chỉnh sửa
            catch (Exception ex) { UiHelper.Error(ex.Message); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.XuatDataGridView(dgv, "Danh sách khách hàng", "DanhSachKhachHang");
        }

        // ---------- Nhập Excel ----------
        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            var rows = ExcelHelper.DocFile("Nhập khách hàng từ Excel", 5);
            if (rows == null) return;
            if (!UiHelper.Confirm("Tìm thấy " + rows.Count + " dòng dữ liệu. Tiến hành nhập vào hệ thống?")) return;
            try
            {
                var kq = new ImportService().ImportKhachHang(rows);
                if (kq.Errors.Count == 0) UiHelper.Info(kq.TomTat());
                else UiHelper.Warn(kq.TomTat());
                NapHang(); LoadData(); LamMoi();
            }
            catch (Exception ex) { UiHelper.Error("Lỗi khi nhập: " + ex.Message); }
        }

        private void btnFileMau_Click(object sender, EventArgs e)
        {
            ExcelHelper.TaoFileMau("MauNhapKhachHang", "Nhập khách hàng từ Excel", ImportService.KhachHangCot, ImportService.KhachHangViDu,
                "Dòng 1 là tiêu đề. Để trống cột Hạng thì hệ thống tự tính theo điểm. Mã khách hàng không được trùng.");
        }
    }
}
