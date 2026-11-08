using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp2.Forms
{
    /// <summary>
    /// Xem chi tiết và in hóa đơn bán hàng.
    /// PrintDocument (printDocument) và PrintPreviewDialog (printPreviewDialog) được đặt trong Designer.
    /// </summary>
    public partial class frmReportViewer : Form
    {
        private readonly BanHangRepository _repository = new BanHangRepository();
        private readonly string _maHD;
        private readonly bool _inNgay;

        private HoaDonInfo _hoaDon;
        private int _viTriDongIn;
        private bool _choIn;

        // Constructor mặc định để Designer mở được Form
        public frmReportViewer() : this(null, false)
        {
        }

        // Xem chi tiết hóa đơn
        public frmReportViewer(string maHD) : this(maHD, false)
        {
        }

        // inNgay = true: mở form xong là hiện luôn bản xem trước khi in
        public frmReportViewer(string maHD, bool inNgay)
        {
            InitializeComponent();

            _maHD = maHD;
            _inNgay = inNgay;
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_maHD))
                {
                    UiHelper.Warn("Mã hóa đơn không hợp lệ!");
                    Close();
                    return;
                }

                LoadHoaDon();

                _choIn = _inNgay && _hoaDon != null;
            }
            catch (Exception ex)
            {
                UiHelper.Error("Không thể tải hóa đơn: " + ex.Message);
            }
        }

        // Lấy hóa đơn từ Repository và hiển thị lên form
        private void LoadHoaDon()
        {
            _hoaDon = _repository.GetHoaDon(_maHD);

            if (_hoaDon == null)
            {
                UiHelper.Warn("Không tìm thấy hóa đơn!");
                Close();
                return;
            }

            HienThiBaoCao();
        }
        

        private void HienThiBaoCao()
        {
            rvHoaDon.ProcessingMode = ProcessingMode.Local;

            rvHoaDon.LocalReport.DataSources.Clear();

            rvHoaDon.LocalReport.DataSources.Add(
                new ReportDataSource(
                    "dsChiTietHoaDon",
                    _hoaDon.ChiTiet
                )
            );

            ReportParameter[] parameters =
            {
                new ReportParameter("MaHD", _hoaDon.MaHD ?? ""),
                new ReportParameter("NgayLap", _hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm")),
                new ReportParameter("TenKH", _hoaDon.TenKH ?? ""),
                new ReportParameter("TenNV", _hoaDon.TenNV ?? ""),
                new ReportParameter("TongTien", Money.Fmt(_hoaDon.TongTien) + " VNĐ"),
                new ReportParameter("GiamGia", Money.Fmt(_hoaDon.GiamGia) + " VNĐ"),
                new ReportParameter("ThanhTien", Money.Fmt(_hoaDon.ThanhTien) + " VNĐ")
            };

            rvHoaDon.LocalReport.SetParameters(parameters);

            rvHoaDon.RefreshReport();
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        // In hóa đơn: hiện bản xem trước (printPreviewDialog.Document = printDocument, đặt trong Designer)
        private void btnIn_Click_1(object sender, EventArgs e)
        {
            if (_hoaDon == null)
            {
                UiHelper.Warn("Không có dữ liệu hóa đơn để in!");
                return;
            }

            rvHoaDon.PrintDialog();
        }

        // Xử lý nội dung hóa đơn khi in
        private void printDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Font fontTieuDe = new Font("Arial", 16, FontStyle.Bold))
            using (Font fontDam = new Font("Arial", 9, FontStyle.Bold))
            using (Font fontThuong = new Font("Arial", 10))
            using (Font fontNho = new Font("Arial", 8))
            using (Pen pen = new Pen(Color.Black, 1))
            using (StringFormat center = new StringFormat())
            using (StringFormat right = new StringFormat())
            {
                center.Alignment = StringAlignment.Center;
                center.LineAlignment = StringAlignment.Center;

                right.Alignment = StringAlignment.Far;
                right.LineAlignment = StringAlignment.Center;

                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float width = e.MarginBounds.Width;

                // Tiêu đề hóa đơn
                g.DrawString(
                    "HÓA ĐƠN BÁN HÀNG",
                    fontTieuDe,
                    Brushes.Black,
                    new RectangleF(x, y, width, 35),
                    center
                );

                y += 45;

                g.DrawString(
                    "CỬA HÀNG SÁCH",
                    fontDam,
                    Brushes.Black,
                    x,
                    y
                );

                y += 25;

                g.DrawString(
                    "Mã hóa đơn: " + _hoaDon.MaHD,
                    fontThuong,
                    Brushes.Black,
                    x,
                    y
                );

                y += 22;

                g.DrawString(
                    "Ngày lập: " + _hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm"),
                    fontThuong,
                    Brushes.Black,
                    x,
                    y
                );

                y += 22;

                g.DrawString(
                    "Khách hàng: " + _hoaDon.TenKH,
                    fontThuong,
                    Brushes.Black,
                    x,
                    y
                );

                y += 22;

                g.DrawString(
                    "Nhân viên: " + _hoaDon.TenNV,
                    fontThuong,
                    Brushes.Black,
                    x,
                    y
                );

                y += 30;

                g.DrawLine(pen, x, y, x + width, y);

                y += 10;

                // Chiều rộng từng cột
                float[] tiLeCot =
                {
                    0.07f,
                    0.13f,
                    0.30f,
                    0.09f,
                    0.19f,
                    0.22f
                };

                float[] cot = new float[7];

                cot[0] = x;

                for (int i = 0; i < tiLeCot.Length; i++)
                {
                    cot[i + 1] = cot[i] + width * tiLeCot[i];
                }

                string[] tieuDeCot =
                {
                    "STT",
                    "Mã sách",
                    "Tên sách",
                    "SL",
                    "Đơn giá",
                    "Thành tiền"
                };

                // In tiêu đề bảng
                for (int i = 0; i < tieuDeCot.Length; i++)
                {
                    RectangleF rect = new RectangleF(
                        cot[i] + 2,
                        y,
                        cot[i + 1] - cot[i] - 4,
                        25
                    );

                    g.DrawString(
                        tieuDeCot[i],
                        fontDam,
                        Brushes.Black,
                        rect,
                        center
                    );
                }

                y += 28;

                g.DrawLine(pen, x, y, x + width, y);

                y += 8;

                // In từng dòng chi tiết hóa đơn
                while (_viTriDongIn < _hoaDon.ChiTiet.Count)
                {
                    // Chừa khoảng trống cho phần tổng kết ở cuối trang
                    if (y + 25 > e.MarginBounds.Bottom - 140)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    var ct = _hoaDon.ChiTiet[_viTriDongIn];

                    string tenSach = ct.TenSP ?? "";

                    if (tenSach.Length > 28)
                    {
                        tenSach = tenSach.Substring(0, 28) + "...";
                    }

                    string[] giaTri =
                    {
                        ct.STT.ToString(),
                        ct.MaSP ?? "",
                        tenSach,
                        ct.SoLuong.ToString(),
                        Money.Fmt(ct.DonGia),
                        Money.Fmt(ct.ThanhTien)
                    };

                    // In nội dung từng cột
                    for (int i = 0; i < giaTri.Length; i++)
                    {
                        RectangleF rect = new RectangleF(
                            cot[i] + 2,
                            y,
                            cot[i + 1] - cot[i] - 4,
                            22
                        );

                        if (i == 0 || i == 3)
                        {
                            g.DrawString(
                                giaTri[i],
                                fontNho,
                                Brushes.Black,
                                rect,
                                center
                            );
                        }
                        else if (i >= 4)
                        {
                            g.DrawString(
                                giaTri[i],
                                fontNho,
                                Brushes.Black,
                                rect,
                                right
                            );
                        }
                        else
                        {
                            g.DrawString(
                                giaTri[i],
                                fontNho,
                                Brushes.Black,
                                rect
                            );
                        }
                    }

                    y += 25;

                    _viTriDongIn++;
                }

                // Đường kẻ kết thúc bảng
                y += 5;

                g.DrawLine(pen, x, y, x + width, y);

                y += 20;

                // Phần tổng kết hóa đơn
                g.DrawString(
                    "Tổng tiền: " + Money.Fmt(_hoaDon.TongTien) + " VNĐ",
                    fontDam,
                    Brushes.Black,
                    x,
                    y
                );

                y += 25;

                g.DrawString(
                    "Tiền giảm giá: " + Money.Fmt(_hoaDon.GiamGia) + " VNĐ",
                    fontThuong,
                    Brushes.Black,
                    x,
                    y
                );

                y += 25;

                g.DrawString(
                    "THÀNH TIỀN: " + Money.Fmt(_hoaDon.ThanhTien) + " VNĐ",
                    fontDam,
                    Brushes.Black,
                    x,
                    y
                );

                y += 40;

                // Lời cảm ơn
                g.DrawString(
                    "Cảm ơn quý khách và hẹn gặp lại!",
                    fontThuong,
                    Brushes.Black,
                    new RectangleF(x, y, width, 30),
                    center
                );

                e.HasMorePages = false;
            }
        }

        private void rvHoaDon_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            if (e.Exception != null)
            {
                UiHelper.Error("Lỗi hiển thị RDLC: " + e.Exception.Message);
            }
        }
    }
}
