using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View.Popup
{
    public partial class FrmBookingPopup : Form
    {
        public int RoomId { get; }
        public string RoomCode { get; }

        // Kết quả trả ra cho form cha
        public bool IsHourly;
        public DateTime StartTime;
        public DateTime? EndTime;
        public bool PayNow;
        public string CusName;
        public string CusPhone;

        // Nếu true => form cha mở popup thanh toán/checkout luôn
        public bool GoToPaymentAfterBooking;

        public FrmBookingPopup(int roomId, string roomCode = "")
        {
            RoomId = roomId;
            RoomCode = roomCode;

            InitializeComponent();
            InitDefaults();
            WireEvents();
        }

        private void InitDefaults()
        {
            lblRoom.Text = string.IsNullOrWhiteSpace(RoomCode)
                ? $"Phòng #{RoomId}"
                : $"Phòng {RoomCode}";

            // Default = Thuê theo giờ (bạn có thể đổi sang qua đêm nếu muốn)
            rbHourly.Checked = true;

            var now = DateTime.Now;
            dtHourlyStart.Value = now;
            dtHourlyEnd.Value = now.AddHours(2);

            dtOvernightCheckIn.Value = now;
            chkOvernightHasExpectedCheckout.Checked = false;
            dtOvernightExpectedCheckout.Value = now.AddDays(1).Date.AddHours(12); // 12h trưa hôm sau (dự kiến)

            ToggleModeUI();
        }

        private void WireEvents()
        {
            rbHourly.CheckedChanged += (_, __) => ToggleModeUI();
            rbOvernight.CheckedChanged += (_, __) => ToggleModeUI();

            chkOvernightHasExpectedCheckout.CheckedChanged += (_, __) =>
            {
                dtOvernightExpectedCheckout.Enabled = chkOvernightHasExpectedCheckout.Checked;
            };

            dtHourlyStart.ValueChanged += (_, __) =>
            {
                // Nếu user chọn start > end thì tự đẩy end theo start + 1h
                if (dtHourlyEnd.Value <= dtHourlyStart.Value)
                    dtHourlyEnd.Value = dtHourlyStart.Value.AddHours(1);
            };

            dtHourlyEnd.ValueChanged += (_, __) =>
            {
                // Không cho end <= start
                if (dtHourlyEnd.Value <= dtHourlyStart.Value)
                    dtHourlyEnd.Value = dtHourlyStart.Value.AddHours(1);
            };

            btnCancel.Click += (_, __) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            btnConfirm.Click += (_, __) => Confirm();
        }

        private void ToggleModeUI()
        {
            grpHourly.Enabled = rbHourly.Checked;
            grpOvernight.Enabled = rbOvernight.Checked;

            // Pay now chỉ áp dụng cho thuê theo giờ
            chkPayNow.Enabled = rbHourly.Checked;
            if (!rbHourly.Checked) chkPayNow.Checked = false;

            // Expected checkout chỉ áp dụng qua đêm
            dtOvernightExpectedCheckout.Enabled = rbOvernight.Checked && chkOvernightHasExpectedCheckout.Checked;
        }

        private void Confirm()
        {

            //
            // value customer main
            //
            var customer = new Customer
            {
                CustomerId = 1,
            };
            CusName = txt_cus_name.Text.Trim();
            CusPhone = txt_cus_phone.Text.Trim();
            if (!string.IsNullOrEmpty(CusName) || !string.IsNullOrEmpty(CusPhone))
            {
                if (string.IsNullOrEmpty(CusName) || string.IsNullOrEmpty(CusPhone))
                {
                    if (txt_cus_phone.TextLength < 10 || txt_cus_phone.TextLength > 11)
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!");
                        txt_cus_phone.Focus();
                        return;
                    }

                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng (Họ tên và Số điện thoại).",
                                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // thông tin khách hàng đầy đủ
                    using var context = new SystemHotelManagementContext();
                    var existingCus = context.Customers
                        .FirstOrDefault(c => c.Phone == CusPhone);
                    if (existingCus == null)
                    {
                        var newCus = new Customer  // creating new customer
                        {
                            FullName = CusName,
                            Phone = CusPhone,
                            CreatedAt = DateTime.Now,
                            IsMember = false
                        };
                        context.Customers.Add(newCus);
                        context.SaveChanges();
                        customer = newCus;
                    }
                    else customer = existingCus;
                }
            }
            // Trong trường hợp không có thông tin khách hàng => (ẩn danh - id = 1 )

            // Validate + set output
            if (rbHourly.Checked) // case thuê theo giờ
            {
                var a = dtHourlyStart.Value;
                var b = dtHourlyEnd.Value;

                if (b <= a)
                {
                    MessageBox.Show("Giờ kết thúc (B) phải lớn hơn giờ bắt đầu (A).",
                        "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IsHourly = true;
                StartTime = a;
                EndTime = b;
                PayNow = chkPayNow.Checked;
                // Lấy thông tin khách hàng (nếu có)

                // Rule: tạo booking + check-in ngay nếu A <= Now (phần DB bạn làm ở form cha/service)
                // Rule mở thanh toán luôn:
                // - Nếu EndTime <= Now (thực tế đã hết giờ) HOẶC user tick "Thanh toán luôn"
                GoToPaymentAfterBooking = (b <= DateTime.Now) || PayNow;

                // create booking with customer
                var booking = new Booking
                {
                    RoomId = RoomId,
                    CustomerId = customer.CustomerId,
                    CheckInPlan = StartTime,
                    CheckOutPlan = (DateTime)EndTime,
                    CreatedAt = DateTime.Now,
                    Status = 1,
                };
                var guest = new BookingGuest
                {
                    Booking = booking,
                    GuestName = string.IsNullOrEmpty(customer.FullName) ? "ẩn danh" : customer.FullName,
                    Phone = string.IsNullOrEmpty(customer.Phone) ? "null" : customer.Phone,
                };
                var contextAdd = new SystemHotelManagementContext();
                contextAdd.Bookings.Add(booking);
                contextAdd.BookingGuests.Add(guest);
                contextAdd.SaveChanges();
            }
            else // case thuê qua đêm
            {
                IsHourly = false;
                StartTime = dtOvernightCheckIn.Value;

                if (chkOvernightHasExpectedCheckout.Checked)
                {
                    var expected = dtOvernightExpectedCheckout.Value;
                    if (expected <= StartTime)
                    {
                        MessageBox.Show("Giờ dự kiến checkout phải lớn hơn giờ check-in.",
                            "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    EndTime = expected; // dự kiến
                }
                else
                {
                    EndTime = null;
                }

                PayNow = false;
                GoToPaymentAfterBooking = false;

                // create booking with customer
                var booking = new Booking
                {
                    RoomId = RoomId,
                    CustomerId = customer.CustomerId,
                    CheckInPlan = StartTime,
                    CheckOutPlan = null,
                    CreatedAt = DateTime.Now,
                    Status = 1,
                };
                var guest = new BookingGuest
                {
                    Booking = booking,
                    GuestName = string.IsNullOrEmpty(customer.FullName) ? "ẩn danh" : customer.FullName,
                    Phone = string.IsNullOrEmpty(customer.Phone) ? "null" : customer.Phone,
                };
                var contextAdd = new SystemHotelManagementContext();
                contextAdd.Bookings.Add(booking);
                contextAdd.BookingGuests.Add(guest);
                contextAdd.SaveChanges();
            }


            //
            // update room status to using
            //
            using var db = new SystemHotelManagementContext();
            var room = db.Rooms.Find(RoomId);
            if (room != null)
            {
                room.RoomStatus = 1; // using
                db.SaveChanges();
            }

            // Close popup with OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txt_cus_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; // block non-digit input
        }
    }
}

