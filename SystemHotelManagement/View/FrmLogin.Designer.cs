namespace SystemHotelManagement.View
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            lblFooter = new Label();
            lblSubtitle = new Label();
            lblBrand = new Label();
            picLogo = new PictureBox();
            pnlRight = new Panel();
            pnlContent = new Panel();
            card = new Panel();
            lnkForgot = new LinkLabel();
            chkShowPassword = new CheckBox();
            chkRemember = new CheckBox();
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPass = new Label();
            txtUsername = new TextBox();
            lblUser = new Label();
            lblHint = new Label();
            lblWelcome = new Label();
            pnlTopBar = new Panel();
            lblTopTitle = new Label();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRight.SuspendLayout();
            pnlContent.SuspendLayout();
            card.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(15, 98, 254);
            pnlLeft.Controls.Add(lblFooter);
            pnlLeft.Controls.Add(lblSubtitle);
            pnlLeft.Controls.Add(lblBrand);
            pnlLeft.Controls.Add(picLogo);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(317, 515);
            pnlLeft.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 9.5F);
            lblFooter.ForeColor = Color.FromArgb(230, 240, 255);
            lblFooter.Location = new Point(3, 462);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(320, 25);
            lblFooter.TabIndex = 3;
            lblFooter.Text = "© PMS | Support: 024 6259 8307";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(230, 240, 255);
            lblSubtitle.Location = new Point(29, 244);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(285, 70);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "PMS - Hotel Management System\r\nĐăng nhập để tiếp tục";
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(26, 182);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(285, 62);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "Quản lý ";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(26, 40);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 120);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(pnlContent);
            pnlRight.Controls.Add(pnlTopBar);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(317, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(571, 515);
            pnlRight.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(card);
            pnlContent.Controls.Add(lblHint);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 56);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(60, 36, 60, 36);
            pnlContent.Size = new Size(571, 459);
            pnlContent.TabIndex = 1;
            // 
            // card
            // 
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Controls.Add(lnkForgot);
            card.Controls.Add(chkShowPassword);
            card.Controls.Add(chkRemember);
            card.Controls.Add(btnExit);
            card.Controls.Add(btnLogin);
            card.Controls.Add(txtPassword);
            card.Controls.Add(lblPass);
            card.Controls.Add(txtUsername);
            card.Controls.Add(lblUser);
            card.Location = new Point(18, 119);
            card.Name = "card";
            card.Size = new Size(520, 320);
            card.TabIndex = 2;
            // 
            // lnkForgot
            // 
            lnkForgot.ActiveLinkColor = Color.FromArgb(10, 80, 210);
            lnkForgot.AutoSize = true;
            lnkForgot.LinkColor = Color.FromArgb(15, 98, 254);
            lnkForgot.Location = new Point(377, 169);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(137, 23);
            lnkForgot.TabIndex = 6;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Quên mật khẩu?";
            lnkForgot.VisitedLinkColor = Color.FromArgb(15, 98, 254);
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.FromArgb(51, 65, 85);
            chkShowPassword.Location = new Point(206, 168);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(144, 27);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.ForeColor = Color.FromArgb(51, 65, 85);
            chkRemember.Location = new Point(28, 168);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(181, 27);
            chkRemember.TabIndex = 4;
            chkRemember.Text = "Ghi nhớ đăng nhập";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(15, 98, 254);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(15, 98, 254);
            btnExit.Location = new Point(28, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(460, 40);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(15, 98, 254);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(28, 214);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(460, 44);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(28, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(460, 32);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.ForeColor = Color.FromArgb(51, 65, 85);
            lblPass.Location = new Point(28, 98);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(82, 23);
            lblPass.TabIndex = 2;
            lblPass.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(28, 52);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(460, 32);
            txtUsername.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.FromArgb(51, 65, 85);
            lblUser.Location = new Point(28, 28);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(124, 23);
            lblUser.TabIndex = 0;
            lblUser.Text = "Tên đăng nhập";
            // 
            // lblHint
            // 
            lblHint.Font = new Font("Segoe UI", 10.5F);
            lblHint.ForeColor = Color.FromArgb(71, 85, 105);
            lblHint.Location = new Point(18, 76);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(520, 28);
            lblHint.TabIndex = 1;
            lblHint.Text = "Vui lòng nhập tài khoản để truy cập hệ thống quản lý khách sạn.";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 41, 59);
            lblWelcome.Location = new Point(18, 36);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(500, 40);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Chào mừng bạn trở lại 👋";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(15, 98, 254);
            pnlTopBar.Controls.Add(lblTopTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(571, 56);
            pnlTopBar.TabIndex = 0;
            // 
            // lblTopTitle
            // 
            lblTopTitle.AutoSize = true;
            lblTopTitle.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            lblTopTitle.ForeColor = Color.White;
            lblTopTitle.Location = new Point(18, 16);
            lblTopTitle.Name = "lblTopTitle";
            lblTopTitle.Size = new Size(248, 30);
            lblTopTitle.TabIndex = 0;
            lblTopTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 515);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - Quản lý khách sạn";
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            card.ResumeLayout(false);
            card.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFooter;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTopTitle;

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHint;

        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}
