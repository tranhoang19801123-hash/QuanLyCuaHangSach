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

namespace WindowsFormsApp2.Forms
{
    public partial class frmConnectionConfig : Form
    {
        public frmConnectionConfig()
        {
            InitializeComponent();
            this.Load += frmConnectionConfig_Load;

            // Đăng ký sự kiện các nút bấm và thay đổi chế độ xác thực
            btnTest.Click += btnTest_Click;
            btnLuu.Click += btnLuu_Click;
            rdoWindows.CheckedChanged += RadAuth_CheckedChanged;
            rdoSQL.CheckedChanged += RadAuth_CheckedChanged;
        }
        private void frmConnectionConfig_Load(object sender, EventArgs e)
        {
            // Mặc định chọn Windows Authentication khi mở form
            rdoWindows.Checked = true;
            ToggleAuthInputs(false);

            // Đọc thông tin kết nối hiện tại (nếu có trong App.config) để hiển thị lên form
            string server, db, user, pass;
            bool isWinAuth;
            ConnectionHelper.ReadBuilder(out server, out db, out user, out pass, out isWinAuth);

            if (!string.IsNullOrEmpty(server))
            {
                txtServer.Text = server;
                txtDatabase.Text = db;
                if (isWinAuth)
                {
                    rdoWindows.Checked = true;
                    ToggleAuthInputs(false);
                }
                else
                {
                    rdoSQL.Checked = true;
                    ToggleAuthInputs(true);
                    txtUser.Text = user;
                    txtPass.Text = pass;
                }
            }
        }


        private void RadAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSQL.Checked)
            {
                ToggleAuthInputs(true);
            }
            else
            {
                ToggleAuthInputs(false);
            }
        }

        private void ToggleAuthInputs(bool isEnabled)
        {
            txtUser.Enabled = isEnabled;
            txtPass.Enabled = isEnabled;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text.Trim();
            string db = txtDatabase.Text.Trim();
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            bool isWinAuth = rdoWindows.Checked;

            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(db))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Server và Database trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi hàm Save đã có sẵn trong ConnectionHelper của bạn
                ConnectionHelper.Save(server, db, user, pass, isWinAuth);
                MessageBox.Show("Đã lưu cấu hình kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu cấu hình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    


        

        private void btnTest_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text.Trim();
            string db = txtDatabase.Text.Trim();
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            bool isWinAuth = rdoWindows.Checked;

            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(db))
            {
                MessageBox.Show("Vui lòng nhập tên Server và Database!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = ConnectionHelper.Test(server, db, user, pass, isWinAuth);
            if (result)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kết nối thất bại! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConnectionConfig_Load_1(object sender, EventArgs e)
        {

        }
    }
}
