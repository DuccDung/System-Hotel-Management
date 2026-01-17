namespace SystemHotelManagement.View
{
    partial class FrmSalaryReport
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
            lblFrom = new Label();
            dtFrom = new DateTimePicker();
            lblTo = new Label();
            dtTo = new DateTimePicker();
            btnCalc = new Button();
            btnExport = new Button();
            splitMain = new SplitContainer();
            grpSummary = new GroupBox();
            dgvSummary = new DataGridView();
            grpDetail = new GroupBox();
            dgvDetail = new DataGridView();
            pnlDetailTop = new Panel();
            lblEmpName = new Label();
            lblEmpRole = new Label();
            lblRate = new Label();
            lblTotal = new Label();
            pnlTop.SuspendLayout();
            grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            pnlDetailTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(grpFilters);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(16, 16);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1168, 86);
            pnlTop.TabIndex = 1;
            // 
            // grpFilters
            // 
            grpFilters.BackColor = Color.White;
            grpFilters.Controls.Add(lblFrom);
            grpFilters.Controls.Add(dtFrom);
            grpFilters.Controls.Add(lblTo);
            grpFilters.Controls.Add(dtTo);
            grpFilters.Controls.Add(btnCalc);
            grpFilters.Controls.Add(btnExport);
            grpFilters.Dock = DockStyle.Fill;
            grpFilters.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpFilters.Location = new Point(0, 0);
            grpFilters.Name = "grpFilters";
            grpFilters.Padding = new Padding(12);
            grpFilters.Size = new Size(1168, 86);
            grpFilters.TabIndex = 0;
            grpFilters.TabStop = false;
            grpFilters.Text = "Tính lương theo khoảng thời gian";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 10F);
            lblFrom.Location = new Point(14, 38);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(33, 23);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Từ:";
            // 
            // dtFrom
            // 
            dtFrom.Font = new Font("Segoe UI", 10F);
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(52, 34);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(150, 30);
            dtFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 10F);
            lblTo.Location = new Point(216, 38);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(45, 23);
            lblTo.TabIndex = 2;
            lblTo.Text = "Đến:";
            // 
            // dtTo
            // 
            dtTo.Font = new Font("Segoe UI", 10F);
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(265, 34);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(150, 30);
            dtTo.TabIndex = 3;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 10F);
            btnCalc.Location = new Point(435, 33);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(140, 32);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Tính lương";
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 10F);
            btnExport.Location = new Point(585, 33);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(160, 32);
            btnExport.TabIndex = 5;
            btnExport.Text = "Xuất Excel (.xlsx)";
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(16, 102);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(grpSummary);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(grpDetail);
            splitMain.Size = new Size(1168, 582);
            splitMain.SplitterDistance = 529;
            splitMain.TabIndex = 0;
            // 
            // grpSummary
            // 
            grpSummary.BackColor = Color.White;
            grpSummary.Controls.Add(dgvSummary);
            grpSummary.Dock = DockStyle.Fill;
            grpSummary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpSummary.Location = new Point(0, 0);
            grpSummary.Name = "grpSummary";
            grpSummary.Padding = new Padding(12);
            grpSummary.Size = new Size(529, 582);
            grpSummary.TabIndex = 0;
            grpSummary.TabStop = false;
            grpSummary.Text = "Tổng hợp lương theo nhân viên";
            // 
            // dgvSummary
            // 
            dgvSummary.AllowUserToAddRows = false;
            dgvSummary.AllowUserToDeleteRows = false;
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummary.ColumnHeadersHeight = 29;
            dgvSummary.Dock = DockStyle.Fill;
            dgvSummary.Location = new Point(12, 35);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.ReadOnly = true;
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSummary.Size = new Size(505, 535);
            dgvSummary.TabIndex = 0;
            // 
            // grpDetail
            // 
            grpDetail.BackColor = Color.White;
            grpDetail.Controls.Add(dgvDetail);
            grpDetail.Controls.Add(pnlDetailTop);
            grpDetail.Dock = DockStyle.Fill;
            grpDetail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpDetail.Location = new Point(0, 0);
            grpDetail.Name = "grpDetail";
            grpDetail.Padding = new Padding(12);
            grpDetail.Size = new Size(635, 582);
            grpDetail.TabIndex = 0;
            grpDetail.TabStop = false;
            grpDetail.Text = "Chi tiết chấm công theo ngày";
            // 
            // dgvDetail
            // 
            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.AllowUserToDeleteRows = false;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.ColumnHeadersHeight = 29;
            dgvDetail.Dock = DockStyle.Fill;
            dgvDetail.Location = new Point(12, 93);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.ReadOnly = true;
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetail.Size = new Size(611, 477);
            dgvDetail.TabIndex = 0;
            // 
            // pnlDetailTop
            // 
            pnlDetailTop.Controls.Add(lblEmpName);
            pnlDetailTop.Controls.Add(lblEmpRole);
            pnlDetailTop.Controls.Add(lblRate);
            pnlDetailTop.Controls.Add(lblTotal);
            pnlDetailTop.Dock = DockStyle.Top;
            pnlDetailTop.Location = new Point(12, 35);
            pnlDetailTop.Name = "pnlDetailTop";
            pnlDetailTop.Size = new Size(611, 58);
            pnlDetailTop.TabIndex = 1;
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblEmpName.Location = new Point(0, 6);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(129, 25);
            lblEmpName.TabIndex = 0;
            lblEmpName.Text = "Nhân viên: —";
            // 
            // lblEmpRole
            // 
            lblEmpRole.AutoSize = true;
            lblEmpRole.Font = new Font("Segoe UI", 10F);
            lblEmpRole.Location = new Point(0, 30);
            lblEmpRole.Name = "lblEmpRole";
            lblEmpRole.Size = new Size(98, 23);
            lblEmpRole.TabIndex = 1;
            lblEmpRole.Text = "Chức vụ: —";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 10F);
            lblRate.Location = new Point(260, 30);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(115, 23);
            lblRate.TabIndex = 2;
            lblRate.Text = "Lương/giờ: —";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(260, 6);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(140, 25);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Tổng lương: —";
            // 
            // FrmSalaryReport
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1200, 700);
            Controls.Add(splitMain);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSalaryReport";
            Padding = new Padding(16);
            Text = "FrmSalaryReport";
            pnlTop.ResumeLayout(false);
            grpFilters.ResumeLayout(false);
            grpFilters.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            grpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            pnlDetailTop.ResumeLayout(false);
            pnlDetailTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExport;

        private System.Windows.Forms.SplitContainer splitMain;

        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.DataGridView dgvSummary;

        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Panel pnlDetailTop;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpRole;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvDetail;
    }
}
