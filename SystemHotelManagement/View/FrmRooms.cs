using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;

namespace SystemHotelManagement.View
{
    public partial class FrmRooms : Form
    {
        private int? _selectedId = null;

        public FrmRooms()
        {
            InitializeComponent();
            InitRuntime();
            HookEvents();
            LoadData();
        }

        private void InitRuntime()
        {
            using var db = new SystemHotelManagementContext();

            // RoomType combobox
            var types = db.RoomTypes.AsNoTracking()
                .OrderBy(x => x.TypeName)
                .Select(x => new { x.RoomTypeId, x.TypeName })
                .ToList();

            cboRoomType.DataSource = types;
            cboRoomType.DisplayMember = "TypeName";
            cboRoomType.ValueMember = "RoomTypeId";

            // Status combobox theo hệ thống RoomStatus bạn đang dùng:
            // 0 Empty,1 Using,2 Dirty,3 ReadyArrive,4 Clean,5 Reserved,6 Repair
            cboStatus.Items.Clear();
            cboStatus.Items.Add(new StatusItem("Phòng trống", 0));
            cboStatus.Items.Add(new StatusItem("Đang ở", 1));
            cboStatus.Items.Add(new StatusItem("Phòng bẩn", 2));
            cboStatus.Items.Add(new StatusItem("Chuẩn bị đến", 3));
            cboStatus.Items.Add(new StatusItem("Phòng sạch", 4));
            cboStatus.Items.Add(new StatusItem("Đã đặt", 5));
            cboStatus.Items.Add(new StatusItem("Đang sửa", 6));
            cboStatus.DisplayMember = "Text";
            cboStatus.ValueMember = "Value";
            cboStatus.SelectedIndex = 0;

            chkIsActive.Checked = true;
        }

        private sealed class StatusItem
        {
            public string Text { get; }
            public byte Value { get; }
            public StatusItem(string text, byte value) { Text = text; Value = value; }
        }

        private void HookEvents()
        {
            txtSearch.TextChanged += (_, __) => LoadData();
            chkActiveOnly.CheckedChanged += (_, __) => LoadData();

            dgvRooms.SelectionChanged += (_, __) => LoadSelectedToForm();

            btnAdd.Click += (_, __) => AddRoom();
            btnUpdate.Click += (_, __) => UpdateRoom();
            btnDelete.Click += (_, __) => DeleteRoom();
            btnClear.Click += (_, __) => ClearForm();
        }

        private void LoadData()
        {
            using var db = new SystemHotelManagementContext();
            string kw = (txtSearch.Text ?? "").Trim();
            bool activeOnly = chkActiveOnly.Checked;

            var q = db.Rooms.AsNoTracking()
                .Include(r => r.RoomType)
                .AsQueryable();

            if (activeOnly)
                q = q.Where(r => r.IsActive);

            if (!string.IsNullOrEmpty(kw))
            {
                q = q.Where(r =>
                    r.RoomCode.Contains(kw) ||
                    (r.Note ?? "").Contains(kw) ||
                    r.RoomType.TypeName.Contains(kw));
            }

            var list = q.OrderBy(r => r.RoomCode)
                .Select(r => new
                {
                    r.RoomId,
                    r.RoomCode,
                    RoomType = r.RoomType.TypeName,
                    r.RoomTypeId,
                    r.Floor,
                    r.IsActive,
                    r.RoomStatus,
                    r.Note
                })
                .ToList();

            dgvRooms.DataSource = list;

            if (dgvRooms.Columns.Count > 0)
            {
                dgvRooms.Columns["RoomId"].HeaderText = "ID";
                dgvRooms.Columns["RoomCode"].HeaderText = "Mã phòng";
                dgvRooms.Columns["RoomType"].HeaderText = "Loại phòng";
                dgvRooms.Columns["Floor"].HeaderText = "Tầng";
                dgvRooms.Columns["IsActive"].HeaderText = "Hoạt động";
                dgvRooms.Columns["RoomStatus"].HeaderText = "Trạng thái";
                dgvRooms.Columns["Note"].HeaderText = "Ghi chú";

                // ẩn RoomTypeId (dùng nội bộ)
                dgvRooms.Columns["RoomTypeId"].Visible = false;
            }
        }

