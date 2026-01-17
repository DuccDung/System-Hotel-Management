using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHotelManagement.View.Popup
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using SystemHotelManagement.Helper;
    using SystemHotelManagement.Models;

    public partial class FrmPaymentCheckoutPopup : Form
    {
        public int RoomId { get; }
        public string RoomCode { get; }

        // ===== Input (set từ Dashboard trước khi ShowDialog) =====
        public int BookingId;
        public string BookingCode;
        public string BookingType = "Hourly"; // Hourly / Overnight (tuỳ bạn)
        public string CustomerName = "";
        public string CustomerPhone = "";
        public DateTime CheckInTime = DateTime.Now;
        public DateTime? BookingEndTime = DateTime.Now; // nếu booking theo giờ có EndTime đặt trước
        public decimal HourlyRate = 100000m; // giá/1 giờ

        // ===== Output (đọc sau khi DialogResult.OK) =====
        public DateTime CheckoutTime;
        public TimeSpan UsedDuration;
        public decimal TotalAmount;
        public bool IsCheckoutConfirmed;

        public FrmPaymentCheckoutPopup(int roomId, string roomCode = "")
        {
            RoomId = roomId;
            RoomCode = roomCode;

            InitializeComponent();
            InitDefaults();
            WireEvents();
            Recalc();
        }

        private void InitDefaults()
        {
            using var context = new SystemHotelManagementContext();
            var room = context.Rooms.Include(r => r.RoomType).Where(x => x.RoomId == RoomId).FirstOrDefault();
            var booking = context.Bookings.Include(x => x.Customer).Where(x => x.RoomId == RoomId && x.CheckOutAt == null).FirstOrDefault();
            lblRoom.Text = string.IsNullOrWhiteSpace(RoomCode) ? $"Phòng #{RoomId}" : $"Phòng {RoomCode}";
            CustomerName = booking?.Customer.FullName ?? CustomerName;
            CustomerPhone = booking?.Customer.Phone ?? CustomerPhone;
            BookingId = booking?.BookingId ?? BookingId;
            BookingCode = $"BK{BookingId:000000}";
            BookingType = room?.RoomType.TypeName ?? BookingType;
            HourlyRate = room?.RoomType.BasePrice ?? HourlyRate;
            CheckInTime = booking?.CheckInPlan ?? CheckInTime;
            BookingEndTime = booking?.CheckOutPlan ?? BookingEndTime;

            // demo nếu chưa set từ ngoài
            lblCustomerName.Text = string.IsNullOrWhiteSpace(CustomerName) ? "Khách lẻ" : CustomerName;
            lblCustomerPhone.Text = string.IsNullOrWhiteSpace(CustomerPhone) ? "—" : CustomerPhone;

            lblBookingId.Text = BookingId > 0 ? BookingId.ToString() : "—";
            lblBookingCode.Text = string.IsNullOrWhiteSpace(BookingCode) ? "—" : BookingCode;
            lblBookingType.Text = string.IsNullOrWhiteSpace(BookingType) ? "Hourly" : BookingType;

            dtCheckIn.Value = CheckInTime;

            // Checkout mặc định:
            // - nếu có BookingEndTime thì chọn nó
            // - không có thì chọn Now
            dtCheckout.Value = BookingEndTime ?? DateTime.Now;

            chkCheckoutNow.Checked = true; // mặc định tính tới hiện tại
            dtCheckout.Enabled = !chkCheckoutNow.Checked;

            txtHourlyRate.Text = HourlyRate.ToString("N0");
        }

        private void WireEvents()
        {
            chkCheckoutNow.CheckedChanged += (_, __) =>
            {
                dtCheckout.Enabled = !chkCheckoutNow.Checked;
                Recalc();
            };

            dtCheckIn.ValueChanged += (_, __) => Recalc();
            dtCheckout.ValueChanged += (_, __) => Recalc();

            txtHourlyRate.TextChanged += (_, __) => Recalc();

            btnCancel.Click += (_, __) => { DialogResult = DialogResult.Cancel; Close(); };

            btnCheckout.Click += (_, __) =>
            {
                // Validate: checkout phải > checkin
                if (CheckoutTime <= dtCheckIn.Value)
                {
                    MessageBox.Show("Checkout phải lớn hơn Check-in.", "Lỗi thời gian",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using var context = new SystemHotelManagementContext();
                
                var payment = new Payment
                {
                    BookingId = BookingId,
                    Amount = TotalAmount,
                    PaidAt = DateTime.Now,
                    Method = "Cash",
                    ReceivedBy = AppSession.UserId
                };
                var room = context.Rooms.Where(r => r.RoomId == RoomId).FirstOrDefault();
                var booking = context.Bookings.Where(b => b.BookingId == BookingId).FirstOrDefault();
                if (room != null)
                {
                    room.RoomStatus = 0; // set phòng trống
                    context.Rooms.Update(room);
                }
                if (booking != null)
                {
                    booking.CheckInAt = dtCheckIn.Value;
                    booking.CheckOutAt = CheckoutTime;
                    context.Bookings.Update(booking);
                }
                context.Payments.Add(payment);
                context.SaveChanges();

                IsCheckoutConfirmed = true;
                DialogResult = DialogResult.OK;
                Close();
            };
        }

        private void Recalc()
        {
            var checkIn = dtCheckIn.Value;
            var checkout = chkCheckoutNow.Checked ? DateTime.Now : dtCheckout.Value;

            // Không cho checkout < checkin, nhưng vẫn hiển thị 0 để user sửa
            if (checkout < checkIn) checkout = checkIn;

            CheckoutTime = checkout;
            UsedDuration = checkout - checkIn;

            // Đọc hourly rate
            HourlyRate = ParseMoney(txtHourlyRate.Text);

            // Tính giờ sử dụng:
            // - Cách 1: tính theo phút, làm tròn lên mỗi 1 giờ (common PMS)
            //   billedHours = ceil(totalMinutes / 60)
            // - Bạn có thể đổi sang tính theo phút nếu muốn
            var totalMinutes = UsedDuration.TotalMinutes;
            var billedHours = (int)Math.Ceiling(totalMinutes / 60.0);
            if (billedHours < 0) billedHours = 0;

            lblUsedTime.Text = FormatDuration(UsedDuration);
            lblBilledHours.Text = billedHours.ToString();

            TotalAmount = billedHours * HourlyRate;
            lblTotal.Text = TotalAmount.ToString("N0") + " đ";

            // show times
            lblCheckInText.Text = checkIn.ToString("dd/MM/yyyy HH:mm");
            lblCheckoutText.Text = checkout.ToString("dd/MM/yyyy HH:mm");
        }

        private static string FormatDuration(TimeSpan ts)
        {
            var hours = (int)ts.TotalHours;
            var mins = ts.Minutes;
            return $"{hours} giờ {mins} phút";
        }

        private static decimal ParseMoney(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0m;
            s = s.Trim().Replace(".", "").Replace(",", "");
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out var v)) return v;
            decimal.TryParse(s, out v);
            return v;
        }

        private void lblUsedTime_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }
    }
}

