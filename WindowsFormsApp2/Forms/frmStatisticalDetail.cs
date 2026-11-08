
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    public partial class frmStatisticalDetail : Form
    {
        private readonly ThongKeRepository _repo = new ThongKeRepository();

        public frmStatisticalDetail()
        {
            InitializeComponent();
            dgvThongKeChiTiet.AutoGenerateColumns = false;
            MaHD.DataPropertyName = "MaHD";       
            MaHD.DefaultCellStyle.Format = "";
        }

        private void frmStatisticalDetail_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                1
            );

            dtpDenNgay.Value = DateTime.Now;

            // Cấu hình DataGridView
            dgvThongKeChiTiet.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvThongKeChiTiet.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvThongKeChiTiet.ReadOnly = true;
            dgvThongKeChiTiet.AllowUserToAddRows = false;
            dgvThongKeChiTiet.RowHeadersVisible = false;
            dgvThongKeChiTiet.BackgroundColor = Color.White;

            // Nạp dữ liệu cho các ComboBox
            NapDuLieuChoCacOLoc();
        }

        // Nạp danh sách nhân viên, khách hàng và thể loại
        private void NapDuLieuChoCacOLoc()
        {
            try
            {
                GanDanhSach(
                    cboLocNhanVien,
                    _repo.GetNhanVienLoc()
                );

                GanDanhSach(
                    cboLocKhachHang,
                    _repo.GetKhachHangLoc()
                );

                GanDanhSach(
                    cboLocTheLoai,
                    _repo.GetTheLoaiLoc()
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách lọc: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Gán dữ liệu vào ComboBox
        private static void GanDanhSach(
            Guna2ComboBox cbo,
            System.Collections.Generic.List<LocItem> ds)
        {
            cbo.DisplayMember = "Text";
            cbo.ValueMember = "Value";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.DataSource = ds;

            if (cbo.Items.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }
        }

        // Lấy giá trị được chọn trong ComboBox
        private static string LayGiaTri(Guna2ComboBox cbo)
        {
            return Convert.ToString(cbo.SelectedValue) ?? "";
        }

        // Thực hiện thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            // Kiểm tra khoảng ngày
            if (tuNgay > denNgay)
            {
                MessageBox.Show(
                    "Ngày bắt đầu không được lớn hơn ngày kết thúc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                // Lấy hóa đơn theo các tiêu chí đã chọn
                var danhSachHD = _repo.GetHoaDonTheoTieuChi(
                    tuNgay,
                    denNgay,
                    LayGiaTri(cboLocNhanVien),
                    LayGiaTri(cboLocKhachHang),
                    LayGiaTri(cboLocTheLoai)
                );

                // Hiển thị dữ liệu
                dgvThongKeChiTiet.DataSource = null;
                dgvThongKeChiTiet.DataSource = danhSachHD;

                // Đặt tên cột
                if (dgvThongKeChiTiet.Columns["MaHD"] != null)
                {
                    dgvThongKeChiTiet.Columns["MaHD"].HeaderText =
                        "Mã Hóa Đơn";
                }

                if (dgvThongKeChiTiet.Columns["NgayLap"] != null)
                {
                    dgvThongKeChiTiet.Columns["NgayLap"].HeaderText =
                        "Ngày Lập";

                    dgvThongKeChiTiet.Columns["NgayLap"]
                        .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                if (dgvThongKeChiTiet.Columns["KhachHang"] != null)
                {
                    dgvThongKeChiTiet.Columns["KhachHang"].HeaderText =
                        "Khách Hàng";
                }

                if (dgvThongKeChiTiet.Columns["NhanVien"] != null)
                {
                    dgvThongKeChiTiet.Columns["NhanVien"].HeaderText =
                        "Nhân Viên";
                }

                if (dgvThongKeChiTiet.Columns["ThanhTien"] != null)
                {
                    dgvThongKeChiTiet.Columns["ThanhTien"].HeaderText =
                        "Thành Tiền (VNĐ)";

                    dgvThongKeChiTiet.Columns["ThanhTien"]
                        .DefaultCellStyle.Format = "N0";
                }

                // Tính tổng doanh thu
                decimal tongDoanhThu = danhSachHD.Sum(
                    x => x.ThanhTien
                );

                // Tính doanh thu trung bình mỗi hóa đơn
                decimal trungBinh = danhSachHD.Count > 0
                    ? tongDoanhThu / danhSachHD.Count
                    : 0m;

                // Hiển thị kết quả tổng hợp
                lblTongTien.AutoSize = true;

                lblTongTien.Text =
                    "Số hóa đơn: " + danhSachHD.Count +
                    "  |  Tổng doanh thu: " +
                    tongDoanhThu.ToString("N0") + " VNĐ" +
                    "  |  Trung bình/HĐ: " +
                    trungBinh.ToString("N0") + " VNĐ";

                // Thông báo khi không có dữ liệu
                if (danhSachHD.Count == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy hóa đơn phù hợp với khoảng ngày và tiêu chí đã chọn.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thống kê: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
