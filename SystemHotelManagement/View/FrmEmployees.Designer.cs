namespace SystemHotelManagement.View
{
    partial class FrmEmployees
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
            tlpTop = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            chkOnlyActive = new CheckBox();
            splitMain = new SplitContainer();
            grpInfo = new GroupBox();
            tlpInfo = new TableLayoutPanel();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblHired = new Label();
            dtHired = new DateTimePicker();
            lblActive = new Label();
            chkIsActive = new CheckBox();
            pnlButtons = new Panel();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpList = new GroupBox();
            dgvEmployees = new DataGridView();
            pnlTop.SuspendLayout();
            tlpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpInfo.SuspendLayout();
            tlpInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            flpButtons.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(248, 250, 252);
            pnlTop.Controls.Add(tlpTop);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(16, 16);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1048, 52);
            pnlTop.TabIndex = 0;
            // 
            // tlpTop
            // 
            tlpTop.ColumnCount = 3;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tlpTop.Controls.Add(lblSearch, 0, 0);
            tlpTop.Controls.Add(txtSearch, 1, 0);
            tlpTop.Controls.Add(chkOnlyActive, 2, 0);
            tlpTop.Dock = DockStyle.Fill;
            tlpTop.Location = new Point(0, 0);
            tlpTop.Name = "tlpTop";
            tlpTop.RowCount = 1;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTop.Size = new Size(1048, 52);
            tlpTop.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(3, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(53, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(712, 30);
            txtSearch.TabIndex = 1;
            // 
            // chkOnlyActive
            // 
            chkOnlyActive.Anchor = AnchorStyles.Left;
            chkOnlyActive.AutoSize = true;
            chkOnlyActive.Location = new Point(771, 12);
            chkOnlyActive.Name = "chkOnlyActive";
            chkOnlyActive.Size = new Size(266, 27);
            chkOnlyActive.TabIndex = 2;
            chkOnlyActive.Text = "Chỉ nhân viên đang hoạt động";
            chkOnlyActive.UseVisualStyleBackColor = true;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(16, 68);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.BackColor = Color.FromArgb(248, 250, 252);
            splitMain.Panel1.Controls.Add(grpInfo);
            splitMain.Panel1.Padding = new Padding(0, 10, 10, 0);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.BackColor = Color.FromArgb(248, 250, 252);
            splitMain.Panel2.Controls.Add(grpList);
            splitMain.Panel2.Padding = new Padding(10, 10, 0, 0);
            splitMain.Size = new Size(1048, 596);
            splitMain.SplitterDistance = 409;
            splitMain.TabIndex = 1;
            // 
            // grpInfo
            // 
            grpInfo.BackColor = Color.White;
            grpInfo.Controls.Add(tlpInfo);
            grpInfo.Controls.Add(pnlButtons);
            grpInfo.Dock = DockStyle.Fill;
            grpInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpInfo.Location = new Point(0, 10);
            grpInfo.Name = "grpInfo";
            grpInfo.Padding = new Padding(12);
            grpInfo.Size = new Size(399, 586);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin nhân viên";
            // 
            // tlpInfo
            // 
            tlpInfo.ColumnCount = 2;
            tlpInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tlpInfo.Controls.Add(lblFullName, 0, 0);
            tlpInfo.Controls.Add(txtFullName, 1, 0);
            tlpInfo.Controls.Add(lblPhone, 0, 1);
            tlpInfo.Controls.Add(txtPhone, 1, 1);
            tlpInfo.Controls.Add(lblEmail, 0, 2);
            tlpInfo.Controls.Add(txtEmail, 1, 2);
            tlpInfo.Controls.Add(lblRole, 0, 3);
            tlpInfo.Controls.Add(cboRole, 1, 3);
            tlpInfo.Controls.Add(lblHired, 0, 4);
            tlpInfo.Controls.Add(dtHired, 1, 4);
            tlpInfo.Controls.Add(lblActive, 0, 5);
            tlpInfo.Controls.Add(chkIsActive, 1, 5);
            tlpInfo.Dock = DockStyle.Fill;
            tlpInfo.Location = new Point(12, 35);
            tlpInfo.Name = "tlpInfo";
            tlpInfo.RowCount = 7;
            tlpInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInfo.Size = new Size(375, 481);
            tlpInfo.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Left;
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.Location = new Point(3, 10);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(62, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Họ tên";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(123, 7);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(249, 30);
            txtFullName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(3, 54);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(40, 23);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "SĐT";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(123, 51);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(249, 30);
            txtPhone.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(3, 98);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(123, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 30);
            txtEmail.TabIndex = 5;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Left;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F);
            lblRole.Location = new Point(3, 142);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(60, 23);
            lblRole.TabIndex = 6;
            lblRole.Text = "Vai trò";
            // 
            // cboRole
            // 
            cboRole.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Font = new Font("Segoe UI", 10F);
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(123, 138);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(249, 31);
            cboRole.TabIndex = 7;
            // 
            // lblHired
            // 
            lblHired.Anchor = AnchorStyles.Left;
            lblHired.AutoSize = true;
            lblHired.Font = new Font("Segoe UI", 10F);
            lblHired.Location = new Point(3, 186);
            lblHired.Name = "lblHired";
            lblHired.Size = new Size(82, 23);
            lblHired.TabIndex = 8;
            lblHired.Text = "Ngày vào";
            // 
            // dtHired
            // 
            dtHired.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtHired.Font = new Font("Segoe UI", 10F);
            dtHired.Format = DateTimePickerFormat.Short;
            dtHired.Location = new Point(123, 183);
            dtHired.Name = "dtHired";
            dtHired.Size = new Size(249, 30);
            dtHired.TabIndex = 9;
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI", 10F);
            lblActive.Location = new Point(3, 230);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(87, 23);
            lblActive.TabIndex = 10;
            lblActive.Text = "Trạng thái";
            // 
            // chkIsActive
            // 
            chkIsActive.Anchor = AnchorStyles.Left;
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 10F);
            chkIsActive.Location = new Point(123, 228);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(158, 27);
            chkIsActive.TabIndex = 11;
            chkIsActive.Text = "Đang hoạt động";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(flpButtons);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(12, 516);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(375, 58);
            pnlButtons.TabIndex = 1;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(btnUpdate);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnClear);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.Location = new Point(0, 0);
            flpButtons.Name = "flpButtons";
            flpButtons.Padding = new Padding(0, 8, 0, 0);
            flpButtons.Size = new Size(375, 58);
            flpButtons.TabIndex = 0;
            flpButtons.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.Location = new Point(0, 8);
            btnAdd.Margin = new Padding(0, 0, 10, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10F);
            btnUpdate.Location = new Point(96, 8);
            btnUpdate.Margin = new Padding(0, 0, 10, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 36);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.Location = new Point(192, 8);
            btnDelete.Margin = new Padding(0, 0, 10, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(288, 8);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 36);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // grpList
            // 
            grpList.BackColor = Color.White;
            grpList.Controls.Add(dgvEmployees);
            grpList.Dock = DockStyle.Fill;
            grpList.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpList.Location = new Point(10, 10);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(12);
            grpList.Size = new Size(625, 586);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "Danh sách nhân viên";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.Location = new Point(12, 35);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(601, 539);
            dgvEmployees.TabIndex = 0;
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1080, 680);
            Controls.Add(splitMain);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmployees";
            Padding = new Padding(16);
            Text = "FrmEmployees";
            pnlTop.ResumeLayout(false);
            tlpTop.ResumeLayout(false);
            tlpTop.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            tlpInfo.ResumeLayout(false);
            tlpInfo.PerformLayout();
            pnlButtons.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkOnlyActive;

        private System.Windows.Forms.SplitContainer splitMain;

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblHired;
        private System.Windows.Forms.DateTimePicker dtHired;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox chkIsActive;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}
