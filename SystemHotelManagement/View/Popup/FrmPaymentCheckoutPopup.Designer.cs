namespace SystemHotelManagement.View.Popup
{
    using System.Drawing;
    using System.Windows.Forms;
        partial class FrmPaymentCheckoutPopup
        {
            private System.ComponentModel.IContainer components = null;

            private Panel pnlHeader;
            private Label lblTitle;
            private Label lblRoom;

            private GroupBox grpCustomer;
            private Label lblCustomerNameTitle;
            internal Label lblCustomerName;
            private Label lblCustomerPhoneTitle;
            internal Label lblCustomerPhone;

            private GroupBox grpBooking;
            private Label lblBookingIdTitle;
            internal Label lblBookingId;
            private Label lblBookingCodeTitle;
            internal Label lblBookingCode;
            private Label lblBookingTypeTitle;
            internal Label lblBookingType;

            private GroupBox grpTime;
            private Label lblCheckInTitle;
            internal DateTimePicker dtCheckIn;
            private Label lblCheckoutTitle;
            internal DateTimePicker dtCheckout;
            internal CheckBox chkCheckoutNow;

            private GroupBox grpCalc;
            private Label lblHourlyRateTitle;
            internal TextBox txtHourlyRate;
            private Label lblUsedTimeTitle;
            internal Label lblUsedTime;
            private Label lblBilledHoursTitle;
            internal Label lblBilledHours;
            private Label lblTotalTitle;
            internal Label lblTotal;

            private GroupBox grpPreview;
            private Label lblCheckInTextTitle;
            internal Label lblCheckInText;
            private Label lblCheckoutTextTitle;
            internal Label lblCheckoutText;

            internal Button btnCheckout;
            internal Button btnCancel;

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
            grpCustomer = new GroupBox();
            lblCustomerNameTitle = new Label();
            lblCustomerName = new Label();
            lblCustomerPhoneTitle = new Label();
            lblCustomerPhone = new Label();
            grpBooking = new GroupBox();
            lblBookingIdTitle = new Label();
            lblBookingId = new Label();
            lblBookingCodeTitle = new Label();
            lblBookingCode = new Label();
            lblBookingTypeTitle = new Label();
            lblBookingType = new Label();
            grpTime = new GroupBox();
            lblCheckInTitle = new Label();
            dtCheckIn = new DateTimePicker();
            lblCheckoutTitle = new Label();
            dtCheckout = new DateTimePicker();
            chkCheckoutNow = new CheckBox();
            grpCalc = new GroupBox();
            lblHourlyRateTitle = new Label();
            txtHourlyRate = new TextBox();
            lblUsedTimeTitle = new Label();
            lblUsedTime = new Label();
            lblBilledHoursTitle = new Label();
            lblBilledHours = new Label();
            lblTotalTitle = new Label();
            lblTotal = new Label();
            grpPreview = new GroupBox();
            lblCheckInTextTitle = new Label();
            lblCheckInText = new Label();
            lblCheckoutTextTitle = new Label();
            lblCheckoutText = new Label();
            btnCheckout = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            grpCustomer.SuspendLayout();
            grpBooking.SuspendLayout();
            grpTime.SuspendLayout();
            grpCalc.SuspendLayout();
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
            pnlHeader.Size = new Size(764, 72);
            pnlHeader.TabIndex = 0;
            // 
            // lblRoom
            // 
            lblRoom.Dock = DockStyle.Fill;
            lblRoom.ForeColor = Color.White;
            lblRoom.Location = new Point(0, 40);
            lblRoom.Name = "lblRoom";
            lblRoom.Padding = new Padding(16, 0, 16, 10);
            lblRoom.Size = new Size(764, 32);
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
            lblTitle.Size = new Size(764, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Thanh toán & Checkout";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(lblCustomerNameTitle);
            grpCustomer.Controls.Add(lblCustomerName);
            grpCustomer.Controls.Add(lblCustomerPhoneTitle);
            grpCustomer.Controls.Add(lblCustomerPhone);
            grpCustomer.Location = new Point(16, 88);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(728, 90);
            grpCustomer.TabIndex = 1;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Thông tin khách hàng";
            // 
            // lblCustomerNameTitle
            // 
            lblCustomerNameTitle.AutoSize = true;
            lblCustomerNameTitle.Location = new Point(16, 32);
            lblCustomerNameTitle.Name = "lblCustomerNameTitle";
            lblCustomerNameTitle.Size = new Size(90, 23);
            lblCustomerNameTitle.TabIndex = 0;
            lblCustomerNameTitle.Text = "Tên khách:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCustomerName.Location = new Point(110, 32);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(27, 23);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "—";
            // 
            // lblCustomerPhoneTitle
            // 
            lblCustomerPhoneTitle.AutoSize = true;
            lblCustomerPhoneTitle.Location = new Point(420, 32);
            lblCustomerPhoneTitle.Name = "lblCustomerPhoneTitle";
            lblCustomerPhoneTitle.Size = new Size(44, 23);
            lblCustomerPhoneTitle.TabIndex = 2;
            lblCustomerPhoneTitle.Text = "SĐT:";
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Location = new Point(470, 32);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(27, 23);
            lblCustomerPhone.TabIndex = 3;
            lblCustomerPhone.Text = "—";
            // 
            // grpBooking
            // 
            grpBooking.Controls.Add(lblBookingIdTitle);
            grpBooking.Controls.Add(lblBookingId);
            grpBooking.Controls.Add(lblBookingCodeTitle);
            grpBooking.Controls.Add(lblBookingCode);
            grpBooking.Controls.Add(lblBookingTypeTitle);
            grpBooking.Controls.Add(lblBookingType);
            grpBooking.Location = new Point(16, 188);
            grpBooking.Name = "grpBooking";
            grpBooking.Size = new Size(728, 100);
            grpBooking.TabIndex = 2;
            grpBooking.TabStop = false;
            grpBooking.Text = "Thông tin booking";
            // 
            // lblBookingIdTitle
            // 
            lblBookingIdTitle.AutoSize = true;
            lblBookingIdTitle.Location = new Point(16, 32);
            lblBookingIdTitle.Name = "lblBookingIdTitle";
            lblBookingIdTitle.Size = new Size(91, 23);
            lblBookingIdTitle.TabIndex = 0;
            lblBookingIdTitle.Text = "BookingId:";
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Location = new Point(110, 32);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(27, 23);
            lblBookingId.TabIndex = 1;
            lblBookingId.Text = "—";
            // 
            // lblBookingCodeTitle
            // 
            lblBookingCodeTitle.AutoSize = true;
            lblBookingCodeTitle.Location = new Point(260, 32);
            lblBookingCodeTitle.Name = "lblBookingCodeTitle";
            lblBookingCodeTitle.Size = new Size(105, 23);
            lblBookingCodeTitle.TabIndex = 2;
            lblBookingCodeTitle.Text = "Mã booking:";
            // 
            // lblBookingCode
            // 
            lblBookingCode.AutoSize = true;
            lblBookingCode.Location = new Point(350, 32);
            lblBookingCode.Name = "lblBookingCode";
            lblBookingCode.Size = new Size(27, 23);
            lblBookingCode.TabIndex = 3;
            lblBookingCode.Text = "—";
            // 
            // lblBookingTypeTitle
            // 
            lblBookingTypeTitle.AutoSize = true;
            lblBookingTypeTitle.Location = new Point(540, 32);
            lblBookingTypeTitle.Name = "lblBookingTypeTitle";
            lblBookingTypeTitle.Size = new Size(45, 23);
            lblBookingTypeTitle.TabIndex = 4;
            lblBookingTypeTitle.Text = "Loại:";
            // 
            // lblBookingType
            // 
            lblBookingType.AutoSize = true;
            lblBookingType.Location = new Point(580, 32);
            lblBookingType.Name = "lblBookingType";
            lblBookingType.Size = new Size(27, 23);
            lblBookingType.TabIndex = 5;
            lblBookingType.Text = "—";
            // 
            // grpTime
            // 
            grpTime.Controls.Add(lblCheckInTitle);
            grpTime.Controls.Add(dtCheckIn);
            grpTime.Controls.Add(lblCheckoutTitle);
            grpTime.Controls.Add(dtCheckout);
            grpTime.Controls.Add(chkCheckoutNow);
            grpTime.Location = new Point(16, 300);
            grpTime.Name = "grpTime";
            grpTime.Size = new Size(728, 110);
            grpTime.TabIndex = 3;
            grpTime.TabStop = false;
            grpTime.Text = "Thời gian";
            // 
            // lblCheckInTitle
            // 
            lblCheckInTitle.AutoSize = true;
            lblCheckInTitle.Location = new Point(16, 32);
            lblCheckInTitle.Name = "lblCheckInTitle";
            lblCheckInTitle.Size = new Size(81, 23);
            lblCheckInTitle.TabIndex = 0;
            lblCheckInTitle.Text = "Check-in:";
            // 
            // dtCheckIn
            // 
            dtCheckIn.CustomFormat = "dd/MM/yyyy HH:mm";
            dtCheckIn.Format = DateTimePickerFormat.Custom;
            dtCheckIn.Location = new Point(110, 28);
            dtCheckIn.Name = "dtCheckIn";
            dtCheckIn.ShowUpDown = true;
            dtCheckIn.Size = new Size(240, 30);
            dtCheckIn.TabIndex = 1;
            // 
            // lblCheckoutTitle
            // 
            lblCheckoutTitle.AutoSize = true;
            lblCheckoutTitle.Location = new Point(380, 32);
            lblCheckoutTitle.Name = "lblCheckoutTitle";
            lblCheckoutTitle.Size = new Size(86, 23);
            lblCheckoutTitle.TabIndex = 2;
            lblCheckoutTitle.Text = "Checkout:";
            // 
            // dtCheckout
            // 
            dtCheckout.CustomFormat = "dd/MM/yyyy HH:mm";
            dtCheckout.Format = DateTimePickerFormat.Custom;
            dtCheckout.Location = new Point(470, 28);
            dtCheckout.Name = "dtCheckout";
            dtCheckout.ShowUpDown = true;
            dtCheckout.Size = new Size(240, 30);
            dtCheckout.TabIndex = 3;
            // 
            // chkCheckoutNow
            // 
            chkCheckoutNow.AutoSize = true;
            chkCheckoutNow.Location = new Point(110, 64);
            chkCheckoutNow.Name = "chkCheckoutNow";
            chkCheckoutNow.Size = new Size(182, 27);
            chkCheckoutNow.TabIndex = 4;
            chkCheckoutNow.Text = "Checkout = bây giờ";
            // 
            // grpCalc
            // 
            grpCalc.Controls.Add(lblHourlyRateTitle);
            grpCalc.Controls.Add(txtHourlyRate);
            grpCalc.Controls.Add(lblUsedTimeTitle);
            grpCalc.Controls.Add(lblUsedTime);
            grpCalc.Controls.Add(lblBilledHoursTitle);
            grpCalc.Controls.Add(lblBilledHours);
            grpCalc.Controls.Add(lblTotalTitle);
            grpCalc.Controls.Add(lblTotal);
            grpCalc.Location = new Point(16, 420);
            grpCalc.Name = "grpCalc";
            grpCalc.Size = new Size(728, 100);
            grpCalc.TabIndex = 4;
            grpCalc.TabStop = false;
            grpCalc.Text = "Tính tiền theo giờ";
            // 
            // lblHourlyRateTitle
            // 
            lblHourlyRateTitle.AutoSize = true;
            lblHourlyRateTitle.Location = new Point(16, 32);
            lblHourlyRateTitle.Name = "lblHourlyRateTitle";
            lblHourlyRateTitle.Size = new Size(94, 23);
            lblHourlyRateTitle.TabIndex = 0;
            lblHourlyRateTitle.Text = "Giá / 1 giờ:";
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(110, 28);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(140, 30);
            txtHourlyRate.TabIndex = 1;
            txtHourlyRate.TextAlign = HorizontalAlignment.Right;
            // 
            // lblUsedTimeTitle
            // 
            lblUsedTimeTitle.AutoSize = true;
            lblUsedTimeTitle.Location = new Point(270, 32);
            lblUsedTimeTitle.Name = "lblUsedTimeTitle";
            lblUsedTimeTitle.Size = new Size(85, 23);
            lblUsedTimeTitle.TabIndex = 2;
            lblUsedTimeTitle.Text = "Thời gian:";
            // 
            // lblUsedTime
            // 
            lblUsedTime.AutoSize = true;
            lblUsedTime.Location = new Point(351, 32);
            lblUsedTime.Name = "lblUsedTime";
            lblUsedTime.Size = new Size(103, 23);
            lblUsedTime.TabIndex = 3;
            lblUsedTime.Text = "0 giờ 0 phút";
            lblUsedTime.Click += lblUsedTime_Click;
            // 
            // lblBilledHoursTitle
            // 
            lblBilledHoursTitle.AutoSize = true;
            lblBilledHoursTitle.Location = new Point(270, 62);
            lblBilledHoursTitle.Name = "lblBilledHoursTitle";
            lblBilledHoursTitle.Size = new Size(75, 23);
            lblBilledHoursTitle.TabIndex = 4;
            lblBilledHoursTitle.Text = "Giờ tính:";
            // 
            // lblBilledHours
            // 
            lblBilledHours.AutoSize = true;
            lblBilledHours.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBilledHours.Location = new Point(351, 62);
            lblBilledHours.Name = "lblBilledHours";
            lblBilledHours.Size = new Size(19, 23);
            lblBilledHours.TabIndex = 5;
            lblBilledHours.Text = "0";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Location = new Point(520, 44);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(87, 23);
            lblTotalTitle.TabIndex = 6;
            lblTotalTitle.Text = "Tổng tiền:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(603, 39);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(41, 28);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "0 đ";
            // 
            // grpPreview
            // 
            grpPreview.Location = new Point(16, 526);
            grpPreview.Name = "grpPreview";
            grpPreview.Size = new Size(728, 0);
            grpPreview.TabIndex = 0;
            grpPreview.TabStop = false;
            grpPreview.Text = "Xem nhanh";
            // 
            // lblCheckInTextTitle
            // 
            lblCheckInTextTitle.AutoSize = true;
            lblCheckInTextTitle.Location = new Point(0, 0);
            lblCheckInTextTitle.Name = "lblCheckInTextTitle";
            lblCheckInTextTitle.Size = new Size(100, 23);
            lblCheckInTextTitle.TabIndex = 0;
            lblCheckInTextTitle.Text = "Check-in:";
            // 
            // lblCheckInText
            // 
            lblCheckInText.Location = new Point(0, 0);
            lblCheckInText.Name = "lblCheckInText";
            lblCheckInText.Size = new Size(100, 23);
            lblCheckInText.TabIndex = 0;
            // 
            // lblCheckoutTextTitle
            // 
            lblCheckoutTextTitle.AutoSize = true;
            lblCheckoutTextTitle.Location = new Point(0, 0);
            lblCheckoutTextTitle.Name = "lblCheckoutTextTitle";
            lblCheckoutTextTitle.Size = new Size(100, 23);
            lblCheckoutTextTitle.TabIndex = 0;
            lblCheckoutTextTitle.Text = "Checkout:";
            // 
            // lblCheckoutText
            // 
            lblCheckoutText.Location = new Point(0, 0);
            lblCheckoutText.Name = "lblCheckoutText";
            lblCheckoutText.Size = new Size(100, 23);
            lblCheckoutText.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(239, 68, 68);
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(554, 520);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(190, 38);
            btnCheckout.TabIndex = 6;
            btnCheckout.Text = "Thanh toán & Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(210, 214, 220);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(438, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmPaymentCheckoutPopup
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(764, 570);
            Controls.Add(pnlHeader);
            Controls.Add(grpCustomer);
            Controls.Add(grpBooking);
            Controls.Add(grpTime);
            Controls.Add(grpCalc);
            Controls.Add(btnCancel);
            Controls.Add(btnCheckout);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPaymentCheckoutPopup";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thanh toán / Checkout";
            pnlHeader.ResumeLayout(false);
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpBooking.ResumeLayout(false);
            grpBooking.PerformLayout();
            grpTime.ResumeLayout(false);
            grpTime.PerformLayout();
            grpCalc.ResumeLayout(false);
            grpCalc.PerformLayout();
            ResumeLayout(false);
        }
    }
    }

