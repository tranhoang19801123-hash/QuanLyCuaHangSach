using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    public partial class frmChartDashboard : Form
    {
        private ThongKeRepository _repo = new ThongKeRepository();

        public frmChartDashboard()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            TenSach.DataPropertyName = "TenSach";
            SoLuongBan.DataPropertyName = "SoLuongBan";
        }

        private QuanLyCuaHangSach.QLSachDataContext CreateDb()
        {
            return ConnectionHelper.CreateContext();
        }

        private void frmChartDashboard_Load(object sender, EventArgs e)
        {
            SetupDataGridView();

            cboNam.SelectedIndexChanged -= cboNam_SelectedIndexChanged;
            cboThang.SelectedIndexChanged -= cboThang_SelectedIndexChanged;

            if (cboThang.Items.Count == 0)
            {
                for (int i = 1; i <= 12; i++)
                    cboThang.Items.Add(i);
            }

            LoadDanhSachNamVaoComboBox();

            int namChon = DateTime.Now.Year;
            int thangChon = DateTime.Now.Month;
            try
            {
                using (var db = CreateDb())
                {
                    DateTime? moiNhat = db.HoaDons.Max(hd => hd.NgayLap);
                    if (moiNhat.HasValue)
                    {
                        namChon = moiNhat.Value.Year;
                        thangChon = moiNhat.Value.Month;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đọc được hóa đơn mới nhất: " + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!cboNam.Items.Contains(namChon))
                cboNam.Items.Add(namChon);

            cboNam.SelectedItem = namChon;
            cboThang.SelectedItem = thangChon;

            cboNam.SelectedIndexChanged += cboNam_SelectedIndexChanged;
            cboThang.SelectedIndexChanged += cboThang_SelectedIndexChanged;

            LoadDuLieuDashboard(thangChon, namChon);
        }

        private void LoadDanhSachNamVaoComboBox()
        {
            try
            {
                cboNam.Items.Clear();
                using (var db = CreateDb())
                {
                    var danhSachNam = db.HoaDons
                        .Where(hd => hd.NgayLap.HasValue)
                        .Select(hd => hd.NgayLap.Value.Year)
                        .Distinct()
                        .OrderByDescending(y => y)
                        .ToList();

                    if (danhSachNam.Count == 0)
                    {
                        cboNam.Items.Add(DateTime.Now.Year);
                    }
                    else
                    {
                        foreach (var nam in danhSachNam)
                            cboNam.Items.Add(nam);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách năm: " + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cboNam.Items.Count == 0)
                    cboNam.Items.Add(DateTime.Now.Year);
            }
        }

        private void LoadDuLieuDashboard(int thang, int nam)
        {
            LoadBieuDoDoanhThu(nam);
            LoadTop5Sach(thang, nam);
            LoadBieuDoTheLoai(nam);
            LoadDataGridViewData(thang, nam);
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNam.SelectedItem != null && cboThang.SelectedItem != null)
            {
                int nam = Convert.ToInt32(cboNam.SelectedItem);
                int thang = Convert.ToInt32(cboThang.SelectedItem);
                LoadDuLieuDashboard(thang, nam);
            }
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNam.SelectedItem != null && cboThang.SelectedItem != null)
            {
                int nam = Convert.ToInt32(cboNam.SelectedItem);
                int thang = Convert.ToInt32(cboThang.SelectedItem);
                LoadTop5Sach(thang, nam);
                LoadDataGridViewData(thang, nam);
            }
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = Color.White;
        }

        private void LoadBieuDoDoanhThu(int nam)
        {
            try
            {
                var doanhThuDict = _repo.GetDoanhThu12Thang(nam);

                chart1.Series.Clear();
                var series = chart1.Series.Add("Doanh Thu");
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 3;
                series.MarkerStyle = MarkerStyle.Circle;
                series.MarkerSize = 7;

                foreach (var item in doanhThuDict)
                {
                    series.Points.AddXY("T " + item.Key, item.Value);
                }

                if (chart1.ChartAreas.Count > 0)
                {
                    var area = chart1.ChartAreas[0];
                    area.AxisY.LabelStyle.Format = "N0";
                    area.AxisY.Minimum = 0;
                    area.AxisX.Interval = 1;
                    area.AxisX.MajorGrid.Enabled = false;
                    area.AxisX.LabelStyle.IsStaggered = false;
                    area.RecalculateAxesScale();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải biểu đồ doanh thu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTop5Sach(int thang, int nam)
        {
            try
            {
                var top5 = _repo.GetTop5SachTheoThang(thang, nam);

                chart2.Titles.Clear();
                if (top5.Count == 0)
                    chart2.Titles.Add("Không có dữ liệu bán hàng trong tháng này");

                chart2.Series.Clear();
                var series = chart2.Series.Add("Số lượng bán");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.XValueType = ChartValueType.String;

                foreach (var item in top5)
                {
                    series.Points.AddXY(item.TenSach, item.SoLuongBan);
                }

                if (chart2.ChartAreas.Count > 0)
                {
                    var area = chart2.ChartAreas[0];
                    area.AxisX.Interval = 1;
                    area.AxisX.MajorGrid.Enabled = false;
                    area.AxisX.LabelStyle.IsStaggered = false;
                    area.AxisY.Minimum = 0;
                    area.RecalculateAxesScale();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải biểu đồ Top 5: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBieuDoTheLoai(int nam)
        {
            try
            {
                var dataTheLoai = _repo.GetDoanhThuTheoTheLoai(nam);

                chart3.Titles.Clear();
                chart3.Titles.Add("Doanh thu theo thể loại (đã phân bổ giảm giá) - Năm " + nam);

                chart3.Series.Clear();
                var series = chart3.Series.Add("TheLoai");
                series.ChartType = SeriesChartType.Doughnut;
                series["PieLabelStyle"] = "Disabled";
                series.IsValueShownAsLabel = false;

                foreach (var item in dataTheLoai)
                {
                    int idx = series.Points.AddXY(item.TenTheLoai, item.DoanhThu);
                    series.Points[idx].LegendText = item.TenTheLoai;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải biểu đồ thể loại: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGridViewData(int thang, int nam)
        {
            try
            {
                var data = _repo.GetTop5SachTheoThang(thang, nam);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;

                if (dataGridView1.Columns["TenSach"] != null)
                    dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
                if (dataGridView1.Columns["SoLuongBan"] != null)
                    dataGridView1.Columns["SoLuongBan"].HeaderText = "Số Lượng Bán";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu lưới: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            frmStatisticalDetail frm = new frmStatisticalDetail();
            frm.ShowDialog();
        }
    }
}