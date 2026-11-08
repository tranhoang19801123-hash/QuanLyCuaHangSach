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
    /// <summary>Lập phiếu nhập sách từ nhà cùng cấp; khi lưu sẽ cộng tồn kho (TransactionScope)</summary>
    public partial class frmImport : Form
    {
        private readonly NhapHangRepository _repo = new NhapHangRepository();
        private readonly BindingList<NhapItem> _ds = new BindingList<NhapItem>();
        private List<SachNhapRow> _sach = new List<SachNhapRow>();
        private NhanVienInfo _nv;
        private bool _dangNap; //true khi đang nạp dữ liệu -> bỏ qua sự kiện đổi lựa chọn 

        public frmImport()
        {
            InitializeComponent();
            // Cột của lưới được thiết kế sẵn trong Designer (thuộc tính này không chỉnh được trong Designer)
            dgvChiTietPhieuNhap.AutoGenerateColumns = false;

            Money.LiveFormat(txtGiaNhap, (s,ev) => TinhThanhTien());
        }

        //------------------------Sự kiện (gắn trong Designer, tab Events)---------------------
        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            Xoa0NhapSach();
        }


        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            try
            {
                dgvChiTietPhieuNhap.DataSource = _ds;

                _nv = new BanHangRepository().GetNhanVienByTaiKhoan(Session.TenDangNhap);

                txtNhanVien.Text = _nv != null ? _nv.HoTen : (Session.HoTen ?? Session.TenDangNhap);

                _dangNap = true;

                cboNhaCungCap.DataSource = _repo.GetNhaCungCapItems();
                cboNhaCungCap.DisplayMember = "Text";
                cboNhaCungCap.ValueMember = "Value";

                NapSach();

                _dangNap = false;

                MoiPhieu();

                if (_nv == null)
                {
                    UiHelper.Warn("Tài khoản \"" + Session.TenDangNhap + "\" chưa được gắn với nhân viên nào .\n" +
                        "vào Quản lý nhân viên để gán tài khoản cho một nhân viên, " +
                        "nếu không sẽ không lưu được phiếu nhập.");
                }
            }
            catch (Exception ex)
            {
                _dangNap = false;
                UiHelper.Error("Không tải được dữ liệu nhập hàng: " + ex.Message);
            }
        }
        private void NapSach()
        {
            _sach = _repo.GetSach();

            cboSanPham.DataSource = _sach;
            cboSanPham.DisplayMember = "Text";
            cboSanPham.ValueMember = "MaSP";
        }

        private void MoiPhieu()
        {
            _ds.Clear();

            txtMaPN.Text = _repo.TaoMaPN();
            dtpNgayNhap.Value = DateTime.Now;

            if (cboNhaCungCap.Items.Count > 0)
                cboNhaCungCap.SelectedIndex = 0;

            Xoa0NhapSach();
            CapNhapTong();
        }

        //-------------------------Ô nhập một dòng sách-------------------
        private void Xoa0NhapSach()
        {
            numSoLuong.Value = 1;

            if (cboSanPham.Items.Count > 0)
            {
                cboSanPham.SelectedIndex = 0;
                DatGiaMacDinh();
            }
            else
            {
                txtGiaNhap.Text = "";
            }
            TinhThanhTien();
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;

            DatGiaMacDinh();
        }

        private void DatGiaMacDinh()
        {
            var sp = cboSanPham.SelectedItem as SachNhapRow;
            txtGiaNhap.Text = (sp == null || sp.GiaNhap <= 0) ? "" : Money.Fmt(sp.GiaNhap);

            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            txtThanhTien.Text = Money.Fmt(Money.Parse(txtGiaNhap.Text) * numSoLuong.Value);
        }

        //----------------------------Thêm / sửa / xóa dòng-------------------------
        private bool LayDuLieuDong(out SachNhapRow sp, out int soLuong, out decimal gia)
        {
            sp = cboSanPham.SelectedItem as SachNhapRow;
            soLuong = (int)numSoLuong.Value;
            gia = Money.Parse(txtGiaNhap.Text);

            if (sp == null)
            {
                UiHelper.Warn("Hãy chọn sách cần nhập.");
                return false;
            }

            if (gia <= 0)
            {
                UiHelper.Warn("Giá chọn sách cần nhập.");
                return false;
            }

            return true;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            SachNhapRow sp;
            int sl;
            decimal gia;

            if (!LayDuLieuDong(out sp, out sl, out gia)) return;

            var dong = _ds.FirstOrDefault(x => x.MaSP == sp.MaSP);

            if (dong != null)
            {
                dong.SoLuong += sl;
                dong.GiaNhap = gia;
            }
            else
            {
                _ds.Add(new NhapItem
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    SoLuong = sl,
                    GiaNhap = gia
                });
            }

            _ds.ResetBindings();
            CapNhapTong();
        }

        private NhapItem DongDangChon()
        {
            var d = dgvChiTietPhieuNhap.CurrentRow == null ? null : dgvChiTietPhieuNhap.CurrentRow.DataBoundItem as NhapItem;

            if (d == null)
                UiHelper.Warn("Hãy chọn một dòng trong chi tiết phiếu nhập.");

            return d;
        }

        private void dgvChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var d = dgvChiTietPhieuNhap.Rows[e.RowIndex].DataBoundItem as NhapItem;

            if (d == null) return;

            _dangNap = true;
            try
            {
                cboSanPham.SelectedValue = d.MaSP;
            }
            finally
            {
                _dangNap = false;
            }

            UiHelper.SetNum(numSoLuong, d.SoLuong);
            txtGiaNhap.Text = Money.Fmt(d.GiaNhap);

            TinhThanhTien();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            var d = DongDangChon();
            if (d == null) return;

            SachNhapRow sp;
            int sl;
            decimal gia;

            if (!LayDuLieuDong(out sp, out sl, out gia)) return;

            if (sp.MaSP != d.MaSP)
            {
                UiHelper.Warn("Đang chọn sách khác dòng cần sửa " + "Hãy bấm vào dòng cần sửa, đổi số lượng/ giá rồi bấm sửa.");
                return;
            }

            d.SoLuong = sl;
            d.GiaNhap = gia;

            _ds.ResetBindings();
            CapNhapTong();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            var d = DongDangChon();
            if (d == null) return;

            _ds.Remove(d);
            CapNhapTong();
        }

        private void CapNhapTong()
        {
            txtTongTien.Text = Money.Fmt(_ds.Sum(x => x.ThanhTien));
        }

        //-------------------------Lưu phiếu nhập-------------------
        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            var ncc = cboNhaCungCap.SelectedItem as ComboItem;
            if (ncc == null || string.IsNullOrEmpty(ncc.Value))
            {
                UiHelper.Warn("Vui lòng chọn nhà cung cấp.");
                return;
            }

            if (_ds.Count == 0)
            {
                UiHelper.Warn("Phiếu nhập chưa có sách nào.");
                return;
            }

            if (_nv == null)
            {
                UiHelper.Warn("Tài khoản chưa được gắn với nhân viên nên không thể lưu phiếu nhập.\n" +
                    "Hãy gán tài khoản cho một nhân viên tỏng màn hình Quản lý nhân viên.");
                return;
            }

            var giaBan = _sach.ToDictionary(x => x.MaSP, x => x.GiaBan);

            var lo = _ds
                .Where(x => giaBan.ContainsKey(x.MaSP)
                         && giaBan[x.MaSP] > 0
                         && x.GiaNhap > giaBan[x.MaSP])
                .Select(x => x.TenSP)
                .ToList();

            if (lo.Count > 0 && !UiHelper.Confirm("Giá nhập cao hơn giá bán hiện tại của:\n- " +
                                                 string.Join("\n- ", lo) +
                                                 "\n\nVẫn lưu phiếu nhập?"))
            {
                return;
            }

            if (!UiHelper.Confirm(
                "Lưu phiếu nhập " + txtMaPN.Text +
                " với tổng tiền " + txtTongTien.Text + "đ?"))
            {
                return;
            }

            try
            {
                string ma = _repo.LapPhieuNhap(txtMaPN.Text.Trim(), dtpNgayNhap.Value, _nv.MaNV, ncc.Value, _ds);
                UiHelper.Info("Đã lưu phiếu nhập " + ma + ".\nTồn kho của các sách trong phiếu đã được cộng thêm.");

                _dangNap = true;
                try
                {
                    NapSach();
                }
                finally
                {
                    _dangNap = false;
                }

                MoiPhieu();
            }
            catch (NghiepVuException ex)
            {
                UiHelper.Warn(ex.Message);
            }
            catch (Exception ex)
            {
                UiHelper.Error("Không lưu được phiếu nhập (đã hoàn tác, dữ liệu không bị thay đổi):\n" + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (_ds.Count > 0 && !UiHelper.Confirm("Phiếu nhập chưa lưu sẽ bị bỏ. Tiếp tục?"))
            {
                return;
            }

            MoiPhieu();
        }
    }
}
