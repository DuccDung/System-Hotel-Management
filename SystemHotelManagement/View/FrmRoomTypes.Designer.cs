namespace SystemHotelManagement.View
{
    partial class FrmRoomTypes
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
            grpSearch = new GroupBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            splitMain = new SplitContainer();
            grpForm = new GroupBox();
            tlpForm = new TableLayoutPanel();
            lblTypeName = new Label();
            txtTypeName = new TextBox();
            lblBasePrice = new Label();
            numBasePrice = new NumericUpDown();
            lblCapacity = new Label();
            numCapacity = new NumericUpDown();
            lblNote = new Label();
            txtNote = new TextBox();
            pnlButtons = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpList = new GroupBox();
            dgvRoomTypes = new DataGridView();
            pnlTop.SuspendLayout();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpForm.SuspendLayout();
            tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBasePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            pnlButtons.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypes).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(grpSearch);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(16, 16);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1048, 70);
            pnlTop.TabIndex = 1;
            // 
            // grpSearch
            // 
            grpSearch.BackColor = Color.White;
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(lblSearch);
            grpSearch.Dock = DockStyle.Fill;
            grpSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpSearch.Location = new Point(0, 0);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(12);
            grpSearch.Size = new Size(1048, 70);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(60, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(360, 30);
            txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(14, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Tìm:";
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(16, 86);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(grpForm);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(grpList);
            splitMain.Size = new Size(1048, 578);
            splitMain.SplitterDistance = 624;
            splitMain.TabIndex = 0;
            // 
            // grpForm
            // 
            grpForm.BackColor = Color.White;
            grpForm.Controls.Add(tlpForm);
            grpForm.Controls.Add(pnlButtons);
            grpForm.Dock = DockStyle.Fill;
            grpForm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpForm.Location = new Point(0, 0);
            grpForm.Name = "grpForm";
            grpForm.Padding = new Padding(12);
            grpForm.Size = new Size(624, 578);
            grpForm.TabIndex = 0;
            grpForm.TabStop = false;
            grpForm.Text = "Thông tin loại phòng";
            // 
            // tlpForm
            // 
            tlpForm.ColumnCount = 2;
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForm.Controls.Add(lblTypeName, 0, 0);
            tlpForm.Controls.Add(txtTypeName, 1, 0);
            tlpForm.Controls.Add(lblBasePrice, 0, 1);
            tlpForm.Controls.Add(numBasePrice, 1, 1);
            tlpForm.Controls.Add(lblCapacity, 0, 2);
            tlpForm.Controls.Add(numCapacity, 1, 2);
            tlpForm.Controls.Add(lblNote, 0, 3);
            tlpForm.Controls.Add(txtNote, 1, 3);
            tlpForm.Dock = DockStyle.Fill;
            tlpForm.Location = new Point(12, 35);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 4;
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpForm.Size = new Size(600, 477);
            tlpForm.TabIndex = 0;
            // 
            // lblTypeName
            // 
            lblTypeName.Anchor = AnchorStyles.Left;
            lblTypeName.AutoSize = true;
            lblTypeName.Font = new Font("Segoe UI", 10F);
            lblTypeName.Location = new Point(3, 10);
            lblTypeName.Name = "lblTypeName";
            lblTypeName.Size = new Size(68, 23);
            lblTypeName.TabIndex = 0;
            lblTypeName.Text = "Tên loại";
            // 
            // txtTypeName
            // 
            txtTypeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTypeName.Font = new Font("Segoe UI", 10F);
            txtTypeName.Location = new Point(123, 7);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(474, 30);
            txtTypeName.TabIndex = 1;
            // 
            // lblBasePrice
            // 
            lblBasePrice.Anchor = AnchorStyles.Left;
            lblBasePrice.AutoSize = true;
            lblBasePrice.Font = new Font("Segoe UI", 10F);
            lblBasePrice.Location = new Point(3, 54);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(92, 23);
            lblBasePrice.TabIndex = 2;
            lblBasePrice.Text = "Giá cơ bản";
            // 
            // numBasePrice
            // 
            numBasePrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numBasePrice.Location = new Point(123, 51);
            numBasePrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numBasePrice.Name = "numBasePrice";
            numBasePrice.Size = new Size(474, 30);
            numBasePrice.TabIndex = 3;
            numBasePrice.ThousandsSeparator = true;
            // 
            // lblCapacity
            // 
            lblCapacity.Anchor = AnchorStyles.Left;
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 10F);
            lblCapacity.Location = new Point(3, 98);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(79, 23);
            lblCapacity.TabIndex = 4;
            lblCapacity.Text = "Sức chứa";
            // 
            // numCapacity
            // 
            numCapacity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numCapacity.Location = new Point(123, 95);
            numCapacity.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(474, 30);
            numCapacity.TabIndex = 5;
            // 
            // lblNote
            // 
            lblNote.Anchor = AnchorStyles.Left;
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 10F);
            lblNote.Location = new Point(3, 293);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(69, 23);
            lblNote.TabIndex = 6;
            lblNote.Text = "Ghi chú";
            // 
            // txtNote
            // 
            txtNote.Dock = DockStyle.Fill;
            txtNote.Font = new Font("Segoe UI", 10F);
            txtNote.Location = new Point(123, 135);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(474, 339);
            txtNote.TabIndex = 7;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(12, 512);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(0, 10, 0, 0);
            pnlButtons.Size = new Size(600, 54);
            pnlButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(98, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(196, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(294, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm";
            // 
            // grpList
            // 
            grpList.BackColor = Color.White;
            grpList.Controls.Add(dgvRoomTypes);
            grpList.Dock = DockStyle.Fill;
            grpList.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpList.Location = new Point(0, 0);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(12);
            grpList.Size = new Size(420, 578);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "Danh sách loại phòng";
            // 
            // dgvRoomTypes
            // 
            dgvRoomTypes.AllowUserToAddRows = false;
            dgvRoomTypes.AllowUserToDeleteRows = false;
            dgvRoomTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomTypes.ColumnHeadersHeight = 29;
            dgvRoomTypes.Dock = DockStyle.Fill;
            dgvRoomTypes.Location = new Point(12, 35);
            dgvRoomTypes.Name = "dgvRoomTypes";
            dgvRoomTypes.ReadOnly = true;
            dgvRoomTypes.RowHeadersWidth = 51;
            dgvRoomTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoomTypes.Size = new Size(396, 531);
            dgvRoomTypes.TabIndex = 0;
            // 
            // FrmRoomTypes
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1080, 680);
            Controls.Add(splitMain);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRoomTypes";
            Padding = new Padding(16);
            Text = "FrmRoomTypes";
            pnlTop.ResumeLayout(false);
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpForm.ResumeLayout(false);
            tlpForm.ResumeLayout(false);
            tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBasePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            pnlButtons.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.SplitContainer splitMain;

        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.NumericUpDown numBasePrice;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvRoomTypes;
    }
}
