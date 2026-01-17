using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmRevenueProfitReport : Form
    {
        private DateTime _from;
        private DateTime _to;

        private List<PaymentRow> _paymentRows = new();
        private List<SalaryRow> _salaryRows = new();
        private List<ImportRow> _importRows = new();

        public FrmRevenueProfitReport()
        {
            InitializeComponent();
            HookEvents();
            InitRuntime();
        }

        private void InitRuntime()
        {
            dtTo.Value = DateTime.Today;
            dtFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            btnCalc.PerformClick();
        }

        private void HookEvents()
        {
            btnCalc.Click += (_, __) => Calculate();
            btnExport.Click += (_, __) => ExportExcel();
        }

        private void Calculate()
        {
            _from = dtFrom.Value.Date;
            _to = dtTo.Value.Date;

            if (_to < _from)
            {
                MessageBox.Show("Ngày kết thúc phải >= ngày bắt đầu.");
                return;
            }

            using var db = new SystemHotelManagementContext();

            // ========= 1) DOANH THU = SUM(Payment.Amount) =========
            _paymentRows = db.Payments.AsNoTracking()
                .Where(p => p.PaidAt.Date >= _from && p.PaidAt.Date <= _to)
                .OrderByDescending(p => p.PaidAt)
                .Select(p => new PaymentRow
                {
                    PaymentId = p.PaymentId,
                    BookingId = p.BookingId,
                    PaidAt = p.PaidAt,
                    Method = p.Method,
                    Amount = p.Amount,
                    Note = p.Note
                })
                .ToList();

            decimal revenue = _paymentRows.Sum(x => x.Amount);

            // ========= 2) CHI PHI NHAP HANG = SUM(StockImports.TotalAmount) =========
            // Nếu bạn muốn lấy theo CreatedAt thay vì ImportDate -> đổi điều kiện Where
            _importRows = db.StockImports.AsNoTracking()
                .Where(i => i.ImportDate.Date >= _from && i.ImportDate.Date <= _to)
                .OrderByDescending(i => i.ImportDate)
                .Select(i => new ImportRow
                {
                    ImportId = i.ImportId,
                    ImportDate = i.ImportDate,
                    SupplierName = i.SupplierName,
                    TotalAmount = i.TotalAmount,
                    Note = i.Note
                })
                .ToList();

            decimal importCost = _importRows.Sum(x => x.TotalAmount);

            // ========= 3) CHI PHI LUONG =========
            // rate theo Role + override theo Employee
            var roleRates = db.EmployeeHourlyRates.AsNoTracking()
                .Where(r => r.IsActive)
                .ToDictionary(r => r.Role, r => r.HourlyRate);

            var overrides = db.EmployeeHourlyRateOverrides.AsNoTracking()
                .Where(o => o.IsActive)
                .ToDictionary(o => o.EmployeeId, o => o.HourlyRate);

            var employees = db.Employees.AsNoTracking()
                .Where(e => e.IsActive)
                .Select(e => new { e.EmployeeId, e.FullName, e.Role })
                .ToList();

            var attend = db.Attendances.AsNoTracking()
                .Where(a => a.WorkDate.Date >= _from && a.WorkDate.Date <= _to)
                .ToList();

            _salaryRows = employees.Select(emp =>
            {
                decimal rate = overrides.ContainsKey(emp.EmployeeId)
                    ? overrides[emp.EmployeeId]
                    : (roleRates.ContainsKey(emp.Role) ? roleRates[emp.Role] : 0m);

                var aRows = attend.Where(a => a.EmployeeId == emp.EmployeeId).ToList();

                int workDays = aRows.Count(a => a.IsPresent || (a.WorkHours ?? 0m) > 0m);
                decimal totalHours = aRows.Sum(a => a.WorkHours ?? (a.IsPresent ? 8m : 0m));

                decimal totalPay = totalHours * rate;

                return new SalaryRow
                {
                    EmployeeId = emp.EmployeeId,
                    FullName = emp.FullName,
                    Role = emp.Role,
                    WorkDays = workDays,
                    TotalHours = totalHours,
                    HourlyRate = rate,
                    TotalPay = totalPay
                };
            })
            .Where(x => x.TotalHours > 0 || x.TotalPay > 0) // ẩn nhân viên không phát sinh giờ
            .OrderByDescending(x => x.TotalPay)
            .ToList();

            decimal salaryCost = _salaryRows.Sum(x => x.TotalPay);

            // ========= 4) LOI NHUAN =========
            decimal profit = revenue - (salaryCost + importCost);

            // ========= Bind UI =========
            lblRevenueValue.Text = ToMoney(revenue);
            lblSalaryValue.Text = ToMoney(salaryCost);
            lblImportValue.Text = ToMoney(importCost);
            lblProfitValue.Text = ToMoney(profit);

            dgvPayments.DataSource = _paymentRows;
            dgvSalary.DataSource = _salaryRows;
            dgvImports.DataSource = _importRows;

            FormatGrids();
        }

        private void FormatGrids()
        {
            // Payments
            if (dgvPayments.Columns.Count > 0)
            {
                dgvPayments.Columns[nameof(PaymentRow.PaymentId)].HeaderText = "ID";
                dgvPayments.Columns[nameof(PaymentRow.BookingId)].HeaderText = "Booking";
                dgvPayments.Columns[nameof(PaymentRow.PaidAt)].HeaderText = "Ngày nhận";
                dgvPayments.Columns[nameof(PaymentRow.Method)].HeaderText = "Phương thức";
                dgvPayments.Columns[nameof(PaymentRow.Amount)].HeaderText = "Số tiền";
                dgvPayments.Columns[nameof(PaymentRow.Note)].HeaderText = "Ghi chú";

                dgvPayments.Columns[nameof(PaymentRow.Amount)].DefaultCellStyle.Format = "N0";
                dgvPayments.Columns[nameof(PaymentRow.PaidAt)].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            // Salary
            if (dgvSalary.Columns.Count > 0)
            {
                dgvSalary.Columns[nameof(SalaryRow.EmployeeId)].HeaderText = "ID";
                dgvSalary.Columns[nameof(SalaryRow.FullName)].HeaderText = "Họ tên";
                dgvSalary.Columns[nameof(SalaryRow.Role)].HeaderText = "Chức vụ";
                dgvSalary.Columns[nameof(SalaryRow.WorkDays)].HeaderText = "Ngày làm";
                dgvSalary.Columns[nameof(SalaryRow.TotalHours)].HeaderText = "Tổng giờ";
                dgvSalary.Columns[nameof(SalaryRow.HourlyRate)].HeaderText = "Lương/giờ";
                dgvSalary.Columns[nameof(SalaryRow.TotalPay)].HeaderText = "Tổng lương";

                dgvSalary.Columns[nameof(SalaryRow.TotalHours)].DefaultCellStyle.Format = "N2";
                dgvSalary.Columns[nameof(SalaryRow.HourlyRate)].DefaultCellStyle.Format = "N0";
                dgvSalary.Columns[nameof(SalaryRow.TotalPay)].DefaultCellStyle.Format = "N0";
            }

            // Imports
            if (dgvImports.Columns.Count > 0)
            {
                dgvImports.Columns[nameof(ImportRow.ImportId)].HeaderText = "ID";
                dgvImports.Columns[nameof(ImportRow.ImportDate)].HeaderText = "Ngày nhập";
                dgvImports.Columns[nameof(ImportRow.SupplierName)].HeaderText = "Nhà cung cấp";
                dgvImports.Columns[nameof(ImportRow.TotalAmount)].HeaderText = "Tổng tiền";
                dgvImports.Columns[nameof(ImportRow.Note)].HeaderText = "Ghi chú";

                dgvImports.Columns[nameof(ImportRow.TotalAmount)].DefaultCellStyle.Format = "N0";
                dgvImports.Columns[nameof(ImportRow.ImportDate)].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private string ToMoney(decimal v) => v.ToString("N0", CultureInfo.InvariantCulture) + " ₫";

        // ===================== Export Excel =====================
        private void ExportExcel()
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"DoanhThu_LoiNhuan_{_from:yyyyMMdd}_{_to:yyyyMMdd}.xlsx"
            };
            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                using var wb = new XLWorkbook();

                // Sheet Tổng quan
                var ws0 = wb.Worksheets.Add("TongQuan");
                ws0.Cell(1, 1).Value = "Từ ngày";
                ws0.Cell(1, 2).Value = _from.ToString("dd/MM/yyyy");
                ws0.Cell(2, 1).Value = "Đến ngày";
                ws0.Cell(2, 2).Value = _to.ToString("dd/MM/yyyy");

                decimal revenue = _paymentRows.Sum(x => x.Amount);
                decimal importCost = _importRows.Sum(x => x.TotalAmount);
                decimal salaryCost = _salaryRows.Sum(x => x.TotalPay);
                decimal profit = revenue - (salaryCost + importCost);

                ws0.Cell(4, 1).Value = "Doanh thu (Payments)";
                ws0.Cell(4, 2).Value = (double)revenue;
                ws0.Cell(5, 1).Value = "Chi phí lương";
                ws0.Cell(5, 2).Value = (double)salaryCost;
                ws0.Cell(6, 1).Value = "Chi phí nhập hàng";
                ws0.Cell(6, 2).Value = (double)importCost;
                ws0.Cell(7, 1).Value = "Lợi nhuận";
                ws0.Cell(7, 2).Value = (double)profit;

                ws0.Range(4, 2, 7, 2).Style.NumberFormat.Format = "#,##0";
                ws0.Range(1, 1, 2, 1).Style.Font.Bold = true;
                ws0.Range(4, 1, 7, 1).Style.Font.Bold = true;
                ws0.Range(4, 1, 7, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws0.Columns().AdjustToContents();

                // Sheet Payments
                var ws1 = wb.Worksheets.Add("Payments");
                ws1.Cell(1, 1).Value = "PaymentId";
                ws1.Cell(1, 2).Value = "BookingId";
                ws1.Cell(1, 3).Value = "PaidAt";
                ws1.Cell(1, 4).Value = "Method";
                ws1.Cell(1, 5).Value = "Amount";
                ws1.Cell(1, 6).Value = "Note";
                ws1.Range(1, 1, 1, 6).Style.Font.Bold = true;

                int r = 2;
                foreach (var p in _paymentRows)
                {
                    ws1.Cell(r, 1).Value = p.PaymentId;
                    ws1.Cell(r, 2).Value = p.BookingId;
                    ws1.Cell(r, 3).Value = p.PaidAt;
                    ws1.Cell(r, 4).Value = p.Method;
                    ws1.Cell(r, 5).Value = (double)p.Amount;
                    ws1.Cell(r, 6).Value = p.Note;
                    r++;
                }
                ws1.Column(3).Style.DateFormat.Format = "dd/MM/yyyy HH:mm";
                ws1.Column(5).Style.NumberFormat.Format = "#,##0";
                ws1.Columns().AdjustToContents();

                // Sheet Salary
                var ws2 = wb.Worksheets.Add("Luong");
                ws2.Cell(1, 1).Value = "EmployeeId";
                ws2.Cell(1, 2).Value = "FullName";
                ws2.Cell(1, 3).Value = "Role";
                ws2.Cell(1, 4).Value = "WorkDays";
                ws2.Cell(1, 5).Value = "TotalHours";
                ws2.Cell(1, 6).Value = "HourlyRate";
                ws2.Cell(1, 7).Value = "TotalPay";
                ws2.Range(1, 1, 1, 7).Style.Font.Bold = true;

                r = 2;
                foreach (var s in _salaryRows)
                {
                    ws2.Cell(r, 1).Value = s.EmployeeId;
                    ws2.Cell(r, 2).Value = s.FullName;
                    ws2.Cell(r, 3).Value = s.Role;
                    ws2.Cell(r, 4).Value = s.WorkDays;
                    ws2.Cell(r, 5).Value = (double)s.TotalHours;
                    ws2.Cell(r, 6).Value = (double)s.HourlyRate;
                    ws2.Cell(r, 7).Value = (double)s.TotalPay;
                    r++;
                }
                ws2.Column(5).Style.NumberFormat.Format = "#,##0.00";
                ws2.Column(6).Style.NumberFormat.Format = "#,##0";
                ws2.Column(7).Style.NumberFormat.Format = "#,##0";
                ws2.Columns().AdjustToContents();

                // Sheet Imports
                var ws3 = wb.Worksheets.Add("NhapHang");
                ws3.Cell(1, 1).Value = "ImportId";
                ws3.Cell(1, 2).Value = "ImportDate";
                ws3.Cell(1, 3).Value = "SupplierName";
                ws3.Cell(1, 4).Value = "TotalAmount";
                ws3.Cell(1, 5).Value = "Note";
                ws3.Range(1, 1, 1, 5).Style.Font.Bold = true;

                r = 2;
                foreach (var i in _importRows)
                {
                    ws3.Cell(r, 1).Value = i.ImportId;
                    ws3.Cell(r, 2).Value = i.ImportDate;
                    ws3.Cell(r, 3).Value = i.SupplierName;
                    ws3.Cell(r, 4).Value = (double)i.TotalAmount;
                    ws3.Cell(r, 5).Value = i.Note;
                    r++;
                }
                ws3.Column(2).Style.DateFormat.Format = "dd/MM/yyyy";
                ws3.Column(4).Style.NumberFormat.Format = "#,##0";
                ws3.Columns().AdjustToContents();

                wb.SaveAs(sfd.FileName);
                MessageBox.Show("Xuất Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
        }

        // ===================== DTO bind =====================

        private sealed class PaymentRow
        {
            public int PaymentId { get; set; }
            public int BookingId { get; set; }
            public DateTime PaidAt { get; set; }
            public string Method { get; set; } = "";
            public decimal Amount { get; set; }
            public string? Note { get; set; }
        }

        private sealed class SalaryRow
        {
            public int EmployeeId { get; set; }
            public string FullName { get; set; } = "";
            public string Role { get; set; } = "";
            public int WorkDays { get; set; }
            public decimal TotalHours { get; set; }
            public decimal HourlyRate { get; set; }
            public decimal TotalPay { get; set; }
        }

        private sealed class ImportRow
        {
            public int ImportId { get; set; }
            public DateTime ImportDate { get; set; }
            public string SupplierName { get; set; } = "";
            public decimal TotalAmount { get; set; }
            public string? Note { get; set; }
        }
    }
}
