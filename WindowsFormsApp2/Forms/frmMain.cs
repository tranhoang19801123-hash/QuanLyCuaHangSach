using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    /// <summary>
    /// Khung chính: header (thông tin người đăng nhập), menu điều hướng bên trái,
    /// vùng nội dung (Dashboard hoặc form con được nhúng vào pnlContent).
    /// </summary>
    public partial class frmMain : Form
    {
        private Form _formCon;                                   // form đang nhúng trong pnlContent
        private readonly List<Guna2Button> _nutMenu;
        private readonly Dictionary<Guna2Button, string> _maChucNang;

        public frmMain()
        {
            InitializeComponent();
            dgvSapHet.AutoGenerateColumns = false;

            _nutMenu = new List<Guna2Button>
            {
                btnTrangChu, btnSach, btnTheLoai, btnKhachHang, btnNhanVien, btnNCC,
                btnBanHang, btnNhapHang, btnHoaDon, btnBaoCao, btnNguoiDung, btnPhanQuyen, btnDoiMK
            };

            // Nút menu -> mã chức năng (dùng để ẩn/hiện theo phân quyền)
            _maChucNang = new Dictionary<Guna2Button, string>
            {
                { btnSach, ChucNangCode.Sach },           { btnTheLoai, ChucNangCode.TheLoai },
                { btnKhachHang, ChucNangCode.KhachHang }, { btnNhanVien, ChucNangCode.NhanVien },
                { btnNCC, ChucNangCode.NhaCungCap },      { btnBanHang, ChucNangCode.BanHang },
                { btnNhapHang, ChucNangCode.NhapHang },   { btnHoaDon, ChucNangCode.HoaDon },
                { btnBaoCao, ChucNangCode.BaoCao },       { btnNguoiDung, ChucNangCode.NguoiDung },
                { btnPhanQuyen, ChucNangCode.PhanQuyen }
            };
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                LoadHeader();
                PhanQuyenMenu();
                HienDashboard();
            }
            catch (Exception ex) { UiHelper.Error("Lỗi khi khởi tạo giao diện chính: " + ex.Message); }
        }

        // ---------- Header ----------
        private void LoadHeader()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                var u = db.NguoiDungs.FirstOrDefault(x => x.TenDangNhap == Session.TenDangNhap);
                string ten = (u != null && !string.IsNullOrWhiteSpace(u.HoTen)) ? u.HoTen : Session.TenDangNhap;
                string quyen = (u != null && u.PhanQuyen != null) ? u.PhanQuyen.TenQuyen : "Chưa phân quyền";
                lblUser.Text = "Xin chào, " + ten + "  (" + quyen + ")";
            }
        }

        // ---------- Phân quyền (RBAC): ẩn/hiện menu theo bảng PhanQuyen_ChucNang ----------
        private HashSet<string> LayQuyenHienTai()
        {
            // Quyền đã nạp vào Session khi đăng nhập; không có thì không được thấy gì
            return Session.Quyen ?? new HashSet<string>();
        }

        private void PhanQuyenMenu()
        {
            var quyen = LayQuyenHienTai();
            foreach (var kv in _maChucNang)
                kv.Key.Visible = quyen.Contains(kv.Value);

            // Ẩn tiêu đề nhóm nếu cả nhóm bị ẩn
            lblNhomDanhMuc.Visible = btnSach.Visible || btnTheLoai.Visible || btnKhachHang.Visible
                                     || btnNhanVien.Visible || btnNCC.Visible;
            lblNhomNghiepVu.Visible = btnBanHang.Visible || btnNhapHang.Visible || btnHoaDon.Visible || btnBaoCao.Visible;
            lblNhomHeThong.Visible = btnNguoiDung.Visible || btnPhanQuyen.Visible || btnDoiMK.Visible;
        }

        // ---------- Dashboard ----------
        private void HienDashboard()
        {
            DongFormCon();
            pnlDashboard.Visible = true;
            SetActive(btnTrangChu);
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            using (var db = ConnectionHelper.CreateContext())
            {
                lblTongSach.Text = db.SanPhams.Count().ToString("N0");
                lblTongKhach.Text = db.KhachHangs.Count().ToString("N0");

                DateTime homNay = DateTime.Today;
                DateTime ngayMai = homNay.AddDays(1);
                var hoaDonHomNay = db.HoaDons.Where(h => h.NgayLap >= homNay && h.NgayLap < ngayMai);
                lblHoaDonHomNay.Text = hoaDonHomNay.Count().ToString("N0");
                decimal doanhThu = hoaDonHomNay.Sum(h => h.ThanhTien) ?? 0m;
                lblDoanhThuHomNay.Text = doanhThu.ToString("N0") + " đ";
            }
            dgvSapHet.DataSource = new SachRepository().GetSapHet(10, 10);
            dgvSapHet.ClearSelection();
        }

        // ---------- Nhúng form con ----------
        private void DongFormCon()
        {
            if (_formCon != null)
            {
                pnlContent.Controls.Remove(_formCon);
                _formCon.Dispose();
                _formCon = null;
            }
        }

        private void MoForm(Form f, Guna2Button nut)
        {
            DongFormCon();
            pnlDashboard.Visible = false;
            _formCon = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(f);
            f.Show();
            f.BringToFront();
            SetActive(nut);
        }

        private void SetActive(Guna2Button nut)
        {
            foreach (var b in _nutMenu)
                b.FillColor = (b == nut) ? UiTheme.Primary : UiTheme.Side;
        }

        // ---------- Sự kiện menu ----------
        private void btnTrangChu_Click(object sender, EventArgs e) { HienDashboard(); }
        private void btnSach_Click(object sender, EventArgs e) { MoForm(new frmProduct(), btnSach); }
        private void btnTheLoai_Click(object sender, EventArgs e) { MoForm(new frmCategory(), btnTheLoai); }
        private void btnKhachHang_Click(object sender, EventArgs e) { MoForm(new frmCustomer(), btnKhachHang); }
        private void btnNhanVien_Click(object sender, EventArgs e) { MoForm(new frmEmployee(), btnNhanVien); }
        private void btnNCC_Click(object sender, EventArgs e) { MoForm(new frmSupplier(), btnNCC); }

        private void btnBanHang_Click(object sender, EventArgs e) { MoForm(new frmSales(), btnBanHang); }
        private void btnNhapHang_Click(object sender, EventArgs e) { MoForm(new frmImport(), btnNhapHang); }
        private void btnHoaDon_Click(object sender, EventArgs e) { MoForm(new frmInVoiceList(), btnHoaDon); }
        private void btnBaoCao_Click(object sender, EventArgs e) { MoForm(new frmChartDashboard(), btnBaoCao); }

        private void btnNguoiDung_Click(object sender, EventArgs e) { MoForm(new frmUserManagement(), btnNguoiDung); }
        private void btnPhanQuyen_Click(object sender, EventArgs e) { MoForm(new frmRoleManagement(), btnPhanQuyen); }
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            using (var f = new frmChangePassword())
                f.ShowDialog(this);
        }

        private void btnCauHinhNganHang_Click(object sender, EventArgs e)
        {
            using (var f = new frmBankConfig())
            {
                f.ShowDialog(this);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (!UiHelper.Confirm("Bạn có chắc muốn đăng xuất?")) return;
            Session.Clear();
            Application.Restart();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();   // đảm bảo tắt hết tiến trình khi đóng form chính
        }
    }
}
