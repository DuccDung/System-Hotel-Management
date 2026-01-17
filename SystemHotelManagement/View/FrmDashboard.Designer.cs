namespace SystemHotelManagement.View
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlLeftPlaceholder = new Panel();
            flpLeftMenu = new FlowLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            panel1 = new Panel();
            lbl_db = new Label();
            pnlRight = new Panel();
            pnlEmployees = new Panel();
            pnlContent = new Panel();
            flpRooms = new FlowLayoutPanel();
            lblHint = new Label();
            grpStatuses = new GroupBox();
            btnRepair = new Button();
            btnReserved = new Button();
            btnClean = new Button();
            btnEmpty = new Button();
            btnDirty = new Button();
            btnUsing = new Button();
            btnReadyArrive = new Button();
            btnAll = new Button();
            grpFilters = new GroupBox();
            cboRoomType = new ComboBox();
            lblRoomType = new Label();
            pnlTopBar = new Panel();
            lblHotline = new Label();
            lblTitleTop = new Label();
            btn9 = new Button();
            pnlLeftPlaceholder.SuspendLayout();
            flpLeftMenu.SuspendLayout();
            panel1.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlContent.SuspendLayout();
            grpStatuses.SuspendLayout();
            grpFilters.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeftPlaceholder
            // 
            pnlLeftPlaceholder.BackColor = Color.FromArgb(226, 232, 240);
            pnlLeftPlaceholder.Controls.Add(flpLeftMenu);
            pnlLeftPlaceholder.Controls.Add(panel1);
            pnlLeftPlaceholder.Dock = DockStyle.Left;
            pnlLeftPlaceholder.Location = new Point(0, 0);
            pnlLeftPlaceholder.Name = "pnlLeftPlaceholder";
            pnlLeftPlaceholder.Size = new Size(250, 720);
            pnlLeftPlaceholder.TabIndex = 0;
            // 
            // flpLeftMenu
            // 
            flpLeftMenu.AutoScroll = true;
            flpLeftMenu.BackColor = Color.FromArgb(226, 232, 240);
            flpLeftMenu.Controls.Add(btn1);
            flpLeftMenu.Controls.Add(btn2);
            flpLeftMenu.Controls.Add(btn3);
            flpLeftMenu.Controls.Add(btn4);
            flpLeftMenu.Controls.Add(btn5);
            flpLeftMenu.Controls.Add(btn6);
            flpLeftMenu.Controls.Add(btn7);
            flpLeftMenu.Controls.Add(btn8);
            flpLeftMenu.Controls.Add(btn9);
            flpLeftMenu.Dock = DockStyle.Fill;
            flpLeftMenu.FlowDirection = FlowDirection.TopDown;
            flpLeftMenu.Location = new Point(0, 56);
            flpLeftMenu.Name = "flpLeftMenu";
            flpLeftMenu.Padding = new Padding(10, 12, 10, 10);
            flpLeftMenu.Size = new Size(250, 664);
            flpLeftMenu.TabIndex = 1;
            flpLeftMenu.WrapContents = false;
            // 
            // btn1
            // 
            btn1.Location = new Point(10, 12);
            btn1.Margin = new Padding(0, 0, 0, 8);
            btn1.Name = "btn1";
            btn1.Padding = new Padding(14, 0, 0, 0);
            btn1.Size = new Size(230, 42);
            btn1.TabIndex = 0;
            btn1.Text = "Quản lý";
            btn1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn2
            // 
            btn2.Location = new Point(10, 62);
            btn2.Margin = new Padding(0, 0, 0, 8);
            btn2.Name = "btn2";
            btn2.Padding = new Padding(14, 0, 0, 0);
            btn2.Size = new Size(230, 42);
            btn2.TabIndex = 1;
            btn2.Text = "Nhân viên";
            btn2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn3
            // 
            btn3.Location = new Point(10, 112);
            btn3.Margin = new Padding(0, 0, 0, 8);
            btn3.Name = "btn3";
            btn3.Padding = new Padding(14, 0, 0, 0);
            btn3.Size = new Size(230, 42);
            btn3.TabIndex = 2;
            btn3.Text = "Khách hàng";
            btn3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn4
            // 
            btn4.Location = new Point(10, 162);
            btn4.Margin = new Padding(0, 0, 0, 8);
            btn4.Name = "btn4";
            btn4.Padding = new Padding(14, 0, 0, 0);
            btn4.Size = new Size(230, 42);
            btn4.TabIndex = 3;
            btn4.Text = "Nhập hàng";
            btn4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn5
            // 
            btn5.Location = new Point(10, 212);
            btn5.Margin = new Padding(0, 0, 0, 8);
            btn5.Name = "btn5";
            btn5.Padding = new Padding(14, 0, 0, 0);
            btn5.Size = new Size(230, 42);
            btn5.TabIndex = 4;
            btn5.Text = "Phòng";
            btn5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn6
            // 
            btn6.Location = new Point(10, 262);
            btn6.Margin = new Padding(0, 0, 0, 8);
            btn6.Name = "btn6";
            btn6.Padding = new Padding(14, 0, 0, 0);
            btn6.Size = new Size(230, 42);
            btn6.TabIndex = 5;
            btn6.Text = "Loại phòng";
            btn6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn7
            // 
            btn7.Location = new Point(10, 312);
            btn7.Margin = new Padding(0, 0, 0, 8);
            btn7.Name = "btn7";
            btn7.Padding = new Padding(14, 0, 0, 0);
            btn7.Size = new Size(230, 42);
            btn7.TabIndex = 6;
            btn7.Text = "Chấm công nhân viên";
            btn7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn8
            // 
            btn8.Location = new Point(10, 362);
            btn8.Margin = new Padding(0, 0, 0, 8);
            btn8.Name = "btn8";
            btn8.Padding = new Padding(14, 0, 0, 0);
            btn8.Size = new Size(230, 42);
            btn8.TabIndex = 7;
            btn8.Text = "Tính lương nhân viên";
            btn8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_db);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 56);
            panel1.TabIndex = 0;
            // 
            // lbl_db
            // 
            lbl_db.Dock = DockStyle.Fill;
            lbl_db.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            lbl_db.ForeColor = Color.Navy;
            lbl_db.Location = new Point(0, 0);
            lbl_db.Name = "lbl_db";
            lbl_db.Size = new Size(250, 56);
            lbl_db.TabIndex = 0;
            lbl_db.Text = "Dashboard";
            lbl_db.TextAlign = ContentAlignment.MiddleCenter;
            lbl_db.Click += lbl_db_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(pnlEmployees);
            pnlRight.Controls.Add(pnlContent);
            pnlRight.Controls.Add(pnlTopBar);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(250, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1030, 720);
            pnlRight.TabIndex = 1;
            // 
            // pnlEmployees
            // 
            pnlEmployees.BackColor = Color.FromArgb(248, 250, 252);
            pnlEmployees.Dock = DockStyle.Fill;
            pnlEmployees.Location = new Point(0, 56);
            pnlEmployees.Name = "pnlEmployees";
            pnlEmployees.Size = new Size(1030, 664);
            pnlEmployees.TabIndex = 2;
            pnlEmployees.Visible = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(248, 250, 252);
            pnlContent.Controls.Add(flpRooms);
            pnlContent.Controls.Add(lblHint);
            pnlContent.Controls.Add(grpStatuses);
            pnlContent.Controls.Add(grpFilters);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 56);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(16);
            pnlContent.Size = new Size(1030, 664);
            pnlContent.TabIndex = 1;
            // 
            // flpRooms
            // 
            flpRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpRooms.AutoScroll = true;
            flpRooms.Location = new Point(19, 214);
            flpRooms.Name = "flpRooms";
            flpRooms.Padding = new Padding(6);
            flpRooms.Size = new Size(992, 430);
            flpRooms.TabIndex = 3;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 9.5F);
            lblHint.ForeColor = Color.FromArgb(220, 38, 38);
            lblHint.Location = new Point(22, 188);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(449, 21);
            lblHint.TabIndex = 2;
            lblHint.Text = "(* Di chuyển chọn hình ảnh để xem thông tin chi tiết đặt phòng)";
            // 
            // grpStatuses
            // 
            grpStatuses.Controls.Add(btnRepair);
            grpStatuses.Controls.Add(btnReserved);
            grpStatuses.Controls.Add(btnClean);
            grpStatuses.Controls.Add(btnEmpty);
            grpStatuses.Controls.Add(btnDirty);
            grpStatuses.Controls.Add(btnUsing);
            grpStatuses.Controls.Add(btnReadyArrive);
            grpStatuses.Controls.Add(btnAll);
            grpStatuses.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpStatuses.Location = new Point(19, 96);
            grpStatuses.Name = "grpStatuses";
            grpStatuses.Size = new Size(992, 82);
            grpStatuses.TabIndex = 1;
            grpStatuses.TabStop = false;
            grpStatuses.Text = "Trạng thái phòng";
            // 
            // btnRepair
            // 
            btnRepair.BackColor = Color.FromArgb(239, 68, 68);
            btnRepair.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            btnRepair.FlatStyle = FlatStyle.Flat;
            btnRepair.Font = new Font("Segoe UI", 9.5F);
            btnRepair.ForeColor = Color.White;
            btnRepair.Location = new Point(812, 30);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(160, 32);
            btnRepair.TabIndex = 7;
            btnRepair.Text = "Phòng đang sửa (0)";
            btnRepair.UseVisualStyleBackColor = false;
            // 
            // btnReserved
            // 
            btnReserved.BackColor = Color.FromArgb(202, 138, 4);
            btnReserved.FlatAppearance.BorderColor = Color.FromArgb(202, 138, 4);
            btnReserved.FlatStyle = FlatStyle.Flat;
            btnReserved.Font = new Font("Segoe UI", 9.5F);
            btnReserved.ForeColor = Color.White;
            btnReserved.Location = new Point(710, 30);
            btnReserved.Name = "btnReserved";
            btnReserved.Size = new Size(96, 32);
            btnReserved.TabIndex = 6;
            btnReserved.Text = "Phòng bận (0)";
            btnReserved.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(22, 163, 74);
            btnClean.FlatAppearance.BorderColor = Color.FromArgb(22, 163, 74);
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Segoe UI", 9.5F);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(590, 30);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(114, 32);
            btnClean.TabIndex = 5;
            btnClean.Text = "Phòng sạch (0)";
            btnClean.UseVisualStyleBackColor = false;
            // 
            // btnEmpty
            // 
            btnEmpty.BackColor = Color.White;
            btnEmpty.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnEmpty.FlatStyle = FlatStyle.Flat;
            btnEmpty.Font = new Font("Segoe UI", 9.5F);
            btnEmpty.Location = new Point(464, 30);
            btnEmpty.Name = "btnEmpty";
            btnEmpty.Size = new Size(120, 32);
            btnEmpty.TabIndex = 4;
            btnEmpty.Text = "Phòng trống (0)";
            btnEmpty.UseVisualStyleBackColor = false;
            // 
            // btnDirty
            // 
            btnDirty.BackColor = Color.White;
            btnDirty.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDirty.FlatStyle = FlatStyle.Flat;
            btnDirty.Font = new Font("Segoe UI", 9.5F);
            btnDirty.Location = new Point(338, 30);
            btnDirty.Name = "btnDirty";
            btnDirty.Size = new Size(120, 32);
            btnDirty.TabIndex = 3;
            btnDirty.Text = "Chuẩn bị rời đi (0)";
            btnDirty.UseVisualStyleBackColor = false;
            // 
            // btnUsing
            // 
            btnUsing.BackColor = Color.White;
            btnUsing.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnUsing.FlatStyle = FlatStyle.Flat;
            btnUsing.Font = new Font("Segoe UI", 9.5F);
            btnUsing.Location = new Point(242, 30);
            btnUsing.Name = "btnUsing";
            btnUsing.Size = new Size(90, 32);
            btnUsing.TabIndex = 2;
            btnUsing.Text = "Đang ở (0)";
            btnUsing.UseVisualStyleBackColor = false;
            // 
            // btnReadyArrive
            // 
            btnReadyArrive.BackColor = Color.White;
            btnReadyArrive.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnReadyArrive.FlatStyle = FlatStyle.Flat;
            btnReadyArrive.Font = new Font("Segoe UI", 9.5F);
            btnReadyArrive.Location = new Point(116, 30);
            btnReadyArrive.Name = "btnReadyArrive";
            btnReadyArrive.Size = new Size(120, 32);
            btnReadyArrive.TabIndex = 1;
            btnReadyArrive.Text = "Chuẩn bị đến (0)";
            btnReadyArrive.UseVisualStyleBackColor = false;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.White;
            btnAll.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Font = new Font("Segoe UI", 9.5F);
            btnAll.Location = new Point(18, 30);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(92, 32);
            btnAll.TabIndex = 0;
            btnAll.Text = "Tất cả";
            btnAll.UseVisualStyleBackColor = false;
            // 
            // grpFilters
            // 
            grpFilters.Controls.Add(cboRoomType);
            grpFilters.Controls.Add(lblRoomType);
            grpFilters.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpFilters.Location = new Point(19, 16);
            grpFilters.Name = "grpFilters";
            grpFilters.Size = new Size(520, 74);
            grpFilters.TabIndex = 0;
            grpFilters.TabStop = false;
            grpFilters.Text = "Bộ lọc";
            // 
            // cboRoomType
            // 
            cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomType.Font = new Font("Segoe UI", 10F);
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Location = new Point(110, 30);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(240, 31);
            cboRoomType.TabIndex = 1;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 10F);
            lblRoomType.Location = new Point(18, 33);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(100, 23);
            lblRoomType.TabIndex = 0;
            lblRoomType.Text = "Loại phòng:";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(15, 98, 254);
            pnlTopBar.Controls.Add(lblHotline);
            pnlTopBar.Controls.Add(lblTitleTop);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1030, 56);
            pnlTopBar.TabIndex = 0;
            // 
            // lblHotline
            // 
            lblHotline.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHotline.AutoSize = true;
            lblHotline.Font = new Font("Segoe UI", 10F);
            lblHotline.ForeColor = Color.White;
            lblHotline.Location = new Point(716, 18);
            lblHotline.Name = "lblHotline";
            lblHotline.Size = new Size(351, 23);
            lblHotline.TabIndex = 1;
            lblHotline.Text = "Điện thoại hỗ trợ: 024 6259 8307     Live chat";
            // 
            // lblTitleTop
            // 
            lblTitleTop.AutoSize = true;
            lblTitleTop.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            lblTitleTop.ForeColor = Color.White;
            lblTitleTop.Location = new Point(18, 16);
            lblTitleTop.Name = "lblTitleTop";
            lblTitleTop.Size = new Size(138, 30);
            lblTitleTop.TabIndex = 0;
            lblTitleTop.Text = "Sơ đồ phòng";
            // 
            // btn9
            // 
            btn9.Location = new Point(10, 412);
            btn9.Margin = new Padding(0, 0, 0, 8);
            btn9.Name = "btn9";
            btn9.Padding = new Padding(14, 0, 0, 0);
            btn9.Size = new Size(230, 42);
            btn9.TabIndex = 8;
            btn9.Text = "Doanh thu/lợi nhuận";
            btn9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeftPlaceholder);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - SystemHotelManagement";
            pnlLeftPlaceholder.ResumeLayout(false);
            flpLeftMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            grpStatuses.ResumeLayout(false);
            grpFilters.ResumeLayout(false);
            grpFilters.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        // ===== Fields (KHAI BÁO ĐẦY ĐỦ - không đỏ) =====
        private System.Windows.Forms.Panel pnlLeftPlaceholder;
        private System.Windows.Forms.Panel pnlRight;
        private Panel pnlEmployees;


        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblHotline;
        private System.Windows.Forms.Label lblTitleTop;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cboRoomType;

        private System.Windows.Forms.GroupBox grpStatuses;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnReadyArrive;
        private System.Windows.Forms.Button btnUsing;
        private System.Windows.Forms.Button btnDirty;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnReserved;
        private System.Windows.Forms.Button btnRepair;

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;

        private FlowLayoutPanel flpLeftMenu;



        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.FlowLayoutPanel flpRooms;
        private Panel panel1;
        private Label lbl_db;
        private Button btn8;
        private Button btn9;
    }
}
