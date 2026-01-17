namespace SystemHotelManagement.View
{
    partial class FrmAttendanceDaily
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
            this.grpTop = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtWorkDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();

            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();

            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();

            this.pnlTop.SuspendLayout();
            this.grpTop.SuspendLayout();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // 
            // FrmAttendanceDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.Controls.Add(this.grpGrid);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAttendanceDaily";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "FrmAttendanceDaily";

            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 86;
            this.pnlTop.Controls.Add(this.grpTop);

            // 
            // grpTop
            // 
            this.grpTop.BackColor = System.Drawing.Color.White;
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTop.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpTop.Padding = new System.Windows.Forms.Padding(12);
            this.grpTop.Text = "Chọn ngày chấm công";
            this.grpTop.Controls.Add(this.lblDate);
            this.grpTop.Controls.Add(this.dtWorkDate);
            this.grpTop.Controls.Add(this.btnLoad);

            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.Location = new System.Drawing.Point(14, 38);
            this.lblDate.Text = "Ngày:";

            // 
            // dtWorkDate
            // 
            this.dtWorkDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWorkDate.Location = new System.Drawing.Point(70, 34);
            this.dtWorkDate.Size = new System.Drawing.Size(160, 30);

            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoad.Location = new System.Drawing.Point(240, 33);
            this.btnLoad.Size = new System.Drawing.Size(120, 32);
            this.btnLoad.Text = "Tải danh sách";

            // 
            // grpGrid
            // 
            this.grpGrid.BackColor = System.Drawing.Color.White;
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGrid.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpGrid.Padding = new System.Windows.Forms.Padding(12);
            this.grpGrid.Text = "Chấm công theo ngày (tick đi làm)";
            this.grpGrid.Controls.Add(this.dgvAttendance);

            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height = 64;
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(12);
            this.pnlBottom.Controls.Add(this.btnSave);

            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Location = new System.Drawing.Point(930, 14);
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.Text = "Lưu chấm công";

            this.pnlTop.ResumeLayout(false);
            this.grpTop.ResumeLayout(false);
            this.grpTop.PerformLayout();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtWorkDate;
        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.DataGridView dgvAttendance;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnSave;
    }
}
