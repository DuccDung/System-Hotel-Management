using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmStockImport : Form
    {
        public FrmStockImport()
        {
            InitializeComponent();
            InitRuntime();
            HookEvents();
        }

        private void InitRuntime()
        {
            dtImportDate.Value = DateTime.Today;

            using var db = new SystemHotelManagementContext();
            var emps = db.Employees.AsNoTracking()
                .OrderBy(x => x.FullName)
                .Select(x => new { x.EmployeeId, x.FullName })
                .ToList();

            cboEmployee.DataSource = emps;
            cboEmployee.DisplayMember = "FullName";
            cboEmployee.ValueMember = "EmployeeId";

            // Setup columns cho dgvItems (tạo bằng code nhưng vẫn là logic file .cs)
            dgvItems.Columns.Clear();

            var colName = new DataGridViewTextBoxColumn { Name = "ItemName", HeaderText = "Tên hàng", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var colUnit = new DataGridViewTextBoxColumn { Name = "Unit", HeaderText = "ĐVT", Width = 90 };
            var colQty = new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Số lượng", Width = 90 };
            var colPrice = new DataGridViewTextBoxColumn { Name = "UnitPrice", HeaderText = "Đơn giá", Width = 120 };
            var colTotal = new DataGridViewTextBoxColumn { Name = "LineTotal", HeaderText = "Thành tiền", Width = 140, ReadOnly = true };

            dgvItems.Columns.AddRange(colName, colUnit, colQty, colPrice, colTotal);

            dgvItems.AllowUserToAddRows = true;
            dgvItems.AllowUserToDeleteRows = true;
        }

        private void HookEvents()
        {
            dgvItems.CellEndEdit += (_, __) => RecalcRowAndTotal();
            dgvItems.RowsRemoved += (_, __) => RecalcRowAndTotal();
            dgvItems.UserDeletedRow += (_, __) => RecalcRowAndTotal();

            btnRemoveRow.Click += (_, __) => RemoveSelectedRow();
            btnClear.Click += (_, __) => ClearForm();
            btnSave.Click += (_, __) => SaveImport();
        }

        private void RemoveSelectedRow()
        {
            if (dgvItems.CurrentRow == null) return;
            if (dgvItems.CurrentRow.IsNewRow) return;
            dgvItems.Rows.Remove(dgvItems.CurrentRow);
            RecalcRowAndTotal();
        }

        private void RecalcRowAndTotal()
        {
            decimal total = 0m;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.IsNewRow) continue;

                int qty = ParseInt(row.Cells["Quantity"].Value);
                decimal price = ParseDecimal(row.Cells["UnitPrice"].Value);

                decimal line = qty * price;
                row.Cells["LineTotal"].Value = line;

                total += line;
            }

            lblTotalAmount.Text = total.ToString("N0", CultureInfo.InvariantCulture) + " ₫";
        }

        private int ParseInt(object? v)
        {
            if (v == null) return 0;
            return int.TryParse(v.ToString(), out var n) ? n : 0;
        }

        private decimal ParseDecimal(object? v)
        {
            if (v == null) return 0m;
            return decimal.TryParse(v.ToString(), out var d) ? d : 0m;
        }

        private bool ValidateHeader()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp.");
                return false;
            }

            if (cboEmployee.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên nhập.");
                return false;
            }

            // ít nhất 1 dòng hàng
            bool hasItem = dgvItems.Rows.Cast<DataGridViewRow>()
                .Any(r => !r.IsNewRow && !string.IsNullOrWhiteSpace(r.Cells["ItemName"].Value?.ToString()));
            if (!hasItem)
            {
                MessageBox.Show("Vui lòng nhập ít nhất 1 mặt hàng.");
                return false;
            }

            return true;
        }

        private void SaveImport()
        {
            if (!ValidateHeader()) return;

            using var db = new SystemHotelManagementContext();
            using var tran = db.Database.BeginTransaction();

            try
            {
                int employeeId = Convert.ToInt32(cboEmployee.SelectedValue);

                // tính tổng
                decimal total = 0m;
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.IsNewRow) continue;
                    string name = row.Cells["ItemName"].Value?.ToString() ?? "";
                    if (string.IsNullOrWhiteSpace(name)) continue;

                    int qty = ParseInt(row.Cells["Quantity"].Value);
                    decimal price = ParseDecimal(row.Cells["UnitPrice"].Value);
                    total += qty * price;
                }

                var import = new StockImport
                {
                    EmployeeId = employeeId,
                    ImportDate = dtImportDate.Value,
                    SupplierName = txtSupplierName.Text.Trim(),
                    SupplierPhone = string.IsNullOrWhiteSpace(txtSupplierPhone.Text) ? null : txtSupplierPhone.Text.Trim(),
                    Note = string.IsNullOrWhiteSpace(txtNote.Text) ? null : txtNote.Text.Trim(),
                    TotalAmount = total,
                    CreatedAt = DateTime.Now
                };

                db.StockImports.Add(import);
                db.SaveChanges(); // lấy ImportId

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.IsNewRow) continue;

                    string name = row.Cells["ItemName"].Value?.ToString() ?? "";
                    if (string.IsNullOrWhiteSpace(name)) continue;

                    var item = new StockImportItem
                    {
                        ImportId = import.ImportId,
                        ItemName = name.Trim(),
                        Unit = row.Cells["Unit"].Value?.ToString(),
                        Quantity = ParseInt(row.Cells["Quantity"].Value),
                        UnitPrice = ParseDecimal(row.Cells["UnitPrice"].Value)
                    };

                    db.StockImportItems.Add(item);
                }

                db.SaveChanges();
                tran.Commit();

                MessageBox.Show("Lưu phiếu nhập thành công!");
                ClearForm();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Lỗi khi lưu phiếu nhập: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtSupplierName.Clear();
            txtSupplierPhone.Clear();
            txtNote.Clear();
            dtImportDate.Value = DateTime.Today;

            dgvItems.Rows.Clear();
            lblTotalAmount.Text = "0 ₫";
        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
