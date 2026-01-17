namespace SystemHotelManagement.View
{
    partial class FrmStockImport
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
            grpHeader = new GroupBox();
            tlpHeader = new TableLayoutPanel();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblImportDate = new Label();
            dtImportDate = new DateTimePicker();
            lblSupplierPhone = new Label();
            txtSupplierPhone = new TextBox();
            lblEmployee = new Label();
            cboEmployee = new ComboBox();
            lblNote = new Label();
            txtNote = new TextBox();
            pnlMain = new Panel();
            grpItems = new GroupBox();
            dgvItems = new DataGridView();
            pnlBottom = new Panel();
            lblTotalText = new Label();
            lblTotalAmount = new Label();
            btnRemoveRow = new Button();
            btnClear = new Button();
            btnSave = new Button();
            pnlTop.SuspendLayout();
            grpHeader.SuspendLayout();
            tlpHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(grpHeader);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(16, 16);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1048, 180);
            pnlTop.TabIndex = 2;
            // 
            // grpHeader
            // 
            grpHeader.BackColor = Color.White;
            grpHeader.Controls.Add(tlpHeader);
            grpHeader.Dock = DockStyle.Fill;
            grpHeader.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpHeader.Location = new Point(0, 0);
            grpHeader.Name = "grpHeader";
            grpHeader.Padding = new Padding(12);
            grpHeader.Size = new Size(1048, 180);
            grpHeader.TabIndex = 0;
            grpHeader.TabStop = false;
            grpHeader.Text = "Thông tin phiếu nhập";
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 4;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHeader.Controls.Add(lblSupplierName, 0, 0);
            tlpHeader.Controls.Add(txtSupplierName, 1, 0);
            tlpHeader.Controls.Add(lblImportDate, 2, 0);
            tlpHeader.Controls.Add(dtImportDate, 3, 0);
            tlpHeader.Controls.Add(lblSupplierPhone, 0, 1);
            tlpHeader.Controls.Add(txtSupplierPhone, 1, 1);
            tlpHeader.Controls.Add(lblEmployee, 2, 1);
            tlpHeader.Controls.Add(cboEmployee, 3, 1);
            tlpHeader.Controls.Add(lblNote, 0, 2);
            tlpHeader.Controls.Add(txtNote, 1, 2);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(12, 35);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 3;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1024, 133);
            tlpHeader.TabIndex = 0;
            // 
            // lblSupplierName
            // 
            lblSupplierName.Anchor = AnchorStyles.Left;
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 10F);
            lblSupplierName.Location = new Point(3, 10);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(117, 23);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "Nhà cung cấp";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSupplierName.Font = new Font("Segoe UI", 10F);
            txtSupplierName.Location = new Point(143, 7);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(366, 30);
            txtSupplierName.TabIndex = 1;
            // 
            // lblImportDate
            // 
            lblImportDate.Anchor = AnchorStyles.Left;
            lblImportDate.AutoSize = true;
            lblImportDate.Font = new Font("Segoe UI", 10F);
            lblImportDate.Location = new Point(515, 10);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(94, 23);
            lblImportDate.TabIndex = 2;
            lblImportDate.Text = "Ngày nhập";
            // 
            // dtImportDate
            // 
            dtImportDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtImportDate.Font = new Font("Segoe UI", 10F);
            dtImportDate.Format = DateTimePickerFormat.Short;
            dtImportDate.Location = new Point(655, 7);
            dtImportDate.Name = "dtImportDate";
            dtImportDate.Size = new Size(366, 30);
            dtImportDate.TabIndex = 3;
            // 
            // lblSupplierPhone
            // 
            lblSupplierPhone.Anchor = AnchorStyles.Left;
            lblSupplierPhone.AutoSize = true;
            lblSupplierPhone.Font = new Font("Segoe UI", 10F);
            lblSupplierPhone.Location = new Point(3, 54);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(80, 23);
            lblSupplierPhone.TabIndex = 4;
            lblSupplierPhone.Text = "SĐT NCC";
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSupplierPhone.Font = new Font("Segoe UI", 10F);
            txtSupplierPhone.Location = new Point(143, 51);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(366, 30);
            txtSupplierPhone.TabIndex = 5;
            // 
            // lblEmployee
            // 
            lblEmployee.Anchor = AnchorStyles.Left;
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Segoe UI", 10F);
            lblEmployee.Location = new Point(515, 54);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(132, 23);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "Nhân viên nhập";
            // 
            // cboEmployee
            // 
            cboEmployee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployee.Font = new Font("Segoe UI", 10F);
            cboEmployee.Location = new Point(655, 50);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(366, 31);
            cboEmployee.TabIndex = 7;
            // 
            // lblNote
            // 
            lblNote.Anchor = AnchorStyles.Left;
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 10F);
            lblNote.Location = new Point(3, 99);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(69, 23);
            lblNote.TabIndex = 8;
            lblNote.Text = "Ghi chú";
            // 
            // txtNote
            // 
            tlpHeader.SetColumnSpan(txtNote, 3);
            txtNote.Dock = DockStyle.Fill;
            txtNote.Font = new Font("Segoe UI", 10F);
            txtNote.Location = new Point(143, 91);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(878, 39);
            txtNote.TabIndex = 9;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(grpItems);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(16, 196);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(0, 12, 0, 12);
            pnlMain.Size = new Size(1048, 404);
            pnlMain.TabIndex = 0;
            // 
            // grpItems
            // 
            grpItems.BackColor = Color.White;
            grpItems.Controls.Add(dgvItems);
            grpItems.Dock = DockStyle.Fill;
            grpItems.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpItems.Location = new Point(0, 12);
            grpItems.Name = "grpItems";
            grpItems.Padding = new Padding(12);
            grpItems.Size = new Size(1048, 380);
            grpItems.TabIndex = 0;
            grpItems.TabStop = false;
            grpItems.Text = "Danh sách hàng nhập";
            // 
            // dgvItems
            // 
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeight = 29;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(12, 35);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1024, 333);
            dgvItems.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotalText);
            pnlBottom.Controls.Add(lblTotalAmount);
            pnlBottom.Controls.Add(btnRemoveRow);
            pnlBottom.Controls.Add(btnClear);
            pnlBottom.Controls.Add(btnSave);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(16, 600);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(12);
            pnlBottom.Size = new Size(1048, 64);
            pnlBottom.TabIndex = 1;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalText.Location = new Point(15, 23);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(98, 25);
            lblTotalText.TabIndex = 0;
            lblTotalText.Text = "Tổng tiền:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(109, 20);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(41, 28);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "0 ₫";
            lblTotalAmount.Click += lblTotalAmount_Click;
            // 
            // btnRemoveRow
            // 
            btnRemoveRow.Anchor = AnchorStyles.Right;
            btnRemoveRow.Font = new Font("Segoe UI", 10F);
            btnRemoveRow.Location = new Point(585, 20);
            btnRemoveRow.Name = "btnRemoveRow";
            btnRemoveRow.Size = new Size(140, 36);
            btnRemoveRow.TabIndex = 2;
            btnRemoveRow.Text = "Xóa dòng chọn";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(885, 20);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 36);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.Location = new Point(731, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 36);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu phiếu";
            // 
            // FrmStockImport
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1080, 680);
            Controls.Add(pnlMain);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStockImport";
            Padding = new Padding(16);
            Text = "FrmStockImport";
            pnlTop.ResumeLayout(false);
            grpHeader.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            tlpHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            grpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.Label lblImportDate;
        private System.Windows.Forms.DateTimePicker dtImportDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.DataGridView dgvItems;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}
