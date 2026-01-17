namespace SystemHotelManagement.View
{
    partial class FrmCustomersRanking
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
            pnlTop = new Panel();
            grpFilters = new GroupBox();
            tlpFilters = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFrom = new Label();
            dtFrom = new DateTimePicker();
            lblTo = new Label();
            dtTo = new DateTimePicker();
            chkAllTime = new CheckBox();
            btnRefresh = new Button();
            grpTop3 = new GroupBox();
            tlpTop3 = new TableLayoutPanel();
            card1 = new Panel();
            lblTop1Amount = new Label();
            lblTop1Name = new Label();
            lblTop1Title = new Label();
            card2 = new Panel();
            lblTop2Amount = new Label();
            lblTop2Name = new Label();
            lblTop2Title = new Label();
            card3 = new Panel();
            lblTop3Amount = new Label();
            lblTop3Name = new Label();
            lblTop3Title = new Label();
            pnlMain = new Panel();
            grpList = new GroupBox();
            dgvCustomers = new DataGridView();
            pnlTop.SuspendLayout();
            grpFilters.SuspendLayout();
            tlpFilters.SuspendLayout();
            grpTop3.SuspendLayout();
            tlpTop3.SuspendLayout();
            card1.SuspendLayout();
            card2.SuspendLayout();
            card3.SuspendLayout();
            pnlMain.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(248, 250, 252);
            pnlTop.Controls.Add(grpFilters);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(16, 16);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1048, 86);
            pnlTop.TabIndex = 0;
            // 
            // grpFilters
            // 
            grpFilters.BackColor = Color.White;
            grpFilters.Controls.Add(tlpFilters);
            grpFilters.Dock = DockStyle.Fill;
            grpFilters.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpFilters.Location = new Point(0, 0);
            grpFilters.Name = "grpFilters";
            grpFilters.Padding = new Padding(12);
            grpFilters.Size = new Size(1048, 86);
            grpFilters.TabIndex = 0;
            grpFilters.TabStop = false;
            grpFilters.Text = "Bộ lọc / tìm kiếm";
            // 
            // tlpFilters
            // 
            tlpFilters.ColumnCount = 8;
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpFilters.Controls.Add(lblSearch, 0, 0);
            tlpFilters.Controls.Add(txtSearch, 1, 0);
            tlpFilters.Controls.Add(lblFrom, 2, 0);
            tlpFilters.Controls.Add(dtFrom, 3, 0);
            tlpFilters.Controls.Add(lblTo, 4, 0);
            tlpFilters.Controls.Add(dtTo, 5, 0);
            tlpFilters.Controls.Add(chkAllTime, 6, 0);
            tlpFilters.Controls.Add(btnRefresh, 7, 0);
            tlpFilters.Dock = DockStyle.Fill;
            tlpFilters.Location = new Point(12, 35);
            tlpFilters.Name = "tlpFilters";
            tlpFilters.RowCount = 1;
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFilters.Size = new Size(1024, 39);
            tlpFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(38, 39);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(48, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(276, 30);
            txtSearch.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.Anchor = AnchorStyles.Left;
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 10F);
            lblFrom.Location = new Point(330, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(51, 39);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "Từ ngày:";
            // 
            // dtFrom
            // 
            dtFrom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtFrom.Font = new Font("Segoe UI", 10F);
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(400, 4);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(119, 30);
            dtFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.Anchor = AnchorStyles.Left;
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 10F);
            lblTo.Location = new Point(525, 8);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(45, 23);
            lblTo.TabIndex = 4;
            lblTo.Text = "Đến:";
            // 
            // dtTo
            // 
            dtTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtTo.Font = new Font("Segoe UI", 10F);
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(600, 4);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(119, 30);
            dtTo.TabIndex = 5;
            // 
            // chkAllTime
            // 
            chkAllTime.Anchor = AnchorStyles.Left;
            chkAllTime.AutoSize = true;
            chkAllTime.Font = new Font("Segoe UI", 10F);
            chkAllTime.Location = new Point(725, 6);
            chkAllTime.Name = "chkAllTime";
            chkAllTime.Size = new Size(178, 27);
            chkAllTime.TabIndex = 6;
            chkAllTime.Text = "Tính toàn thời gian";
            chkAllTime.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(917, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(104, 33);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // grpTop3
            // 
            grpTop3.BackColor = Color.White;
            grpTop3.Controls.Add(tlpTop3);
            grpTop3.Dock = DockStyle.Top;
            grpTop3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpTop3.Location = new Point(16, 102);
            grpTop3.Name = "grpTop3";
            grpTop3.Padding = new Padding(12);
            grpTop3.Size = new Size(1048, 150);
            grpTop3.TabIndex = 1;
            grpTop3.TabStop = false;
            grpTop3.Text = "Vinh danh TOP 3 khách hàng";
            // 
            // tlpTop3
            // 
            tlpTop3.ColumnCount = 3;
            tlpTop3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpTop3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpTop3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpTop3.Controls.Add(card1, 0, 0);
            tlpTop3.Controls.Add(card2, 1, 0);
            tlpTop3.Controls.Add(card3, 2, 0);
            tlpTop3.Dock = DockStyle.Fill;
            tlpTop3.Location = new Point(12, 35);
            tlpTop3.Name = "tlpTop3";
            tlpTop3.RowCount = 1;
            tlpTop3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTop3.Size = new Size(1024, 103);
            tlpTop3.TabIndex = 0;
            // 
            // card1
            // 
            card1.BackColor = Color.FromArgb(248, 250, 252);
            card1.BorderStyle = BorderStyle.FixedSingle;
            card1.Controls.Add(lblTop1Amount);
            card1.Controls.Add(lblTop1Name);
            card1.Controls.Add(lblTop1Title);
            card1.Dock = DockStyle.Fill;
            card1.Location = new Point(8, 8);
            card1.Margin = new Padding(8);
            card1.Name = "card1";
            card1.Padding = new Padding(12);
            card1.Size = new Size(325, 87);
            card1.TabIndex = 0;
            // 
            // lblTop1Amount
            // 
            lblTop1Amount.AutoSize = true;
            lblTop1Amount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTop1Amount.Location = new Point(161, 7);
            lblTop1Amount.Name = "lblTop1Amount";
            lblTop1Amount.Size = new Size(41, 28);
            lblTop1Amount.TabIndex = 2;
            lblTop1Amount.Text = "0 ₫";
            // 
            // lblTop1Name
            // 
            lblTop1Name.AutoSize = true;
            lblTop1Name.Font = new Font("Segoe UI", 11F);
            lblTop1Name.Location = new Point(12, 38);
            lblTop1Name.Name = "lblTop1Name";
            lblTop1Name.Size = new Size(31, 25);
            lblTop1Name.TabIndex = 1;
            lblTop1Name.Text = "—";
            // 
            // lblTop1Title
            // 
            lblTop1Title.AutoSize = true;
            lblTop1Title.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTop1Title.Location = new Point(12, 10);
            lblTop1Title.Name = "lblTop1Title";
            lblTop1Title.Size = new Size(98, 25);
            lblTop1Title.TabIndex = 0;
            lblTop1Title.Text = "\U0001f947 Hạng 1";
            // 
            // card2
            // 
            card2.BackColor = Color.FromArgb(248, 250, 252);
            card2.BorderStyle = BorderStyle.FixedSingle;
            card2.Controls.Add(lblTop2Amount);
            card2.Controls.Add(lblTop2Name);
            card2.Controls.Add(lblTop2Title);
            card2.Dock = DockStyle.Fill;
            card2.Location = new Point(349, 8);
            card2.Margin = new Padding(8);
            card2.Name = "card2";
            card2.Padding = new Padding(12);
            card2.Size = new Size(325, 87);
            card2.TabIndex = 1;
            // 
            // lblTop2Amount
            // 
            lblTop2Amount.AutoSize = true;
            lblTop2Amount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTop2Amount.Location = new Point(163, 7);
            lblTop2Amount.Name = "lblTop2Amount";
            lblTop2Amount.Size = new Size(41, 28);
            lblTop2Amount.TabIndex = 2;
            lblTop2Amount.Text = "0 ₫";
            // 
            // lblTop2Name
            // 
            lblTop2Name.AutoSize = true;
            lblTop2Name.Font = new Font("Segoe UI", 11F);
            lblTop2Name.Location = new Point(12, 38);
            lblTop2Name.Name = "lblTop2Name";
            lblTop2Name.Size = new Size(31, 25);
            lblTop2Name.TabIndex = 1;
            lblTop2Name.Text = "—";
            // 
            // lblTop2Title
            // 
            lblTop2Title.AutoSize = true;
            lblTop2Title.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTop2Title.Location = new Point(12, 10);
            lblTop2Title.Name = "lblTop2Title";
            lblTop2Title.Size = new Size(101, 25);
            lblTop2Title.TabIndex = 0;
            lblTop2Title.Text = "\U0001f948 Hạng 2";
            // 
            // card3
            // 
            card3.BackColor = Color.FromArgb(248, 250, 252);
            card3.BorderStyle = BorderStyle.FixedSingle;
            card3.Controls.Add(lblTop3Amount);
            card3.Controls.Add(lblTop3Name);
            card3.Controls.Add(lblTop3Title);
            card3.Dock = DockStyle.Fill;
            card3.Location = new Point(690, 8);
            card3.Margin = new Padding(8);
            card3.Name = "card3";
            card3.Padding = new Padding(12);
            card3.Size = new Size(326, 87);
            card3.TabIndex = 2;
            // 
            // lblTop3Amount
            // 
            lblTop3Amount.AutoSize = true;
            lblTop3Amount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTop3Amount.Location = new Point(171, 7);
            lblTop3Amount.Name = "lblTop3Amount";
            lblTop3Amount.Size = new Size(41, 28);
            lblTop3Amount.TabIndex = 2;
            lblTop3Amount.Text = "0 ₫";
            // 
            // lblTop3Name
            // 
            lblTop3Name.AutoSize = true;
            lblTop3Name.Font = new Font("Segoe UI", 11F);
            lblTop3Name.Location = new Point(12, 38);
            lblTop3Name.Name = "lblTop3Name";
            lblTop3Name.Size = new Size(31, 25);
            lblTop3Name.TabIndex = 1;
            lblTop3Name.Text = "—";
            // 
            // lblTop3Title
            // 
            lblTop3Title.AutoSize = true;
            lblTop3Title.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTop3Title.Location = new Point(12, 10);
            lblTop3Title.Name = "lblTop3Title";
            lblTop3Title.Size = new Size(101, 25);
            lblTop3Title.TabIndex = 0;
            lblTop3Title.Text = "\U0001f949 Hạng 3";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(248, 250, 252);
            pnlMain.Controls.Add(grpList);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(16, 252);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(0, 10, 0, 0);
            pnlMain.Size = new Size(1048, 412);
            pnlMain.TabIndex = 2;
            // 
            // grpList
            // 
            grpList.BackColor = Color.White;
            grpList.Controls.Add(dgvCustomers);
            grpList.Dock = DockStyle.Fill;
            grpList.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpList.Location = new Point(0, 10);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(12);
            grpList.Size = new Size(1048, 402);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "Xếp hạng khách hàng (tổng tiền đã trả)";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(12, 35);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1024, 355);
            dgvCustomers.TabIndex = 0;
            // 
            // FrmCustomersRanking
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1080, 680);
            Controls.Add(pnlMain);
            Controls.Add(grpTop3);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCustomersRanking";
            Padding = new Padding(16);
            Text = "FrmCustomersRanking";
            pnlTop.ResumeLayout(false);
            grpFilters.ResumeLayout(false);
            tlpFilters.ResumeLayout(false);
            tlpFilters.PerformLayout();
            grpTop3.ResumeLayout(false);
            tlpTop3.ResumeLayout(false);
            card1.ResumeLayout(false);
            card1.PerformLayout();
            card2.ResumeLayout(false);
            card2.PerformLayout();
            card3.ResumeLayout(false);
            card3.PerformLayout();
            pnlMain.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.TableLayoutPanel tlpFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.CheckBox chkAllTime;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.GroupBox grpTop3;
        private System.Windows.Forms.TableLayoutPanel tlpTop3;

        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Label lblTop1Title;
        private System.Windows.Forms.Label lblTop1Name;
        private System.Windows.Forms.Label lblTop1Amount;

        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Label lblTop2Title;
        private System.Windows.Forms.Label lblTop2Name;
        private System.Windows.Forms.Label lblTop2Amount;

        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Label lblTop3Title;
        private System.Windows.Forms.Label lblTop3Name;
        private System.Windows.Forms.Label lblTop3Amount;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}
