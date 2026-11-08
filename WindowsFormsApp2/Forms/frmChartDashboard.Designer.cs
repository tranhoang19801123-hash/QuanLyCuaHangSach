namespace WindowsFormsApp2.Forms
{
    partial class frmChartDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblCharts = new System.Windows.Forms.TableLayoutPanel();
            this.cardChart1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChart1 = new System.Windows.Forms.Label();
            this.cardChart2 = new Guna.UI2.WinForms.Guna2Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChart2 = new System.Windows.Forms.Label();
            this.cardChart3 = new Guna.UI2.WinForms.Guna2Panel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChart3 = new System.Windows.Forms.Label();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTop5 = new System.Windows.Forms.Label();
            this.spacerB = new Guna.UI2.WinForms.Guna2Panel();
            this.spacerT = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXemChiTiet = new Guna.UI2.WinForms.Guna2Button();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCharts.SuspendLayout();
            this.cardChart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.cardChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.cardChart3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCharts
            // 
            this.tblCharts.BackColor = System.Drawing.Color.Transparent;
            this.tblCharts.ColumnCount = 3;
            this.tblCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tblCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tblCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tblCharts.Controls.Add(this.cardChart1, 0, 0);
            this.tblCharts.Controls.Add(this.cardChart2, 1, 0);
            this.tblCharts.Controls.Add(this.cardChart3, 2, 0);
            this.tblCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCharts.Location = new System.Drawing.Point(12, 84);
            this.tblCharts.Name = "tblCharts";
            this.tblCharts.RowCount = 1;
            this.tblCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCharts.Size = new System.Drawing.Size(1256, 422);
            this.tblCharts.TabIndex = 0;
            // 
            // cardChart1
            // 
            this.cardChart1.BackColor = System.Drawing.Color.Transparent;
            this.cardChart1.BorderRadius = 10;
            this.cardChart1.Controls.Add(this.chart1);
            this.cardChart1.Controls.Add(this.lblChart1);
            this.cardChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardChart1.Location = new System.Drawing.Point(5, 0);
            this.cardChart1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cardChart1.Name = "cardChart1";
            this.cardChart1.Padding = new System.Windows.Forms.Padding(10);
            this.cardChart1.Size = new System.Drawing.Size(467, 422);
            this.cardChart1.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(10, 40);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(447, 372);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lblChart1
            // 
            this.lblChart1.BackColor = System.Drawing.Color.Transparent;
            this.lblChart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChart1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblChart1.Location = new System.Drawing.Point(10, 10);
            this.lblChart1.Name = "lblChart1";
            this.lblChart1.Size = new System.Drawing.Size(447, 30);
            this.lblChart1.TabIndex = 1;
            this.lblChart1.Text = "Doanh thu 12 tháng trong năm (VNĐ)";
            this.lblChart1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardChart2
            // 
            this.cardChart2.BackColor = System.Drawing.Color.Transparent;
            this.cardChart2.BorderRadius = 10;
            this.cardChart2.Controls.Add(this.chart2);
            this.cardChart2.Controls.Add(this.lblChart2);
            this.cardChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChart2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardChart2.Location = new System.Drawing.Point(482, 0);
            this.cardChart2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cardChart2.Name = "cardChart2";
            this.cardChart2.Padding = new System.Windows.Forms.Padding(10);
            this.cardChart2.Size = new System.Drawing.Size(379, 422);
            this.cardChart2.TabIndex = 1;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart2.Location = new System.Drawing.Point(10, 40);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))))};
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(359, 372);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // lblChart2
            // 
            this.lblChart2.BackColor = System.Drawing.Color.Transparent;
            this.lblChart2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChart2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChart2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblChart2.Location = new System.Drawing.Point(10, 10);
            this.lblChart2.Name = "lblChart2";
            this.lblChart2.Size = new System.Drawing.Size(359, 30);
            this.lblChart2.TabIndex = 1;
            this.lblChart2.Text = "Top 5 sách bán chạy trong tháng";
            this.lblChart2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardChart3
            // 
            this.cardChart3.BackColor = System.Drawing.Color.Transparent;
            this.cardChart3.BorderRadius = 10;
            this.cardChart3.Controls.Add(this.chart3);
            this.cardChart3.Controls.Add(this.lblChart3);
            this.cardChart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChart3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardChart3.Location = new System.Drawing.Point(871, 0);
            this.cardChart3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cardChart3.Name = "cardChart3";
            this.cardChart3.Padding = new System.Windows.Forms.Padding(10);
            this.cardChart3.Size = new System.Drawing.Size(380, 422);
            this.cardChart3.TabIndex = 2;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(10, 40);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))))};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(360, 372);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // lblChart3
            // 
            this.lblChart3.BackColor = System.Drawing.Color.Transparent;
            this.lblChart3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChart3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChart3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblChart3.Location = new System.Drawing.Point(10, 10);
            this.lblChart3.Name = "lblChart3";
            this.lblChart3.Size = new System.Drawing.Size(360, 30);
            this.lblChart3.TabIndex = 1;
            this.lblChart3.Text = "Cơ cấu doanh thu theo thể loại";
            this.lblChart3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrid.BorderRadius = 10;
            this.pnlGrid.Controls.Add(this.dataGridView1);
            this.pnlGrid.Controls.Add(this.lblTop5);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlGrid.Location = new System.Drawing.Point(12, 506);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrid.Size = new System.Drawing.Size(1256, 210);
            this.pnlGrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSach,
            this.SoLuongBan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 160);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 38;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 32;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            // 
            // lblTop5
            // 
            this.lblTop5.BackColor = System.Drawing.Color.Transparent;
            this.lblTop5.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTop5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTop5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTop5.Location = new System.Drawing.Point(10, 10);
            this.lblTop5.Name = "lblTop5";
            this.lblTop5.Size = new System.Drawing.Size(1236, 30);
            this.lblTop5.TabIndex = 1;
            this.lblTop5.Text = "Chi tiết Top 5 sách bán chạy trong tháng đã chọn";
            this.lblTop5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spacerB
            // 
            this.spacerB.BackColor = System.Drawing.Color.Transparent;
            this.spacerB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spacerB.Location = new System.Drawing.Point(12, 716);
            this.spacerB.Name = "spacerB";
            this.spacerB.Size = new System.Drawing.Size(1256, 12);
            this.spacerB.TabIndex = 2;
            // 
            // spacerT
            // 
            this.spacerT.BackColor = System.Drawing.Color.Transparent;
            this.spacerT.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacerT.Location = new System.Drawing.Point(12, 76);
            this.spacerT.Name = "spacerT";
            this.spacerT.Size = new System.Drawing.Size(1256, 8);
            this.spacerT.TabIndex = 3;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblTieuDe);
            this.pnlTop.Controls.Add(this.lblPhuDe);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cboThang);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.cboNam);
            this.pnlTop.Controls.Add(this.btnXemChiTiet);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1256, 64);
            this.pnlTop.TabIndex = 4;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 6);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(504, 41);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÁO CÁO THỐNG KÊ DOANH THU";
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPhuDe.Location = new System.Drawing.Point(2, 40);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(448, 25);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "Biểu đồ doanh thu, sách bán chạy và cơ cấu thể loại";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(746, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn tháng:";
            // 
            // cboThang
            // 
            this.cboThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboThang.BackColor = System.Drawing.Color.Transparent;
            this.cboThang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cboThang.BorderRadius = 6;
            this.cboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FocusedColor = System.Drawing.Color.Empty;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThang.ItemHeight = 30;
            this.cboThang.Location = new System.Drawing.Point(848, 14);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(110, 36);
            this.cboThang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(888, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn năm:";
            // 
            // cboNam
            // 
            this.cboNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNam.BackColor = System.Drawing.Color.Transparent;
            this.cboNam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.cboNam.BorderRadius = 6;
            this.cboNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FocusedColor = System.Drawing.Color.Empty;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNam.ItemHeight = 30;
            this.cboNam.Location = new System.Drawing.Point(966, 14);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(110, 36);
            this.cboNam.TabIndex = 5;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemChiTiet.Animated = true;
            this.btnXemChiTiet.BorderRadius = 8;
            this.btnXemChiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXemChiTiet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnXemChiTiet.Location = new System.Drawing.Point(1086, 12);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(170, 40);
            this.btnXemChiTiet.TabIndex = 6;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 8;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            this.SoLuongBan.HeaderText = "Số lượng bán";
            this.SoLuongBan.MinimumWidth = 8;
            this.SoLuongBan.Name = "SoLuongBan";
            this.SoLuongBan.ReadOnly = true;
            // 
            // frmChartDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.tblCharts);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.spacerB);
            this.Controls.Add(this.spacerT);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmChartDashboard";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmChartDashboard_Load);
            this.tblCharts.ResumeLayout(false);
            this.cardChart1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.cardChart2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.cardChart3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCharts;
        private Guna.UI2.WinForms.Guna2Panel cardChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblChart1;
        private Guna.UI2.WinForms.Guna2Panel cardChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblChart2;
        private Guna.UI2.WinForms.Guna2Panel cardChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label lblChart3;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTop5;
        private Guna.UI2.WinForms.Guna2Panel spacerB;
        private Guna.UI2.WinForms.Guna2Panel spacerT;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboThang;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboNam;
        private Guna.UI2.WinForms.Guna2Button btnXemChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
    }
}
