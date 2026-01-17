namespace SystemHotelManagement.View
{
    partial class FrmRevenueProfitReport
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.tlpSummary = new System.Windows.Forms.TableLayoutPanel();

            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();

            this.lblSalaryTitle = new System.Windows.Forms.Label();
            this.lblSalaryValue = new System.Windows.Forms.Label();

            this.lblImportTitle = new System.Windows.Forms.Label();
            this.lblImportValue = new System.Windows.Forms.Label();

            this.lblProfitTitle = new System.Windows.Forms.Label();
            this.lblProfitValue = new System.Windows.Forms.Label();

            this.splitMain = new System.Windows.Forms.SplitContainer();

            this.grpPayments = new System.Windows.Forms.GroupBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();

            this.grpCosts = new System.Windows.Forms.GroupBox();
            this.tabCosts = new System.Windows.Forms.TabControl();
            this.tabSalary = new System.Windows.Forms.TabPage();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.tabImports = new System.Windows.Forms.TabPage();
            this.dgvImports = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.tlpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.grpCosts.SuspendLayout();
            this.tabCosts.SuspendLayout();
            this.tabSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.tabImports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImports)).BeginInit();
            this.SuspendLayout();

            // 
            // FrmRevenueProfitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRevenueProfitReport";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "FrmRevenueProfitReport";

            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 86;
            this.pnlTop.Controls.Add(this.grpFilters);

            // 
            // grpFilters
            // 
            this.grpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilters.BackColor = System.Drawing.Color.White;
            this.grpFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpFilters.Padding = new System.Windows.Forms.Padding(12);
            this.grpFilters.Text = "Thống kê doanh thu / lợi nhuận theo khoảng thời gian";
            this.grpFilters.Controls.Add(this.lblFrom);
            this.grpFilters.Controls.Add(this.dtFrom);
            this.grpFilters.Controls.Add(this.lblTo);
            this.grpFilters.Controls.Add(this.dtTo);
            this.grpFilters.Controls.Add(this.btnCalc);
            this.grpFilters.Controls.Add(this.btnExport);

            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrom.Location = new System.Drawing.Point(14, 38);
            this.lblFrom.Text = "Từ:";

            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(52, 34);
            this.dtFrom.Size = new System.Drawing.Size(150, 30);

            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTo.Location = new System.Drawing.Point(216, 38);
            this.lblTo.Text = "Đến:";

            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(265, 34);
            this.dtTo.Size = new System.Drawing.Size(150, 30);

            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCalc.Location = new System.Drawing.Point(435, 33);
            this.btnCalc.Size = new System.Drawing.Size(140, 32);
            this.btnCalc.Text = "Tính toán";

            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExport.Location = new System.Drawing.Point(585, 33);
            this.btnExport.Size = new System.Drawing.Size(160, 32);
            this.btnExport.Text = "Xuất Excel (.xlsx)";

            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.pnlMain.Controls.Add(this.splitMain);
            this.pnlMain.Controls.Add(this.grpSummary);

            // 
            // grpSummary
            // 
            this.grpSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSummary.Height = 130;
            this.grpSummary.BackColor = System.Drawing.Color.White;
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpSummary.Padding = new System.Windows.Forms.Padding(12);
            this.grpSummary.Text = "Tổng quan";
            this.grpSummary.Controls.Add(this.tlpSummary);

            // 
            // tlpSummary
            // 
            this.tlpSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSummary.ColumnCount = 4;
            this.tlpSummary.RowCount = 2;
            this.tlpSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));

            this.tlpSummary.Controls.Add(this.lblRevenueTitle, 0, 0);
            this.tlpSummary.Controls.Add(this.lblSalaryTitle, 1, 0);
            this.tlpSummary.Controls.Add(this.lblImportTitle, 2, 0);
            this.tlpSummary.Controls.Add(this.lblProfitTitle, 3, 0);

            this.tlpSummary.Controls.Add(this.lblRevenueValue, 0, 1);
            this.tlpSummary.Controls.Add(this.lblSalaryValue, 1, 1);
            this.tlpSummary.Controls.Add(this.lblImportValue, 2, 1);
            this.tlpSummary.Controls.Add(this.lblProfitValue, 3, 1);

            void TitleStyle(System.Windows.Forms.Label l, string text)
            {
                l.AutoSize = true;
                l.Font = new System.Drawing.Font("Segoe UI", 10F);
                l.Text = text;
            }

            void ValueStyle(System.Windows.Forms.Label l)
            {
                l.AutoSize = true;
                l.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
                l.Text = "0 ₫";
            }

            TitleStyle(this.lblRevenueTitle, "Doanh thu (Payments)");
            TitleStyle(this.lblSalaryTitle, "Chi phí lương");
            TitleStyle(this.lblImportTitle, "Chi phí nhập hàng");
            TitleStyle(this.lblProfitTitle, "Lợi nhuận");

            ValueStyle(this.lblRevenueValue);
            ValueStyle(this.lblSalaryValue);
            ValueStyle(this.lblImportValue);
            ValueStyle(this.lblProfitValue);

            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.SplitterDistance = 560;

            // 
            // grpPayments
            // 
            this.grpPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPayments.BackColor = System.Drawing.Color.White;
            this.grpPayments.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpPayments.Padding = new System.Windows.Forms.Padding(12);
            this.grpPayments.Text = "Chi tiết doanh thu (Payments)";
            this.grpPayments.Controls.Add(this.dgvPayments);

            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // grpCosts
            // 
            this.grpCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCosts.BackColor = System.Drawing.Color.White;
            this.grpCosts.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpCosts.Padding = new System.Windows.Forms.Padding(12);
            this.grpCosts.Text = "Chi tiết chi phí";
            this.grpCosts.Controls.Add(this.tabCosts);

            this.tabCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCosts.TabPages.Add(this.tabSalary);
            this.tabCosts.TabPages.Add(this.tabImports);

            this.tabSalary.Text = "Lương nhân viên";
            this.tabSalary.Controls.Add(this.dgvSalary);

            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.AllowUserToDeleteRows = false;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.tabImports.Text = "Nhập hàng";
            this.tabImports.Controls.Add(this.dgvImports);

            this.dgvImports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImports.ReadOnly = true;
            this.dgvImports.AllowUserToAddRows = false;
            this.dgvImports.AllowUserToDeleteRows = false;
            this.dgvImports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.splitMain.Panel1.Controls.Add(this.grpPayments);
            this.splitMain.Panel2.Controls.Add(this.grpCosts);

            this.pnlTop.ResumeLayout(false);
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.tlpSummary.ResumeLayout(false);
            this.tlpSummary.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.grpPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.grpCosts.ResumeLayout(false);
            this.tabCosts.ResumeLayout(false);
            this.tabSalary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.tabImports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImports)).EndInit();
            this.ResumeLayout(false);
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

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.TableLayoutPanel tlpSummary;

        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblSalaryTitle;
        private System.Windows.Forms.Label lblSalaryValue;
        private System.Windows.Forms.Label lblImportTitle;
        private System.Windows.Forms.Label lblImportValue;
        private System.Windows.Forms.Label lblProfitTitle;
        private System.Windows.Forms.Label lblProfitValue;

        private System.Windows.Forms.SplitContainer splitMain;

        private System.Windows.Forms.GroupBox grpPayments;
        private System.Windows.Forms.DataGridView dgvPayments;

        private System.Windows.Forms.GroupBox grpCosts;
        private System.Windows.Forms.TabControl tabCosts;
        private System.Windows.Forms.TabPage tabSalary;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.TabPage tabImports;
        private System.Windows.Forms.DataGridView dgvImports;
    }
}
