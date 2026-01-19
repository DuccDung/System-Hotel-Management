using System;
using System.IO;
using System.Windows.Forms;
using SystemHotelManagement.Helper;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
            //load logo
            LoadLogo();
            // testing
            txtUsername.Text = "admin";
            txtPassword.Text = "123456";
        }
        private void LoadLogo()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string logoPath = Path.Combine(
                baseDir,
                "assets",
                "img",
                "logo.jpg"
            );

            if (File.Exists(logoPath))
            {
                using (var fs = new FileStream(logoPath, FileMode.Open, FileAccess.Read))
                {
                    picLogo.Image = Image.FromStream(fs);
                    picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    picLogo.BackColor = Color.Transparent;
                }
            }
            else
            {
                MessageBox.Show("❌ Không tìm thấy logo:\n" + logoPath);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Liên hệ quản trị để cấp lại mật khẩu.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using SystemHotelManagementContext db = new SystemHotelManagementContext();

            var u = txtUsername.Text.Trim();
            var p = txtPassword.Text;
            var user = db.Accounts
                .FirstOrDefault(a => a.Username == u && a.PasswordHash == p);

            // select *  from acccount where (id == 1)
            if (user == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var employee = db.Employees.Find(user.EmployeeId);
                AppSession.SignIn(user.EmployeeId, user.Username, employee.FullName , employee.Role);
                var dashboard = new FrmDashboard();
                dashboard.Show();

                this.Hide();
            }

        }
    }
}
