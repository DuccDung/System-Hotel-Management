using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmCustomersRanking : Form
    {
        public FrmCustomersRanking()
        {
            InitializeComponent();
            InitRuntime();
            HookEvents();
            LoadRanking();
        }

        private void InitRuntime()
        {
            // default: tính theo khoảng 30 ngày gần nhất
            dtTo.Value = DateTime.Today;
            dtFrom.Value = DateTime.Today.AddDays(-30);

            chkAllTime.Checked = true; // nếu bạn muốn mặc định all time thì true
            ToggleDatePickers();

            dgvCustomers.ReadOnly = true;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HookEvents()
        {
            txtSearch.TextChanged += (_, __) => LoadRanking();
            btnRefresh.Click += (_, __) => LoadRanking();

            chkAllTime.CheckedChanged += (_, __) =>
            {
                ToggleDatePickers();
                LoadRanking();
            };

            dtFrom.ValueChanged += (_, __) => { if (!chkAllTime.Checked) LoadRanking(); };
            dtTo.ValueChanged += (_, __) => { if (!chkAllTime.Checked) LoadRanking(); };
        }

        private void ToggleDatePickers()
        {
            bool enable = !chkAllTime.Checked;
            dtFrom.Enabled = enable;
            dtTo.Enabled = enable;
        }

        private void LoadRanking()
        {
            using var db = new SystemHotelManagementContext();

            var keyword = (txtSearch.Text ?? "").Trim();
            DateTime from = dtFrom.Value.Date;
            DateTime to = dtTo.Value.Date.AddDays(1).AddTicks(-1);

            // Query: Payment -> Booking -> Customer, group by customer
            var payments = db.Payments
                .AsNoTracking()
                .Include(p => p.Booking)
                .ThenInclude(b => b.Customer)
                .AsQueryable();

            if (!chkAllTime.Checked)
            {
                payments = payments.Where(p => p.PaidAt >= from && p.PaidAt <= to);
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                payments = payments.Where(p =>
                    p.Booking.Customer.FullName.Contains(keyword) ||
                    (p.Booking.Customer.Phone ?? "").Contains(keyword) ||
                    (p.Booking.Customer.Email ?? "").Contains(keyword));
            }

            var ranking = payments
                .GroupBy(p => new
                {
                    p.Booking.Customer.CustomerId,
                    p.Booking.Customer.FullName,
                    p.Booking.Customer.Phone,
                    p.Booking.Customer.Email,
                    p.Booking.Customer.IsMember,
                    p.Booking.Customer.MemberLevel,
                    p.Booking.Customer.Points
                })
                .Select(g => new
                {
                    CustomerId = g.Key.CustomerId,
                    FullName = g.Key.FullName,
                    Phone = g.Key.Phone,
                    Email = g.Key.Email,
                    IsMember = g.Key.IsMember,
                    MemberLevel = g.Key.MemberLevel,
                    Points = g.Key.Points,
                    TotalPaid = g.Sum(x => x.Amount),
                    PaymentCount = g.Count()
                })
                .OrderByDescending(x => x.TotalPaid)
                .ThenBy(x => x.FullName)
                .ToList();

            // Bind grid
            dgvCustomers.DataSource = ranking.Select((x, idx) => new
            {
                Rank = idx + 1,
                x.CustomerId,
                x.FullName,
                x.Phone,
                TotalPaid = x.TotalPaid,
                Payments = x.PaymentCount
            }).ToList();

            if (dgvCustomers.Columns.Contains("TotalPaid"))
            {
                dgvCustomers.Columns["Rank"].HeaderText = "Hạng";
                dgvCustomers.Columns["CustomerId"].HeaderText = "ID";
                dgvCustomers.Columns["FullName"].HeaderText = "Khách hàng";
                dgvCustomers.Columns["Phone"].HeaderText = "SĐT";
                dgvCustomers.Columns["TotalPaid"].HeaderText = "Tổng đã trả";
                dgvCustomers.Columns["Payments"].HeaderText = "Số lần TT";
                dgvCustomers.Columns["TotalPaid"].DefaultCellStyle.Format = "N0";
                dgvCustomers.Columns["TotalPaid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            UpdateTop3(ranking);
        }

        private void UpdateTop3(IEnumerable<dynamic> ranking)
        {
            // vì ranking ở trên là anonymous type, ta lấy lại từ grid an toàn hơn:
            // Tuy nhiên mình xử lý đơn giản: lấy trực tiếp từ dgvCustomers DataSource nếu có.
            // Ở đây: ta update top 3 theo dgvCustomers rows.
            string FormatVnd(object? val)
            {
                if (val == null) return "0 ₫";
                if (decimal.TryParse(val.ToString(), out var d))
                    return d.ToString("N0", CultureInfo.InvariantCulture) + " ₫";
                return "0 ₫";
            }

            void SetCard(Label name, Label amount, DataGridViewRow? row)
            {
                if (row == null)
                {
                    name.Text = "—";
                    amount.Text = "0 ₫";
                    return;
                }

                name.Text = row.Cells["FullName"].Value?.ToString() ?? "—";
                amount.Text = FormatVnd(row.Cells["TotalPaid"].Value);
            }

            DataGridViewRow? r1 = dgvCustomers.Rows.Count > 0 ? dgvCustomers.Rows[0] : null;
            DataGridViewRow? r2 = dgvCustomers.Rows.Count > 1 ? dgvCustomers.Rows[1] : null;
            DataGridViewRow? r3 = dgvCustomers.Rows.Count > 2 ? dgvCustomers.Rows[2] : null;

            SetCard(lblTop1Name, lblTop1Amount, r1);
            SetCard(lblTop2Name, lblTop2Amount, r2);
            SetCard(lblTop3Name, lblTop3Amount, r3);
        }
    }
}
