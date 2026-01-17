using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmRoomTypes : Form
    {
        private int? _selectedId = null;

        public FrmRoomTypes()
        {
            InitializeComponent();
            HookEvents();
            LoadData();
        }

        private void HookEvents()
        {
            txtSearch.TextChanged += (_, __) => LoadData();
            dgvRoomTypes.SelectionChanged += (_, __) => LoadSelectedToForm();

            btnAdd.Click += (_, __) => AddRoomType();
            btnUpdate.Click += (_, __) => UpdateRoomType();
            btnDelete.Click += (_, __) => DeleteRoomType();
            btnClear.Click += (_, __) => ClearForm();
        }

        private void LoadData()
        {
            using var db = new SystemHotelManagementContext();
            string kw = (txtSearch.Text ?? "").Trim();

            var q = db.RoomTypes.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(kw))
                q = q.Where(x => x.TypeName.Contains(kw) || (x.Note ?? "").Contains(kw));

            var list = q.OrderBy(x => x.TypeName)
                .Select(x => new
                {
                    x.RoomTypeId,
                    x.TypeName,
                    x.BasePrice,
                    x.Capacity,
                    x.Note
                })
                .ToList();

            dgvRoomTypes.DataSource = list;
            if (dgvRoomTypes.Columns.Count > 0)
            {
                dgvRoomTypes.Columns["RoomTypeId"].HeaderText = "ID";
                dgvRoomTypes.Columns["TypeName"].HeaderText = "Loại";
                dgvRoomTypes.Columns["BasePrice"].HeaderText = "Giá";
                dgvRoomTypes.Columns["Capacity"].HeaderText = "Sức chứa";
                dgvRoomTypes.Columns["Note"].HeaderText = "Ghi chú";

                dgvRoomTypes.Columns["BasePrice"].DefaultCellStyle.Format = "N0";
            }
        }

        private void LoadSelectedToForm()
        {
            if (dgvRoomTypes.CurrentRow == null) return;

            _selectedId = Convert.ToInt32(dgvRoomTypes.CurrentRow.Cells["RoomTypeId"].Value);
            txtTypeName.Text = dgvRoomTypes.CurrentRow.Cells["TypeName"].Value?.ToString() ?? "";
            numBasePrice.Value = Convert.ToDecimal(dgvRoomTypes.CurrentRow.Cells["BasePrice"].Value);
            numCapacity.Value = Convert.ToDecimal(dgvRoomTypes.CurrentRow.Cells["Capacity"].Value);
            txtNote.Text = dgvRoomTypes.CurrentRow.Cells["Note"].Value?.ToString() ?? "";
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng.");
                return false;
            }
            return true;
        }

        private void AddRoomType()
        {
            if (!ValidateForm()) return;

            using var db = new SystemHotelManagementContext();
            var rt = new RoomType
            {
                TypeName = txtTypeName.Text.Trim(),
                BasePrice = numBasePrice.Value,
                Capacity = (int)numCapacity.Value,
                Note = string.IsNullOrWhiteSpace(txtNote.Text) ? null : txtNote.Text.Trim()
            };

            db.RoomTypes.Add(rt);
            db.SaveChanges();
            LoadData();
            ClearForm();
        }

        private void UpdateRoomType()
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn 1 loại phòng để sửa.");
                return;
            }
            if (!ValidateForm()) return;

            using var db = new SystemHotelManagementContext();
            var rt = db.RoomTypes.FirstOrDefault(x => x.RoomTypeId == _selectedId.Value);
            if (rt == null) return;

            rt.TypeName = txtTypeName.Text.Trim();
            rt.BasePrice = numBasePrice.Value;
            rt.Capacity = (int)numCapacity.Value;
            rt.Note = string.IsNullOrWhiteSpace(txtNote.Text) ? null : txtNote.Text.Trim();

            db.SaveChanges();
            LoadData();
        }

        private void DeleteRoomType()
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn 1 loại phòng để xóa.");
                return;
            }

            if (MessageBox.Show("Xóa loại phòng này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using var db = new SystemHotelManagementContext();
            var rt = db.RoomTypes.Include(x => x.Rooms).FirstOrDefault(x => x.RoomTypeId == _selectedId.Value);
            if (rt == null) return;

            if (rt.Rooms.Any())
            {
                MessageBox.Show("Không thể xóa vì loại phòng đang có phòng sử dụng.");
                return;
            }

            db.RoomTypes.Remove(rt);
            db.SaveChanges();
            LoadData();
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedId = null;
            txtTypeName.Clear();
            numBasePrice.Value = 0;
            numCapacity.Value = 1;
            txtNote.Clear();
        }
    }
}
