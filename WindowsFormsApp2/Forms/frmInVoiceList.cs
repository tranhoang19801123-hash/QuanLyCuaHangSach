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
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    public partial class frmInVoiceList : Form
    {
        private readonly BanHangRepository _repo = new BanHangRepository();
        public frmInVoiceList()
        {
            InitializeComponent();

            // Cột của lưới được thiết kế sẵn trong Designer (thuộc tính này không chỉnh được trong Designer)
            dgvDanhSachHoaDon.AutoGenerateColumns = false;
        }

        //------------------------Sự kiện (gắn trong Designer, tab Events)---------------------

        private void dgvDanhSachHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnXemChiTiet_Click(sender, e);
        }

        private void frmInVoiceList_Load(object sender, EventArgs e)
        {
            try
            {
                DatLaiBoLoc();
                TaiDanhSach();
            }
            catch (Exception ex)
            {
                UiHelper.Error("Không tải được danh sách hóa đơn: " + ex.Message);
            }
        }

        private void DatLaiBoLoc()
        {
            txtTimMaHD.Clear();
            txtTimKhachHang.Clear();

            DateTime homNay = DateTime.Today;

            dtpTuNgay.Value = new DateTime(homNay.Year, homNay.Month, 1);
            dtpDenNgay.Value = homNay;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSach();
        }

        // Nhấn Enter trong ô mã hóa đơn
        private void txtTimMaHD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiDanhSach();
            }
        }

        // Nhấn Enter trong ô tên khách hàng
        private void txtTimKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiDanhSach();
            }
        }

        private void TaiDanhSach()
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                UiHelper.Warn("\"Từ ngày\" phải nhỏ hơn hoặc bằng \"Đến ngày\".");
                return;
            }

            try
            {
                var ds = _repo.TimHoaDon(txtTimMaHD.Text, txtTimKhachHang.Text, dtpTuNgay.Value, dtpDenNgay.Value);

                dgvDanhSachHoaDon.DataSource = ds;
                dgvDanhSachHoaDon.ClearSelection();

                lblTong.Text = "Số hóa đơn: " + ds.Count
                                + "  |  Tổng giảm giá: " + Money.Fmt(ds.Sum(x => x.GiamGia)) + " đ"
                                + "  |  Tổng doanh thu: " + Money.Fmt(ds.Sum(x => x.ThanhTien)) + " đ";
            }
            catch (Exception ex)
            {
                UiHelper.Error("Lỗi khi tìm hóa đơn: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DatLaiBoLoc();
            TaiDanhSach();
        }

        private HoaDonRow DongDangChon()
        {
            if (dgvDanhSachHoaDon.CurrentRow == null ||
                dgvDanhSachHoaDon.SelectedRows.Count == 0)
            {
                UiHelper.Warn("Hãy chọn một hóa đơn trong danh sách.");
                return null;
            }

            return dgvDanhSachHoaDon.SelectedRows[0].DataBoundItem as HoaDonRow;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            var r = DongDangChon();
            if (r == null) return;
            try
            {
                using (var f = new frmReportViewer(r.MaHD))
                {
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                UiHelper.Error("Không xem được chi tiết: " + ex.Message);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            var r = DongDangChon();
            if (r == null) return;

            try
            {
                using (var f = new frmReportViewer(r.MaHD, true))
                {
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                UiHelper.Error("Không in được hóa đơn: " + ex.Message);
            }
        }
    }
}
