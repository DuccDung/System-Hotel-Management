using System.Drawing;
using System.Windows.Forms;
namespace SystemHotelManagement.View.Popup
{
    partial class FrmBookingPopup
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblRoom;
        private Panel pnlHeader;

        private GroupBox grpMode;
        private RadioButton rbHourly;
        private RadioButton rbOvernight;

        private GroupBox grpHourly;
        private Label lblHourlyStart;
        private Label lblHourlyEnd;
        private DateTimePicker dtHourlyStart;
        private DateTimePicker dtHourlyEnd;
        private CheckBox chkPayNow;

        private GroupBox grpOvernight;
        private Label lblOvernightCheckIn;
        private DateTimePicker dtOvernightCheckIn;
        private CheckBox chkOvernightHasExpectedCheckout;
        private DateTimePicker dtOvernightExpectedCheckout;
        private Label lblOvernightExpectedCheckoutHint;

        private Button btnConfirm;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblRoom = new Label();
            lblTitle = new Label();
            grpMode = new GroupBox();
            rbHourly = new RadioButton();
            rbOvernight = new RadioButton();
            grpHourly = new GroupBox();
            lblHourlyStart = new Label();
            dtHourlyStart = new DateTimePicker();
            lblHourlyEnd = new Label();
            dtHourlyEnd = new DateTimePicker();
            chkPayNow = new CheckBox();
            grpOvernight = new GroupBox();
            lblOvernightCheckIn = new Label();
            dtOvernightCheckIn = new DateTimePicker();
            chkOvernightHasExpectedCheckout = new CheckBox();
            dtOvernightExpectedCheckout = new DateTimePicker();
            lblOvernightExpectedCheckoutHint = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txt_cus_phone = new TextBox();
            label2 = new Label();
            txt_cus_name = new TextBox();
            label1 = new Label();
            pnlHeader.SuspendLayout();
            grpMode.SuspendLayout();
            grpHourly.SuspendLayout();
            grpOvernight.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 118, 210);
            pnlHeader.Controls.Add(lblRoom);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(640, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblRoom
            // 
            lblRoom.Dock = DockStyle.Fill;
            lblRoom.ForeColor = Color.White;
            lblRoom.Location = new Point(0, 40);
            lblRoom.Name = "lblRoom";
            lblRoom.Padding = new Padding(16, 0, 16, 8);
            lblRoom.Size = new Size(640, 30);
            lblRoom.TabIndex = 0;
            lblRoom.Text = "Phòng";
            lblRoom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(16, 0, 16, 0);
            lblTitle.Size = new Size(640, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Tạo booking";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpMode
            // 
            grpMode.Controls.Add(rbHourly);
            grpMode.Controls.Add(rbOvernight);
            grpMode.Location = new Point(16, 84);
            grpMode.Name = "grpMode";
            grpMode.Size = new Size(608, 80);
            grpMode.TabIndex = 1;
            grpMode.TabStop = false;
            grpMode.Text = "Chọn hình thức";
            // 
            // rbHourly
            // 
            rbHourly.AutoSize = true;
            rbHourly.Location = new Point(16, 28);
            rbHourly.Name = "rbHourly";
            rbHourly.Size = new Size(261, 27);
            rbHourly.TabIndex = 0;
            rbHourly.Text = "Thuê theo giờ (Giờ A → Giờ B)";
            // 
            // rbOvernight
            // 
            rbOvernight.AutoSize = true;
            rbOvernight.Location = new Point(16, 52);
            rbOvernight.Name = "rbOvernight";
            rbOvernight.Size = new Size(441, 27);
            rbOvernight.TabIndex = 1;
            rbOvernight.Text = "Nghỉ qua đêm (Check-in → Checkout khi khách rời đi)";
            // 
            // grpHourly
            // 
            grpHourly.Controls.Add(lblHourlyStart);
            grpHourly.Controls.Add(dtHourlyStart);
            grpHourly.Controls.Add(lblHourlyEnd);
            grpHourly.Controls.Add(dtHourlyEnd);
            grpHourly.Controls.Add(chkPayNow);
            grpHourly.Location = new Point(16, 176);
            grpHourly.Name = "grpHourly";
            grpHourly.Size = new Size(608, 150);
            grpHourly.TabIndex = 2;
            grpHourly.TabStop = false;
            grpHourly.Text = "Thuê theo giờ";
            // 
            // lblHourlyStart
            // 
            lblHourlyStart.AutoSize = true;
            lblHourlyStart.Location = new Point(16, 32);
            lblHourlyStart.Name = "lblHourlyStart";
            lblHourlyStart.Size = new Size(112, 23);
            lblHourlyStart.TabIndex = 0;
            lblHourlyStart.Text = "StartTime (A):";
            // 
            // dtHourlyStart
            // 
            dtHourlyStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dtHourlyStart.Format = DateTimePickerFormat.Custom;
            dtHourlyStart.Location = new Point(140, 28);
            dtHourlyStart.Name = "dtHourlyStart";
            dtHourlyStart.ShowUpDown = true;
            dtHourlyStart.Size = new Size(260, 30);
            dtHourlyStart.TabIndex = 1;
            // 
            // lblHourlyEnd
            // 
            lblHourlyEnd.AutoSize = true;
            lblHourlyEnd.Location = new Point(16, 68);
            lblHourlyEnd.Name = "lblHourlyEnd";
            lblHourlyEnd.Size = new Size(105, 23);
            lblHourlyEnd.TabIndex = 2;
            lblHourlyEnd.Text = "EndTime (B):";
            // 
            // dtHourlyEnd
            // 
            dtHourlyEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            dtHourlyEnd.Format = DateTimePickerFormat.Custom;
            dtHourlyEnd.Location = new Point(140, 64);
            dtHourlyEnd.Name = "dtHourlyEnd";
            dtHourlyEnd.ShowUpDown = true;
            dtHourlyEnd.Size = new Size(260, 30);
            dtHourlyEnd.TabIndex = 3;
            // 
            // chkPayNow
            // 
            chkPayNow.AutoSize = true;
            chkPayNow.Location = new Point(140, 102);
            chkPayNow.Name = "chkPayNow";
            chkPayNow.Size = new Size(499, 27);
            chkPayNow.TabIndex = 4;
            chkPayNow.Text = "Thanh toán luôn (mở popup thanh toán sau khi tạo booking)";
            // 
            // grpOvernight
            // 
            grpOvernight.Controls.Add(lblOvernightCheckIn);
            grpOvernight.Controls.Add(dtOvernightCheckIn);
            grpOvernight.Controls.Add(chkOvernightHasExpectedCheckout);
            grpOvernight.Controls.Add(dtOvernightExpectedCheckout);
            grpOvernight.Controls.Add(lblOvernightExpectedCheckoutHint);
            grpOvernight.Location = new Point(16, 336);
            grpOvernight.Name = "grpOvernight";
            grpOvernight.Size = new Size(608, 120);
            grpOvernight.TabIndex = 3;
            grpOvernight.TabStop = false;
            grpOvernight.Text = "Nghỉ qua đêm";
            // 
            // lblOvernightCheckIn
            // 
            lblOvernightCheckIn.AutoSize = true;
            lblOvernightCheckIn.Location = new Point(16, 32);
            lblOvernightCheckIn.Name = "lblOvernightCheckIn";
            lblOvernightCheckIn.Size = new Size(81, 23);
            lblOvernightCheckIn.TabIndex = 0;
            lblOvernightCheckIn.Text = "Check-in:";
            // 
            // dtOvernightCheckIn
            // 
            dtOvernightCheckIn.CustomFormat = "dd/MM/yyyy HH:mm";
            dtOvernightCheckIn.Format = DateTimePickerFormat.Custom;
            dtOvernightCheckIn.Location = new Point(140, 28);
            dtOvernightCheckIn.Name = "dtOvernightCheckIn";
            dtOvernightCheckIn.ShowUpDown = true;
            dtOvernightCheckIn.Size = new Size(260, 30);
            dtOvernightCheckIn.TabIndex = 1;
            // 
            // chkOvernightHasExpectedCheckout
            // 
            chkOvernightHasExpectedCheckout.AutoSize = true;
            chkOvernightHasExpectedCheckout.Location = new Point(140, 60);
            chkOvernightHasExpectedCheckout.Name = "chkOvernightHasExpectedCheckout";
            chkOvernightHasExpectedCheckout.Size = new Size(217, 27);
            chkOvernightHasExpectedCheckout.TabIndex = 2;
            chkOvernightHasExpectedCheckout.Text = "Có giờ checkout dự kiến";
            // 
            // dtOvernightExpectedCheckout
            // 
            dtOvernightExpectedCheckout.CustomFormat = "dd/MM/yyyy HH:mm";
            dtOvernightExpectedCheckout.Format = DateTimePickerFormat.Custom;
            dtOvernightExpectedCheckout.Location = new Point(360, 58);
            dtOvernightExpectedCheckout.Name = "dtOvernightExpectedCheckout";
            dtOvernightExpectedCheckout.ShowUpDown = true;
            dtOvernightExpectedCheckout.Size = new Size(240, 30);
            dtOvernightExpectedCheckout.TabIndex = 3;
            // 
            // lblOvernightExpectedCheckoutHint
            // 
            lblOvernightExpectedCheckoutHint.AutoSize = true;
            lblOvernightExpectedCheckoutHint.ForeColor = Color.FromArgb(90, 90, 90);
            lblOvernightExpectedCheckoutHint.Location = new Point(140, 88);
            lblOvernightExpectedCheckoutHint.Name = "lblOvernightExpectedCheckoutHint";
            lblOvernightExpectedCheckoutHint.Size = new Size(445, 23);
            lblOvernightExpectedCheckoutHint.TabIndex = 4;
            lblOvernightExpectedCheckoutHint.Text = "(Nếu không chọn, checkout sẽ thực hiện khi khách rời đi)";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(25, 118, 210);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(504, 605);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 38);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(210, 214, 220);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(33, 37, 41);
            btnCancel.Location = new Point(376, 605);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 38);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_cus_phone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_cus_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 479);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(90, 90, 90);
            label3.Location = new Point(313, 98);
            label3.Name = "label3";
            label3.Size = new Size(289, 23);
            label3.TabIndex = 5;
            label3.Text = "(Nhập thông tin khách hàng nếu có)";
            // 
            // txt_cus_phone
            // 
            txt_cus_phone.Location = new Point(82, 65);
            txt_cus_phone.Name = "txt_cus_phone";
            txt_cus_phone.Size = new Size(290, 30);
            txt_cus_phone.TabIndex = 3;
            txt_cus_phone.KeyPress += txt_cus_phone_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 2;
            label2.Text = "Phone:";
            // 
            // txt_cus_name
            // 
            txt_cus_name.Location = new Point(82, 29);
            txt_cus_name.Name = "txt_cus_name";
            txt_cus_name.Size = new Size(290, 30);
            txt_cus_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // FrmBookingPopup
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(640, 655);
            Controls.Add(groupBox1);
            Controls.Add(pnlHeader);
            Controls.Add(grpMode);
            Controls.Add(grpHourly);
            Controls.Add(grpOvernight);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBookingPopup";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Booking phòng";
            pnlHeader.ResumeLayout(false);
            grpMode.ResumeLayout(false);
            grpMode.PerformLayout();
            grpHourly.ResumeLayout(false);
            grpHourly.PerformLayout();
            grpOvernight.ResumeLayout(false);
            grpOvernight.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private TextBox txt_cus_phone;
        private Label label2;
        private TextBox txt_cus_name;
    }
}

