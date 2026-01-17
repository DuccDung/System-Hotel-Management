using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmSalaryReport : Form
    {
        private List<SummaryRow> _summary = new();
        private int? _selectedEmployeeId = null;
        private DateTime _from;
        private DateTime _to;

        public FrmSalaryReport()
        {
            InitializeComponent();
            HookEvents();
            InitRuntime();
        }

        private void InitRuntime()
        {
            dtTo.Value = DateTime.Today;
            dtFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            BuildSummaryColumns();
            BuildDetailColumns();

            CalculateAndBind();
        }

        private void HookEvents()
        {
            btnCalc.Click += (_, __) => CalculateAndBind();
            btnExport.Click += (_, __) => ExportExcel();

            dgvSummary.SelectionChanged += (_, __) =>
            {
                if (dgvSummary.CurrentRow == null) return;
                if (dgvSummary.CurrentRow.DataBoundItem is SummaryRow row)
                {
                    _selectedEmployeeId = row.EmployeeId;
                    LoadDetailForEmployee(row.EmployeeId);
                }
            };
        }

        // ===================== GRID COLUMNS =====================

        private void BuildSummaryColumns()
        {
            dgvSummary.AutoGenerateColumns = false;
            dgvSummary.Columns.Clear();

            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EmployeeId", HeaderText = "ID", Width = 60 });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Họ tên" });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Role", HeaderText = "Chức vụ", Width = 120 });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "WorkDays", HeaderText = "Ngày làm", Width = 90 });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OffDays", HeaderText = "Ngày nghỉ", Width = 90 });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalHours", HeaderText = "Tổng giờ", Width = 90 });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HourlyRate", HeaderText = "Lương/Giờ", Width = 110 });
            dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalPay", HeaderText = "Tổng lương", Width = 120 });

        }   

        private void BuildDetailColumns()
        {
            dgvDetail.AutoGenerateColumns = false;
            dgvDetail.Columns.Clear();

            dgvDetail.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "WorkDate", HeaderText = "Ngày", Width = 90 });
            dgvDetail.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusText", HeaderText = "Trạng thái", Width = 110 });
            dgvDetail.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Hours", HeaderText = "Giờ", Width = 70 });
            dgvDetail.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HourlyRate", HeaderText = "Lương/Giờ", Width = 110 });
            dgvDetail.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Pay", HeaderText = "Tiền ngày", Width = 110 });
            dgvDetail.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Note", HeaderText = "Ghi chú" });

            dgvDetail.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDetail.Columns[3].DefaultCellStyle.Format = "N0";
            dgvDetail.Columns[4].DefaultCellStyle.Format = "N0";
        }

        // ===================== CORE CALC =====================

        private void CalculateAndBind()
        {
            _from = dtFrom.Value.Date;
            _to = dtTo.Value.Date;

            if (_to < _from)
            {
                MessageBox.Show("Ngày kết thúc phải >= ngày bắt đầu.");
                return;
            }

            using var db = new SystemHotelManagementContext();

            // 1) role rates
            var roleRates = db.EmployeeHourlyRates.AsNoTracking()
                .Where(r => r.IsActive)
                .ToDictionary(r => r.Role, r => r.HourlyRate);

            // 2) overrides
            Dictionary<int, decimal> overrides = new();
            if (db.Set<EmployeeHourlyRateOverride>() != null)
            {
                overrides = db.EmployeeHourlyRateOverrides.AsNoTracking()
                    .Where(o => o.IsActive)
                    .ToDictionary(o => o.EmployeeId, o => o.HourlyRate);
            }

            // 3) employees
            var employees = db.Employees.AsNoTracking()
                .Where(e => e.IsActive)
                .Select(e => new { e.EmployeeId, e.FullName, e.Role })
                .ToList();

            // 4) attendance in range
            var attend = db.Attendances.AsNoTracking()
                .Where(a => a.WorkDate >= _from && a.WorkDate <= _to)
                .ToList();

            int totalDaysInRange = (_to - _from).Days + 1;

            _summary = employees.Select(emp =>
            {
                decimal rate = overrides.ContainsKey(emp.EmployeeId)
                    ? overrides[emp.EmployeeId]
                    : (roleRates.ContainsKey(emp.Role) ? roleRates[emp.Role] : 0m);

                // attendance rows for this employee
                var aRows = attend.Where(a => a.EmployeeId == emp.EmployeeId).ToList();

                // Worked: IsPresent true OR WorkHours > 0
                int workDays = aRows.Count(a => a.IsPresent || (a.WorkHours ?? 0m) > 0m);
                decimal totalHours = aRows.Sum(a => a.WorkHours ?? (a.IsPresent ? 8m : 0m));

                int offDays = totalDaysInRange - workDays;
                if (offDays < 0) offDays = 0;

                decimal totalPay = totalHours * rate;

                return new SummaryRow
                {
                    EmployeeId = emp.EmployeeId,
                    FullName = emp.FullName,
                    Role = emp.Role,
                    WorkDays = workDays,
                    OffDays = offDays,
                    TotalHours = totalHours,
                    HourlyRate = rate,
                    TotalPay = totalPay
                };
            })
            .OrderByDescending(x => x.TotalPay)
            .ToList();

            dgvSummary.DataSource = _summary;

            // format numbers
            FormatSummaryGrid();

            // auto select first employee to show detail
            if (_summary.Count > 0)
            {
                dgvSummary.ClearSelection();
                dgvSummary.Rows[0].Selected = true;
                _selectedEmployeeId = _summary[0].EmployeeId;
                LoadDetailForEmployee(_selectedEmployeeId.Value);
            }
            else
            {
                dgvDetail.DataSource = null;
                lblEmpName.Text = "Nhân viên: —";
                lblEmpRole.Text = "Chức vụ: —";
                lblRate.Text = "Lương/giờ: —";
                lblTotal.Text = "Tổng lương: —";
            }
        }

        private void FormatSummaryGrid()
        {
            foreach (DataGridViewColumn col in dgvSummary.Columns)
            {
                if (col.DataPropertyName == "HourlyRate" || col.DataPropertyName == "TotalPay")
                    col.DefaultCellStyle.Format = "N0";
                if (col.DataPropertyName == "TotalHours")
                    col.DefaultCellStyle.Format = "N2";
            }
        }

        private void LoadDetailForEmployee(int employeeId)
        {
            var sum = _summary.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (sum == null) return;

            lblEmpName.Text = $"Nhân viên: {sum.FullName}";
            lblEmpRole.Text = $"Chức vụ: {sum.Role}";
            lblRate.Text = $"Lương/giờ: {sum.HourlyRate.ToString("N0")} ₫";
            lblTotal.Text = $"Tổng lương: {sum.TotalPay.ToString("N0")} ₫";

            using var db = new SystemHotelManagementContext();

            var att = db.Attendances.AsNoTracking()
                .Where(a => a.EmployeeId == employeeId && a.WorkDate >= _from && a.WorkDate <= _to)
                .ToList()
                .ToDictionary(a => a.WorkDate.Date);

            var details = new List<DetailRow>();

            for (var d = _from; d <= _to; d = d.AddDays(1))
            {
                bool present = false;
                decimal hours = 0m;
                string? note = null;

                if (att.TryGetValue(d.Date, out var a))
                {
                    present = a.IsPresent || (a.WorkHours ?? 0m) > 0m;
                    hours = a.WorkHours ?? (a.IsPresent ? 8m : 0m);
                    note = a.Note;
                }

                string status = present ? "Đi làm" : "Nghỉ";
                decimal pay = hours * sum.HourlyRate;

                details.Add(new DetailRow
                {
                    WorkDate = d,
                    StatusText = status,
                    Hours = hours,
                    HourlyRate = sum.HourlyRate,
                    Pay = pay,
                    Note = note
                });
            }

            dgvDetail.DataSource = details;
        }

        // ===================== EXPORT EXCEL =====================

        private void ExportExcel()
        {
            if (_summary.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"BangLuong_{_from:yyyyMMdd}_{_to:yyyyMMdd}.xlsx"
            };

            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                using var wb = new XLWorkbook();

                // Sheet 1: Summary
                var ws1 = wb.Worksheets.Add("TongHop");
                ws1.Cell(1, 1).Value = "ID";
                ws1.Cell(1, 2).Value = "Họ tên";
                ws1.Cell(1, 3).Value = "Chức vụ";
                ws1.Cell(1, 4).Value = "Ngày làm";
                ws1.Cell(1, 5).Value = "Ngày nghỉ";
                ws1.Cell(1, 6).Value = "Tổng giờ";
                ws1.Cell(1, 7).Value = "Lương/Giờ";
                ws1.Cell(1, 8).Value = "Tổng lương";

                int r = 2;
                foreach (var x in _summary)
                {
                    ws1.Cell(r, 1).Value = x.EmployeeId;
                    ws1.Cell(r, 2).Value = x.FullName;
                    ws1.Cell(r, 3).Value = x.Role;
                    ws1.Cell(r, 4).Value = x.WorkDays;
                    ws1.Cell(r, 5).Value = x.OffDays;
                    ws1.Cell(r, 6).Value = (double)x.TotalHours;
                    ws1.Cell(r, 7).Value = (double)x.HourlyRate;
                    ws1.Cell(r, 8).Value = (double)x.TotalPay;
                    r++;
                }

                ws1.Range(1, 1, 1, 8).Style.Font.Bold = true;
                ws1.Columns().AdjustToContents();
                ws1.Column(7).Style.NumberFormat.Format = "#,##0";
                ws1.Column(8).Style.NumberFormat.Format = "#,##0";
                ws1.Column(6).Style.NumberFormat.Format = "#,##0.00";

                // Sheet 2: Detail (selected employee)
                int empId = _selectedEmployeeId ?? _summary[0].EmployeeId;
                var emp = _summary.First(x => x.EmployeeId == empId);

                var ws2 = wb.Worksheets.Add("ChiTiet");
                ws2.Cell(1, 1).Value = "Nhân viên";
                ws2.Cell(1, 2).Value = emp.FullName;
                ws2.Cell(2, 1).Value = "Chức vụ";
                ws2.Cell(2, 2).Value = emp.Role;
                ws2.Cell(3, 1).Value = "Khoảng";
                ws2.Cell(3, 2).Value = $"{_from:dd/MM/yyyy} - {_to:dd/MM/yyyy}";
                ws2.Cell(4, 1).Value = "Lương/Giờ";
                ws2.Cell(4, 2).Value = (double)emp.HourlyRate;

                ws2.Cell(6, 1).Value = "Ngày";
                ws2.Cell(6, 2).Value = "Trạng thái";
                ws2.Cell(6, 3).Value = "Giờ";
                ws2.Cell(6, 4).Value = "Lương/Giờ";
                ws2.Cell(6, 5).Value = "Tiền ngày";
                ws2.Cell(6, 6).Value = "Ghi chú";

                // lấy detail từ grid hiện tại
                var detailList = dgvDetail.DataSource as List<DetailRow>;
                if (detailList == null) detailList = new List<DetailRow>();

                int rr = 7;
                foreach (var d in detailList)
                {
                    ws2.Cell(rr, 1).Value = d.WorkDate;
                    ws2.Cell(rr, 2).Value = d.StatusText;
                    ws2.Cell(rr, 3).Value = (double)d.Hours;
                    ws2.Cell(rr, 4).Value = (double)d.HourlyRate;
                    ws2.Cell(rr, 5).Value = (double)d.Pay;
                    ws2.Cell(rr, 6).Value = d.Note;
                    rr++;
                }

                ws2.Range(6, 1, 6, 6).Style.Font.Bold = true;
                ws2.Column(1).Style.DateFormat.Format = "dd/MM/yyyy";
                ws2.Column(4).Style.NumberFormat.Format = "#,##0";
                ws2.Column(5).Style.NumberFormat.Format = "#,##0";
                ws2.Column(3).Style.NumberFormat.Format = "#,##0.00";
                ws2.Columns().AdjustToContents();

                wb.SaveAs(sfd.FileName);
                MessageBox.Show("Xuất Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
        }

        // ===================== DTOs for binding =====================

        private sealed class SummaryRow
        {
            public int EmployeeId { get; set; }
            public string FullName { get; set; } = "";
            public string Role { get; set; } = "";
            public int WorkDays { get; set; }
            public int OffDays { get; set; }
            public decimal TotalHours { get; set; }
            public decimal HourlyRate { get; set; }
            public decimal TotalPay { get; set; }
        }

        private sealed class DetailRow
        {
            public DateTime WorkDate { get; set; }
            public string StatusText { get; set; } = "";
            public decimal Hours { get; set; }
            public decimal HourlyRate { get; set; }
            public decimal Pay { get; set; }
            public string? Note { get; set; }
        }
    }
}
