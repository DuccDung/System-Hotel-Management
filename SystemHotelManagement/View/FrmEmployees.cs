using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmEmployees : Form
    {
        private int? _selectedEmployeeId = null;

        public FrmEmployees()
        {
            InitializeComponent();
            InitRuntime();
            HookEvents();
            LoadEmployees();
        }

        private void InitRuntime()
        {
            if (cboRole.Items.Count == 0)
                cboRole.Items.AddRange(new object[] { "Admin", "Manager", "Receptionist", "Housekeeping" });

            cboRole.SelectedIndex = 0;
            chkIsActive.Checked = true;
            dtHired.Value = DateTime.Today;

            dgvEmployees.ReadOnly = true;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.MultiSelect = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HookEvents()
        {
            txtSearch.TextChanged += (_, __) => LoadEmployees();
            chkOnlyActive.CheckedChanged += (_, __) => LoadEmployees();

            dgvEmployees.SelectionChanged += (_, __) => FillFormFromGrid();

            btnAdd.Click += (_, __) => AddEmployee();
            btnUpdate.Click += (_, __) => UpdateEmployee();
            btnDelete.Click += (_, __) => DeleteEmployee();
            btnClear.Click += (_, __) => ClearForm();
        }

        private void LoadEmployees()
        {
            using var db = new SystemHotelManagementContext();

            var keyword = (txtSearch.Text ?? "").Trim();
            var onlyActive = chkOnlyActive.Checked;

            var q = db.Employees.AsNoTracking().AsQueryable();

            if (onlyActive)
                q = q.Where(x => x.IsActive);

            if (!string.IsNullOrEmpty(keyword))
            {
                q = q.Where(x =>
                    x.FullName.Contains(keyword) ||
                    x.Phone.Contains(keyword) ||
                    x.Email.Contains(keyword));
            }

            var data = q
                .OrderByDescending(x => x.EmployeeId)
                .Select(x => new
                {
                    x.EmployeeId,
                    x.FullName,
                    x.Phone,
                    x.Email,
                    x.Role,
                    x.IsActive,
                    x.HiredDate
                })
                .ToList();

            dgvEmployees.DataSource = data;

            if (dgvEmployees.Columns.Contains("EmployeeId"))
            {
                dgvEmployees.Columns["EmployeeId"].HeaderText = "ID";
                dgvEmployees.Columns["FullName"].HeaderText = "Họ tên";
                dgvEmployees.Columns["Phone"].HeaderText = "SĐT";
                dgvEmployees.Columns["Email"].HeaderText = "Email";
                dgvEmployees.Columns["Role"].HeaderText = "Vai trò";
                dgvEmployees.Columns["IsActive"].HeaderText = "Hoạt động";
                dgvEmployees.Columns["HiredDate"].HeaderText = "Ngày vào";
            }

            dgvEmployees.ClearSelection();
        }

        private void FillFormFromGrid()
        {
            if (dgvEmployees.CurrentRow == null) return;
            if (dgvEmployees.CurrentRow.Cells["EmployeeId"].Value == null) return;

            _selectedEmployeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeId"].Value);

            txtFullName.Text = dgvEmployees.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";
            txtPhone.Text = dgvEmployees.CurrentRow.Cells["Phone"].Value?.ToString() ?? "";
            txtEmail.Text = dgvEmployees.CurrentRow.Cells["Email"].Value?.ToString() ?? "";

            var role = dgvEmployees.CurrentRow.Cells["Role"].Value?.ToString() ?? "";
            if (!string.IsNullOrWhiteSpace(role) && cboRole.Items.Contains(role))
                cboRole.SelectedItem = role;
            else
                cboRole.SelectedIndex = 0;

            chkIsActive.Checked = Convert.ToBoolean(dgvEmployees.CurrentRow.Cells["IsActive"].Value);

            var hiredStr = dgvEmployees.CurrentRow.Cells["HiredDate"].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(hiredStr) && DateTime.TryParse(hiredStr, out var dt))
                dtHired.Value = dt;
            else
                dtHired.Value = DateTime.Today;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email.");
                return false;
            }
            return true;
        }

        private void AddEmployee()
        {
            if (!ValidateForm()) return;

            using var db = new SystemHotelManagementContext();

            var email = txtEmail.Text.Trim();
            if (db.Employees.Any(x => x.Email == email))
            {
                MessageBox.Show("Email đã tồn tại.");
                return;
            }

            var emp = new Employee
            {
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = email,
                Role = cboRole.SelectedItem?.ToString() ?? "",
                IsActive = chkIsActive.Checked,
            };

            db.Employees.Add(emp);
            db.SaveChanges();

            LoadEmployees();
            ClearForm();
        }

        private void UpdateEmployee()
        {
            if (_selectedEmployeeId == null)
            {
                MessageBox.Show("Hãy chọn 1 nhân viên để sửa.");
                return;
            }
            if (!ValidateForm()) return;

            using var db = new SystemHotelManagementContext();
            var emp = db.Employees.FirstOrDefault(x => x.EmployeeId == _selectedEmployeeId.Value);
            if (emp == null)
            {
                MessageBox.Show("Nhân viên không tồn tại.");
                return;
            }

            var email = txtEmail.Text.Trim();
            if (db.Employees.Any(x => x.Email == email && x.EmployeeId != emp.EmployeeId))
            {
                MessageBox.Show("Email đã tồn tại.");
                return;
            }

            emp.FullName = txtFullName.Text.Trim();
            emp.Phone = txtPhone.Text.Trim();
            emp.Email = email;
            emp.Role = cboRole.SelectedItem?.ToString() ?? "";
            emp.IsActive = chkIsActive.Checked;

            db.SaveChanges();

            LoadEmployees();
        }

        private void DeleteEmployee()
        {
            if (_selectedEmployeeId == null)
            {
                MessageBox.Show("Hãy chọn 1 nhân viên để xóa.");
                return;
            }

            var ok = MessageBox.Show("Xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ok != DialogResult.Yes) return;

            using var db = new SystemHotelManagementContext();
            var emp = db.Employees.FirstOrDefault(x => x.EmployeeId == _selectedEmployeeId.Value);
            if (emp == null) return;

            db.Employees.Remove(emp);
            db.SaveChanges();

            LoadEmployees();
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedEmployeeId = null;
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cboRole.SelectedIndex = 0;
            chkIsActive.Checked = true;
            dtHired.Value = DateTime.Today;
            dgvEmployees.ClearSelection();
        }
    }
}