        private void LoadSelectedToForm()
        {
            if (dgvRooms.CurrentRow == null) return;

            _selectedId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomId"].Value);
            txtRoomCode.Text = dgvRooms.CurrentRow.Cells["RoomCode"].Value?.ToString() ?? "";

            int roomTypeId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomTypeId"].Value);
            cboRoomType.SelectedValue = roomTypeId;

            object? floorVal = dgvRooms.CurrentRow.Cells["Floor"].Value;
            numFloor.Value = floorVal == null ? 0 : Convert.ToDecimal(floorVal);

            chkIsActive.Checked = Convert.ToBoolean(dgvRooms.CurrentRow.Cells["IsActive"].Value);

            byte status = Convert.ToByte(dgvRooms.CurrentRow.Cells["RoomStatus"].Value);
            cboStatus.SelectedValue = status;

            txtNote.Text = dgvRooms.CurrentRow.Cells["Note"].Value?.ToString() ?? "";
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtRoomCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng.");
                return false;
            }

            if (cboRoomType.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng.");
                return false;
            }

            return true;
        }

        private void AddRoom()
        {
            if (!ValidateForm()) return;

            using var db = new SystemHotelManagementContext();

            string code = txtRoomCode.Text.Trim();
            if (db.Rooms.Any(r => r.RoomCode == code))
            {
                MessageBox.Show("Mã phòng đã tồn tại!");
                return;
            }

            var room = new Room
            {
                RoomCode = code,
                RoomTypeId = Convert.ToInt32(cboRoomType.SelectedValue),
                Floor = (int)numFloor.Value,
                IsActive = chkIsActive.Checked,
                RoomStatus = Convert.ToByte(cboStatus.SelectedValue),
                Note = string.IsNullOrWhiteSpace(txtNote.Text) ? null : txtNote.Text.Trim()
            };

            db.Rooms.Add(room);
            db.SaveChanges();
            LoadData();
            ClearForm();
        }

        private void UpdateRoom()
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn 1 phòng để sửa.");
                return;
            }
            if (!ValidateForm()) return;

            using var db = new SystemHotelManagementContext();

            var room = db.Rooms.FirstOrDefault(r => r.RoomId == _selectedId.Value);
            if (room == null) return;

            string code = txtRoomCode.Text.Trim();
            if (db.Rooms.Any(r => r.RoomId != room.RoomId && r.RoomCode == code))
            {
                MessageBox.Show("Mã phòng đã tồn tại!");
                return;
            }

            room.RoomCode = code;
            room.RoomTypeId = Convert.ToInt32(cboRoomType.SelectedValue);
            room.Floor = (int)numFloor.Value;
            room.IsActive = chkIsActive.Checked;
            room.RoomStatus = Convert.ToByte(cboStatus.SelectedValue);
            room.Note = string.IsNullOrWhiteSpace(txtNote.Text) ? null : txtNote.Text.Trim();

            db.SaveChanges();
            LoadData();
        }

        private void DeleteRoom()
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn 1 phòng để xóa.");
                return;
            }

            if (MessageBox.Show("Xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using var db = new SystemHotelManagementContext();

            var room = db.Rooms.Include(r => r.Bookings).FirstOrDefault(r => r.RoomId == _selectedId.Value);
            if (room == null) return;

            if (room.Bookings.Any())
            {
                MessageBox.Show("Không thể xóa vì phòng đã có booking.");
                return;
            }

            db.Rooms.Remove(room);
            db.SaveChanges();
            LoadData();
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedId = null;
            txtRoomCode.Clear();
            if (cboRoomType.Items.Count > 0) cboRoomType.SelectedIndex = 0;
            numFloor.Value = 0;
            chkIsActive.Checked = true;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            txtNote.Clear();
        }
    }
}
