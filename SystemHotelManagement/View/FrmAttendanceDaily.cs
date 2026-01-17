using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmAttendanceDaily : Form
    {
        private readonly int? _currentAdminEmployeeId; // người chấm công (admin)

        public FrmAttendanceDaily(int? currentAdminEmployeeId = null)
        {
            _currentAdminEmployeeId = currentAdminEmployeeId;
            InitializeComponent();
            HookEvents();
            InitRuntime();
        }

        private void InitRuntime()
        {
            dtWorkDate.Value = DateTime.Today;
            BuildGridColumns();
            LoadForDate(dtWorkDate.Value.Date);
        }

        private void HookEvents()
        {
            btnLoad.Click += (_, __) => LoadForDate(dtWorkDate.Value.Date);
            btnSave.Click += (_, __) => SaveAttendance(dtWorkDate.Value.Date);

            dgvAttendance.CellValueChanged += (_, e) =>
            {
                // Nếu tick IsPresent => tự set Hours = 8 (default)
                if (e.RowIndex < 0) return;
                if (dgvAttendance.Columns[e.ColumnIndex].Name == "IsPresent")
                {
                    var row = dgvAttendance.Rows[e.RowIndex];
                    bool present = Convert.ToBoolean(row.Cells["IsPresent"].Value ?? false);
                    if (present && (row.Cells["WorkHours"].Value == null || string.IsNullOrWhiteSpace(row.Cells["WorkHours"].Value.ToString())))
                        row.Cells["WorkHours"].Value = 8m;
                    if (!present)
                        row.Cells["WorkHours"].Value = 0m;
                }
            };

            // cần để CellValueChanged chạy ngay khi click checkbox
            dgvAttendance.CurrentCellDirtyStateChanged += (_, __) =>
            {
                if (dgvAttendance.IsCurrentCellDirty)
                    dgvAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
        }

        private void BuildGridColumns()
        {
            dgvAttendance.Columns.Clear();

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeId",
                HeaderText = "EmployeeId",
                Visible = false
            });

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Họ tên",
                ReadOnly = true
            });

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Role",
                HeaderText = "Chức vụ",
                ReadOnly = true,
                Width = 120
            });

            dgvAttendance.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsPresent",
                HeaderText = "Đi làm",
                Width = 80
            });

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "WorkHours",
                HeaderText = "Giờ làm",
                Width = 90
            });

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Note",
                HeaderText = "Ghi chú"
            });
        }

        private void LoadForDate(DateTime date)
        {
            using var db = new SystemHotelManagementContext();

            var employees = db.Employees.AsNoTracking()
                .Where(e => e.IsActive)
                .OrderBy(e => e.FullName)
                .Select(e => new { e.EmployeeId, e.FullName, e.Role })
                .ToList();

            var attend = db.Attendances.AsNoTracking()
                .Where(a => a.WorkDate == date)
                .ToList()
                .ToDictionary(a => a.EmployeeId);

            dgvAttendance.Rows.Clear();

            foreach (var emp in employees)
            {
                bool present = false;
                decimal hours = 0m;
                string note = "";

                if (attend.TryGetValue(emp.EmployeeId, out var a))
                {
                    present = a.IsPresent;
                    hours = a.WorkHours ?? (a.IsPresent ? 8m : 0m);
                    note = a.Note ?? "";
                }

                dgvAttendance.Rows.Add(emp.EmployeeId, emp.FullName, emp.Role, present, hours, note);
            }
        }

        private void SaveAttendance(DateTime date)
        {
            using var db = new SystemHotelManagementContext();
            using var tran = db.Database.BeginTransaction();

            try
            {
                foreach (DataGridViewRow row in dgvAttendance.Rows)
                {
                    int employeeId = Convert.ToInt32(row.Cells["EmployeeId"].Value);

                    bool isPresent = Convert.ToBoolean(row.Cells["IsPresent"].Value ?? false);
                    decimal hours = 0m;
                    decimal.TryParse(row.Cells["WorkHours"].Value?.ToString(), out hours);

                    // nếu không đi làm => hours = 0
                    if (!isPresent) hours = 0m;

                    string? note = row.Cells["Note"].Value?.ToString();
                    note = string.IsNullOrWhiteSpace(note) ? null : note.Trim();

                    var existing = db.Attendances
                        .FirstOrDefault(a => a.EmployeeId == employeeId && a.WorkDate == date);

                    if (existing == null)
                    {
                        // chỉ tạo record khi có tick hoặc có note/hours != 0 (tùy bạn)
                        if (isPresent || hours > 0m || note != null)
                        {
                            db.Attendances.Add(new Attendance
                            {
                                EmployeeId = employeeId,
                                WorkDate = date,
                                IsPresent = isPresent,
                                WorkHours = hours,
                                Note = note,
                                MarkedBy = _currentAdminEmployeeId,
                                MarkedAt = DateTime.Now
                            });
                        }
                    }
                    else
                    {
                        existing.IsPresent = isPresent;
                        existing.WorkHours = hours;
                        existing.Note = note;
                        existing.MarkedBy = _currentAdminEmployeeId;
                        existing.MarkedAt = DateTime.Now;
                    }
                }

                db.SaveChanges();
                tran.Commit();
                MessageBox.Show("Lưu chấm công thành công!");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Lỗi lưu chấm công: " + ex.Message);
            }
        }
    }
}
