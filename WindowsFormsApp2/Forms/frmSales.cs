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
    public partial class frmSales : Form
    {
        private readonly BanHangRepository _repo = new BanHangRepository();
        private readonly BindingList<GioHangItem> _gio = new BindingList<GioHangItem>();

        private NhanVienInfo _nv;
        private KhachHangGiamGia _kh;
        private decimal _tong, _giam, _thanhToan;
        private string _maHDVuaLuu;

        public frmSales()
        {
            InitializeComponent();

            // Cột của lưới được thiết kế sẵn trong Designer (thuộc tính này không chỉnh được trong Designer)
            dgvDanhSachSach.AutoGenerateColumns = false;
            dgvChiTietHoaDon.AutoGenerateColumns = false;

            Money.LiveFormat(txtTienKhachDua, (s, ev) => CapNhatTienThua());
        }

        //------------------------Sự kiện (gắn trong Designer, tab Events)---------------------
        private void btnTimSach_Click(object sender, EventArgs e)
        {
            TaiSach();
        }

        private void txtTimSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TaiSach();
            }
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            ThemSachDangChon();
        }

        private void dgvDanhSachSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) ThemSachDangChon();
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChonKhachHang();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan(false);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            InHoaDon();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            try
            {
                dgvChiTietHoaDon.DataSource = _gio;

                _nv = _repo.GetNhanVienByTaiKhoan(Session.TenDangNhap);

                txtNhanVien.Text = _nv != null ? _nv.HoTen : (Session.HoTen ?? Session.TenDangNhap);

                cboKhachHang.DataSource = _repo.GetKhachHangItems();
                cboKhachHang.DisplayMember = "Text";
                cboKhachHang.ValueMember = "Value";

                TaiSach();
                MoiHoaDon();
            }
            catch (Exception ex)
            {
                UiHelper.Error("Không tải được dữ liệu bán hàng: " + ex.Message);
            }
        }

        //------------------------Tải dữ liệu---------------------
        private void TaiSach()
        {
            dgvDanhSachSach.DataSource = _repo.TimSach(txtTimSach.Text);
            dgvDanhSachSach.ClearSelection();
        }

        private void MoiHoaDon()
        {
            _gio.Clear();
            _maHDVuaLuu = null;

            txtMaHD.Text = _repo.TaoMaHD();
            dtpNgayLap.Value = DateTime.Now;
            txtTienKhachDua.Text = "";

            if (cboKhachHang.Items.Count > 0) cboKhachHang.SelectedIndex = 0;

            ChonKhachHang();

            btnThanhToan.Enabled = true;
            btnQR.Enabled = true;
            btnInHoaDon.Enabled = false;
        }

        private void ChonKhachHang()
        {
            var item = cboKhachHang.SelectedItem as ComboItem;

            _kh = (item == null || string.IsNullOrEmpty(item.Value)) ? null : _repo.GetGiamGia(item.Value);

            txtHangThanhVien.Text = _kh == null ? "(Khách lẻ)" : (_kh.TenHang ?? "Chưa có hạng") + " (-" + _kh.PhanTramGiam.ToString("0.##") + "%)";

            CapNhatTien();
        }

        //-------------------------Tính tiền---------------------
        private void CapNhatTien()
        {
            _tong = _gio.Sum(g => g.ThanhTien);

            decimal phanTram = _kh == null ? 0m : _kh.PhanTramGiam;

            _giam = BanHangRepository.TinhGiamGia(_tong, phanTram);
            _thanhToan = _tong - _giam;

            txtTongTien.Text = Money.Fmt(_tong);
            txtTienGiam.Text = Money.Fmt(_giam);
            txtThanhToan.Text = Money.Fmt(_thanhToan);

            CapNhatTienThua();
        }

        private void CapNhatTienThua()
        {
            decimal dua = Money.Parse(txtTienKhachDua.Text);

            txtTienThua.Text = Money.Fmt(Math.Max(0m, dua - _thanhToan));
        }

        //-----------------------Giỏ Hàng----------------------
        private bool DaLuu()
        {
            if (_maHDVuaLuu == null) return false;

            UiHelper.Warn("Hóa đơn " + _maHDVuaLuu + " đã được lưu.\nBấm \"Làm mới\" để lập hóa đơn mới.");

            return true;
        }

        private void ThemSachDangChon()
        {
            if (DaLuu()) return;

            var sp = dgvDanhSachSach.CurrentRow == null ? null : dgvDanhSachSach.CurrentRow.DataBoundItem as SachBanRow;

            if (sp == null)
            {
                UiHelper.Warn("Hãy chọn một cuốn sách trong danh sách.");
                return;
            }

            ThemSach(sp, 1);
        }


        private void ThemSach(SachBanRow sp, int soLuong)
        {
            var dong = _gio.FirstOrDefault(g => g.MaSP == sp.MaSP);
            int moi = (dong == null ? 0 : dong.SoLuong) + soLuong;

            if (sp.SoLuongTon <= 0)
            {
                UiHelper.Warn("Sách \"" + sp.TenSP + "\" đã hết hàng.");
                return;
            }

            if (moi > sp.SoLuongTon)
            {
                UiHelper.Warn("Không đủ tồn kho cho \"" + sp.TenSP + "\".\n" +
                              "Còn lại: " + sp.SoLuongTon +
                              " - Trong giỏ: " + (dong == null ? 0 : dong.SoLuong));

                return;
            }

            if (dong == null)
            {
                _gio.Add(new GioHangItem
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.GiaBan,
                    SoLuong = soLuong,
                    Ton = sp.SoLuongTon
                });
            }
            else
            {
                dong.SoLuong = moi;
            }

            _gio.ResetBindings();
            CapNhatTien();
        }


        private GioHangItem DongGioDangChon()
        {
            return dgvChiTietHoaDon.CurrentRow == null ? null : dgvChiTietHoaDon.CurrentRow.DataBoundItem as GioHangItem;
        }


        private void btnCapNhatSoLuong_Click(object sender, EventArgs e)
        {
            if (DaLuu()) return;

            var g = DongGioDangChon();

            if (g == null)
            {
                UiHelper.Warn("Hãy chọn dòng sách trong chi tiết hóa đơn.");
                return;
            }

            // Đưa ô "Số lượng" của dòng đang chọn vào chế độ nhập: gõ số mới rồi nhấn Enter
            foreach (DataGridViewColumn c in dgvChiTietHoaDon.Columns)
            {
                if (c.DataPropertyName == "SoLuong")
                {
                    dgvChiTietHoaDon.CurrentCell = dgvChiTietHoaDon.CurrentRow.Cells[c.Index];
                    dgvChiTietHoaDon.BeginEdit(true);
                    return;
                }
            }
        }

        // Chỉ cho sửa cột Số lượng, và không cho sửa khi hóa đơn đã lưu
        private void dgvChiTietHoaDon_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = _maHDVuaLuu != null
                       || dgvChiTietHoaDon.Columns[e.ColumnIndex].DataPropertyName != "SoLuong";
        }

        // Kiểm tra số lượng vừa nhập so với tồn kho, rồi tính lại tiền
        private void dgvChiTietHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var g = e.RowIndex < 0 ? null : dgvChiTietHoaDon.Rows[e.RowIndex].DataBoundItem as GioHangItem;
            if (g == null) return;

            string loi = null;

            if (g.SoLuong <= 0)
            {
                g.SoLuong = 1;
                loi = "Số lượng phải lớn hơn 0. Muốn bỏ sách khỏi hóa đơn hãy bấm \"Xóa sách đã chọn\".";
            }
            else if (g.SoLuong > g.Ton)
            {
                loi = "Không đủ tồn kho. Chỉ còn " + g.Ton + " cuốn.";
                g.SoLuong = g.Ton;
            }

            // Làm mới sau khi lưới kết thúc chỉnh sửa để tránh lỗi gọi lồng nhau
            BeginInvoke(new Action(() =>
            {
                _gio.ResetBindings();
                CapNhatTien();
                if (loi != null) UiHelper.Warn(loi);
            }));
        }

        private void dgvChiTietHoaDon_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            UiHelper.Warn("Số lượng không hợp lệ. Hãy nhập số nguyên.");
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (DaLuu()) return;

            GioHangItem dong = DongGioDangChon();
            if (dong == null) return;

            if (!UiHelper.Confirm("Xóa sách \"" + dong.TenSP + "\" khỏi hóa đơn?"))
                return;

            _gio.Remove(dong);
            CapNhatTien();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (DaLuu()) return;
            if (_gio.Count == 0) return;

            if (!UiHelper.Confirm("Xóa toàn bộ sách trong hóa đơn?"))
                return;

            _gio.Clear();
            CapNhatTien();
        }


        //---------------------------Thanh toán--------------------------
        private void btnQR_Click(object sender, EventArgs e)
        {
            if (_maHDVuaLuu != null)
            {
                DaLuu();
                return;
            }

            if (_gio.Count == 0)
            {
                UiHelper.Warn("Chưa có sách trong hóa đơn.");
                return;
            }

            if (_thanhToan <= 0)
            {
                UiHelper.Warn("Số tiền thanh toán phải lớn hơn 0.");
                return;
            }

            using (var f = new frmQRPayment(txtMaHD.Text.Trim(), _thanhToan))
            {
                if (f.ShowDialog(this) != DialogResult.OK)
                    return;
            }

            if (!UiHelper.Confirm("Bạn đã kiểm tra tài khoản ngân hàng và xác nhận đã nhận đủ "
                                 + Money.Fmt(_thanhToan) + " đ chưa?\n\nChỉ chọn có khi tiền đã vào tài khoản."))
                return;

            txtTienKhachDua.Text = Money.Fmt(_thanhToan);
            ThanhToan(true);
        }


        private void ThanhToan(bool chuyenKhoan)
        {
            if (DaLuu()) return;

            if (_gio.Count == 0)
            {
                UiHelper.Warn("Chưa có sách trong hóa đơn.");
                return;
            }

            if (!chuyenKhoan && Money.Parse(txtTienKhachDua.Text) < _thanhToan)
            {
                UiHelper.Warn("Tiền khách đưa chưa đủ. Cần thanh toán: " + Money.Fmt(_thanhToan) + " đ");

                txtTienKhachDua.Focus();
                return;
            }

            if (!chuyenKhoan && !UiHelper.Confirm("Lưu hóa đơn " + txtMaHD.Text +
                "?\nKhách thanh toán: " + Money.Fmt(_thanhToan) + " đ"))
            {
                return;
            }

            try
            {
                KetQuaBanHang kq = _repo.LapHoaDon(txtMaHD.Text.Trim(), dtpNgayLap.Value, _nv == null ? null : _nv.MaNV, _kh == null ? null : _kh.MaKH, _gio);

                _maHDVuaLuu = kq.MaHD;
                txtMaHD.Text = kq.MaHD;

                btnThanhToan.Enabled = false;
                btnQR.Enabled = false;
                btnInHoaDon.Enabled = true;

                string msg = "Lưu hóa đơn thành công!\n\nMã hóa đơn: " + kq.MaHD +
                             "\nTổng tiền: " + Money.Fmt(kq.TongTien) + " đ" +
                             "\nGiảm giá: " + Money.Fmt(kq.GiamGia) + " đ" +
                             "\nThanh toán: " + Money.Fmt(kq.ThanhTien) + " đ";

                if (kq.DiemCong > 0) msg += "\nĐiểm tích lũy: +" + kq.DiemCong;

                if (kq.HangMoi != null) msg += "\nChúc mừng! Khách được nâng lên hạng " + kq.HangMoi + ".";

                UiHelper.Info(msg);

                TaiSach();
                ChonKhachHang();

                if (UiHelper.Confirm("In hóa đơn ngay bây giờ?"))
                    InHoaDon();
            }
            catch (NghiepVuException ex)
            {
                UiHelper.Warn(ex.Message);
                TaiSach();
            }
            catch (Exception ex)
            {
                UiHelper.Error("Không lưu được hóa đơn (đã hoàn tác, dữ liệu không bị thay đổi):\n" + ex.Message);
            }
        }


        private void InHoaDon()
        {
            if (_maHDVuaLuu == null)
            {
                UiHelper.Warn("Hãy thanh toán (lưu háo đơn) trước khi in.");
                return;
            }

            using (var f = new frmReportViewer(_maHDVuaLuu))
            {
                f.ShowDialog(this);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (_maHDVuaLuu == null && _gio.Count > 0 && !UiHelper.Confirm("Hóa đơn chưa lưu sẽ bị bỏ. Tiếp tục?"))
            {
                return;
            }

            MoiHoaDon();
            TaiSach();
        }
    }
}

