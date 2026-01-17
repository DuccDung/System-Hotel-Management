namespace SystemHotelManagement.View
{
    partial class FrmRooms
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
            chkActiveOnly = new CheckBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            splitMain = new SplitContainer();
            grpForm = new GroupBox();
            tlpForm = new TableLayoutPanel();
            lblRoomCode = new Label();
            txtRoomCode = new TextBox();
            lblRoomType = new Label();
            cboRoomType = new ComboBox();
            lblFloor = new Label();
            numFloor = new NumericUpDown();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            chkIsActive = new CheckBox();
            lblNote = new Label();
            txtNote = new TextBox();
            pnlButtons = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpList = new GroupBox();
            dgvRooms = new DataGridView();
            pnlTop.SuspendLayout();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpForm.SuspendLayout();
            tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFloor).BeginInit();
            pnlButtons.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
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
            grpSearch.Controls.Add(chkActiveOnly);
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
            // chkActiveOnly
            // 
            chkActiveOnly.AutoSize = true;
            chkActiveOnly.Font = new Font("Segoe UI", 10F);
            chkActiveOnly.Location = new Point(440, 31);
            chkActiveOnly.Name = "chkActiveOnly";
            chkActiveOnly.Size = new Size(241, 27);
            chkActiveOnly.TabIndex = 0;
            chkActiveOnly.Text = "Chỉ phòng đang hoạt động";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(60, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(360, 30);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.Location = new Point(14, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 23);
            lblSearch.TabIndex = 2;
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
            splitMain.SplitterDistance = 530;
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
            grpForm.Size = new Size(530, 578);
            grpForm.TabIndex = 0;
            grpForm.TabStop = false;
            grpForm.Text = "Thông tin phòng";
            // 
            // tlpForm
            // 
            tlpForm.ColumnCount = 2;
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForm.Controls.Add(lblRoomCode, 0, 0);
            tlpForm.Controls.Add(txtRoomCode, 1, 0);
            tlpForm.Controls.Add(lblRoomType, 0, 1);
            tlpForm.Controls.Add(cboRoomType, 1, 1);
            tlpForm.Controls.Add(lblFloor, 0, 2);
            tlpForm.Controls.Add(numFloor, 1, 2);
            tlpForm.Controls.Add(lblStatus, 0, 3);
            tlpForm.Controls.Add(cboStatus, 1, 3);
            tlpForm.Controls.Add(chkIsActive, 1, 4);
            tlpForm.Controls.Add(lblNote, 0, 5);
            tlpForm.Controls.Add(txtNote, 1, 5);
            tlpForm.Dock = DockStyle.Fill;
            tlpForm.Location = new Point(12, 35);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 6;
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpForm.Size = new Size(506, 477);
            tlpForm.TabIndex = 0;
            // 
            // lblRoomCode
            // 
            lblRoomCode.Anchor = AnchorStyles.Left;
            lblRoomCode.AutoSize = true;
            lblRoomCode.Font = new Font("Segoe UI", 10F);
            lblRoomCode.Location = new Point(3, 10);
            lblRoomCode.Name = "lblRoomCode";
            lblRoomCode.Size = new Size(89, 23);
            lblRoomCode.TabIndex = 0;
            lblRoomCode.Text = "Mã phòng";
            // 
            // txtRoomCode
            // 
            txtRoomCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRoomCode.Font = new Font("Segoe UI", 10F);
            txtRoomCode.Location = new Point(123, 7);
            txtRoomCode.Name = "txtRoomCode";
            txtRoomCode.Size = new Size(380, 30);
            txtRoomCode.TabIndex = 1;
            // 
            // lblRoomType
            // 
            lblRoomType.Anchor = AnchorStyles.Left;
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 10F);
            lblRoomType.Location = new Point(3, 54);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(96, 23);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "Loại phòng";
            // 
            // cboRoomType
            // 
            cboRoomType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomType.Font = new Font("Segoe UI", 10F);
            cboRoomType.Location = new Point(123, 52);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(380, 31);
            cboRoomType.TabIndex = 3;
            // 
            // lblFloor
            // 
            lblFloor.Anchor = AnchorStyles.Left;
            lblFloor.AutoSize = true;
            lblFloor.Font = new Font("Segoe UI", 10F);
            lblFloor.Location = new Point(3, 98);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(48, 23);
            lblFloor.TabIndex = 4;
            lblFloor.Text = "Tầng";
            // 
            // numFloor
            // 
            numFloor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numFloor.Location = new Point(123, 95);
            numFloor.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numFloor.Name = "numFloor";
            numFloor.Size = new Size(380, 30);
            numFloor.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(3, 142);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(87, 23);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Trạng thái";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 10F);
            cboStatus.Location = new Point(123, 140);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(380, 31);
            cboStatus.TabIndex = 7;
            // 
            // chkIsActive
            // 
            chkIsActive.Anchor = AnchorStyles.Left;
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 10F);
            chkIsActive.Location = new Point(123, 184);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(158, 27);
            chkIsActive.TabIndex = 8;
            chkIsActive.Text = "Đang hoạt động";
            // 
            // lblNote
            // 
            lblNote.Anchor = AnchorStyles.Left;
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 10F);
            lblNote.Location = new Point(3, 337);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(69, 23);
            lblNote.TabIndex = 9;
            lblNote.Text = "Ghi chú";
            // 
            // txtNote
            // 
            txtNote.Dock = DockStyle.Fill;
            txtNote.Font = new Font("Segoe UI", 10F);
            txtNote.Location = new Point(123, 223);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(380, 251);
            txtNote.TabIndex = 10;
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
            pnlButtons.Size = new Size(506, 54);
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
            grpList.Controls.Add(dgvRooms);
            grpList.Dock = DockStyle.Fill;
            grpList.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpList.Location = new Point(0, 0);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(12);
            grpList.Size = new Size(514, 578);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "Danh sách phòng";
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.ColumnHeadersHeight = 29;
            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.Location = new Point(12, 35);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(490, 531);
            dgvRooms.TabIndex = 0;
            // 
            // FrmRooms
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1080, 680);
            Controls.Add(splitMain);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRooms";
            Padding = new Padding(16);
            Text = "FrmRooms";
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
            ((System.ComponentModel.ISupportInitialize)numFloor).EndInit();
            pnlButtons.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkActiveOnly;

        private System.Windows.Forms.SplitContainer splitMain;

        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.Label lblRoomCode;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.NumericUpDown numFloor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvRooms;
    }
}
