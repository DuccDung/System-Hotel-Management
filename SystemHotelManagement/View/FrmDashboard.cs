using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SystemHotelManagement.Models;
using SystemHotelManagement.View.Popup;

namespace SystemHotelManagement.View
{
    public partial class FrmDashboard : Form
    {
        private Button? _activeMenuButton;
        private Form? _activeChildForm;
        private readonly Color _menuBg = Color.White;
        private readonly Color _menuFg = Color.FromArgb(15, 23, 42);
        private readonly Color _menuBorder = Color.FromArgb(203, 213, 225);

        private readonly Color _activeBg = Color.FromArgb(219, 234, 254);
        private readonly Color _activeFg = Color.FromArgb(15, 98, 254);
        private readonly Color _activeBorder = Color.FromArgb(15, 98, 254);
        // ===== Demo data =====
        private readonly List<RoomCardModel> _allRooms = new();

        public FrmDashboard()
        {
            InitializeComponent();
            InitUiRuntime();
            SeedDemoData();
            ApplyFilterAndRender();
            InitLeftMenu();
        }

        private void InitLeftMenu()
        {
            // style chung cho 10 nút (đây là logic, nằm ở code.cs)
            var buttons = new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7 , btn8 , btn9};
            foreach (var b in buttons)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = _menuBorder;
                b.BackColor = _menuBg;
                b.ForeColor = _menuFg;
                b.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

                b.Click += MenuButton_Click;
            }

            // active mặc định
            SetActiveMenu(btn1);
        }

        //private void MenuButton_Click(object? sender, EventArgs e)
        //{
        //    if (sender is not Button b) return;

        //    SetActiveMenu(b);

        //    if (b == btn1) ShowView("dashboard");
        //    else if (b == btn2) ShowView("employees");
        //    // btn3... btn7 sau này bạn thêm tiếp
        //}
        private void MenuButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button b) return;

            SetActiveMenu(b);

            if (b == btn1)
            {
                var dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else if (b == btn2)
            {
                lblTitleTop.Text = "Quản lý nhân viên";
                OpenChildForm(new FrmEmployees());
            }
            else if (b == btn3)
            {
                lblTitleTop.Text = "Danh sách khách hàng";
                OpenChildForm(new FrmCustomersRanking());

            }
            else if (b == btn4)
            {
                lblTitleTop.Text = "Nhập hàng";
                OpenChildForm(new FrmStockImport());
            }
            else if (b == btn5)
            {
                lblTitleTop.Text = "Danh sách phòng";
                OpenChildForm(new FrmRooms());
            }
            else if (b == btn6)
            {
                lblTitleTop.Text = "Danh sách loại phòng";
                OpenChildForm(new FrmRoomTypes());
            }
            else if (b == btn7)
            {
                lblTitleTop.Text = "Chấm công nhân viên";
                OpenChildForm(new FrmAttendanceDaily());
            }
            else if (b == btn8)
            {
                lblTitleTop.Text = "Tính lương nhân viên";
                OpenChildForm(new FrmSalaryReport());
            }
            else if (b == btn9)
            {
                lblTitleTop.Text = "Doanh thu / Lợi nhuận";
                OpenChildForm(new FrmRevenueProfitReport());
            }

        }

        private void SetActiveMenu(Button b)
        {
            if (_activeMenuButton != null)
            {
                _activeMenuButton.BackColor = _menuBg;
                _activeMenuButton.ForeColor = _menuFg;
                _activeMenuButton.FlatAppearance.BorderColor = _menuBorder;
                _activeMenuButton.Font = new Font(_activeMenuButton.Font, FontStyle.Regular);
            }

            _activeMenuButton = b;
            _activeMenuButton.BackColor = _activeBg;
            _activeMenuButton.ForeColor = _activeFg;
            _activeMenuButton.FlatAppearance.BorderColor = _activeBorder;
            _activeMenuButton.Font = new Font(_activeMenuButton.Font, FontStyle.Bold);
        }
        private void InitUiRuntime()
        {
            // Combo default
            if (cboRoomType.Items.Count == 0)
            {
                cboRoomType.Items.AddRange(new object[] { "Tất cả", "Standard", "Deluxe", "VIP" });
            }
            cboRoomType.SelectedIndex = 0;

            // Hook events
            cboRoomType.SelectedIndexChanged += (_, __) => ApplyFilterAndRender();

            btnAll.Click += (_, __) => SetActiveStatusFilter(RoomStateFilter.All);
            btnReadyArrive.Click += (_, __) => SetActiveStatusFilter(RoomStateFilter.ReadyArrive);
            btnUsing.Click += (_, __) => SetActiveStatusFilter(RoomStateFilter.Using);
            btnDirty.Click += (_, __) => SetActiveStatusFilter(RoomStateFilter.Dirty);
            btnEmpty.Click += (_, __) => SetActiveStatusFilter(RoomStateFilter.Empty);
            btnClean.Click += (_, __) => SetActiveStatusFilter(RoomStateFilter.Clean);
            btnReserved.Click += (_, __) => SetActiveStatusFilter(RoomStateFilter.Reserved);
            btnRepair.Click += (_, __) => SetActiveStatusFilter(RoomStateFilter.Repair);

            // Default filter
            _activeStatusFilter = RoomStateFilter.All;
        }

        // ===== Status filter =====
        private RoomStateFilter _activeStatusFilter = RoomStateFilter.All;

        private void SetActiveStatusFilter(RoomStateFilter f)
        {
            _activeStatusFilter = f;
            ApplyFilterAndRender();
            UpdateStatusButtonsUi();
        }

        private void UpdateStatusButtonsUi()
        {
            // reset to neutral
            var allButtons = new[] { btnAll, btnReadyArrive, btnUsing, btnDirty, btnEmpty, btnClean, btnReserved, btnRepair };
            foreach (var b in allButtons)
            {
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            }

            Button active = _activeStatusFilter switch
            {
                RoomStateFilter.All => btnAll,
                RoomStateFilter.ReadyArrive => btnReadyArrive,
                RoomStateFilter.Using => btnUsing,
                RoomStateFilter.Dirty => btnDirty,
                RoomStateFilter.Empty => btnEmpty,
                RoomStateFilter.Clean => btnClean,
                RoomStateFilter.Reserved => btnReserved,
                RoomStateFilter.Repair => btnRepair,
                _ => btnAll
            };

            // highlight active button
            active.FlatAppearance.BorderSize = 2;
            active.FlatAppearance.BorderColor = Color.FromArgb(15, 98, 254);
        }

        private void ApplyFilterAndRender()
        {
            string typeFilter = cboRoomType.SelectedItem?.ToString() ?? "Tất cả";

            IEnumerable<RoomCardModel> q = _allRooms;

            // Filter by type
            if (!string.Equals(typeFilter, "Tất cả", StringComparison.OrdinalIgnoreCase))
                q = q.Where(x => string.Equals(x.RoomType, typeFilter, StringComparison.OrdinalIgnoreCase));

            // Filter by status
            q = _activeStatusFilter switch
            {
                RoomStateFilter.All => q,
                RoomStateFilter.ReadyArrive => q.Where(x => x.State == RoomState.ReadyArrive),
                RoomStateFilter.Using => q.Where(x => x.State == RoomState.Using),
                RoomStateFilter.Dirty => q.Where(x => x.State == RoomState.Dirty),
                RoomStateFilter.Empty => q.Where(x => x.State == RoomState.Empty),
                RoomStateFilter.Clean => q.Where(x => x.State == RoomState.Clean),
                RoomStateFilter.Reserved => q.Where(x => x.State == RoomState.Reserved),
                RoomStateFilter.Repair => q.Where(x => x.State == RoomState.Repair),
                _ => q
            };

            var list = q.ToList();
            RenderRooms(list);
            UpdateCounters();
            UpdateStatusButtonsUi();
        }

        private void UpdateCounters()
        {
            int readyArrive = _allRooms.Count(x => x.State == RoomState.ReadyArrive);
            int usingNow = _allRooms.Count(x => x.State == RoomState.Using);
            int dirty = _allRooms.Count(x => x.State == RoomState.Dirty);
            int empty = _allRooms.Count(x => x.State == RoomState.Empty);
            int clean = _allRooms.Count(x => x.State == RoomState.Clean);
            int reserved = _allRooms.Count(x => x.State == RoomState.Reserved);
            int repair = _allRooms.Count(x => x.State == RoomState.Repair);

            btnReadyArrive.Text = $"Chuẩn bị đến ({readyArrive})";
            btnUsing.Text = $"Đang ở ({usingNow})";
            btnDirty.Text = $"Chuẩn bị rời đi ({dirty})";
            btnEmpty.Text = $"Phòng trống ({empty})";
            btnClean.Text = $"Phòng sạch ({clean})";
            btnReserved.Text = $"Phòng bận ({reserved})";
            btnRepair.Text = $"Phòng đang sửa ({repair})";
        }

        // ===== Render UI cards =====
        private void RenderRooms(List<RoomCardModel> rooms)
        {
            flpRooms.SuspendLayout();
            flpRooms.Controls.Clear();

            foreach (var r in rooms)
            {
                flpRooms.Controls.Add(CreateRoomCard(r));
            }

            flpRooms.ResumeLayout();
        }

        private Control CreateRoomCard(RoomCardModel m)
        {
            var panel = new Panel
            {
                Width = 145,
                Height = 115,
                Margin = new Padding(12),
                BackColor = GetRoomColor(m.State),
                Cursor = Cursors.Hand
            };

            var lblCode = new Label
            {
                Text = m.RoomCode,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 16f, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 44
            };

            var lblTags = new Label
            {
                Text = string.IsNullOrWhiteSpace(m.Tag2) ? m.Tag1 : $"{m.Tag1}\n{m.Tag2}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Dock = DockStyle.Fill
            };

            var dot = new Panel
            {
                Width = 16,
                Height = 16,
                BackColor = Color.Transparent,
                Left = (panel.Width - 16) / 2,
                Top = panel.Height - 24
            };
            dot.Paint += (_, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using var b = new SolidBrush(Color.White);
                e.Graphics.FillEllipse(b, 1, 1, 14, 14);
            };

            panel.Controls.Add(dot);
            panel.Controls.Add(lblTags);
            panel.Controls.Add(lblCode);

            void ClickAny()
            {
                //MessageBox.Show(
                //    $"Phòng: {m.RoomCode}\nLoại: {m.RoomType}\nTrạng thái: {m.State}\nMã: {m.Tag1}",
                //    "Chi tiết phòng",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Information);
                HandleRoomCardClick(m);
            }

            panel.Click += (_, __) => ClickAny();
            foreach (Control c in panel.Controls)
                c.Click += (_, __) => ClickAny();

            return panel;
        }
        private void HandleRoomCardClick(RoomCardModel m)
        {
            // Empty/Clean => Booking popup
            if (m.State == RoomState.Empty || m.State == RoomState.Clean)
            {
                using var f = new FrmBookingPopup(roomId: m.RoomId, roomCode: m.RoomCode); // roomId bạn cần bổ sung vào model
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    // TODO: insert booking + update status bằng EF
                    if (f.GoToPaymentAfterBooking)
                    {
                        using var pay = new FrmPaymentCheckoutPopup(roomId: m.RoomId, roomCode: m.RoomCode);
                        pay.ShowDialog(this);
                    }
                    SeedDemoData();
                    ApplyFilterAndRender();
                }
                return;
            }

            // Using => Payment/Checkout popup
            if (m.State == RoomState.Using)
            {
                using var pay = new FrmPaymentCheckoutPopup(roomId: m.RoomId, roomCode: m.RoomCode);
                pay.ShowDialog(this);
                SeedDemoData();
                ApplyFilterAndRender();
                return;
            }

            MessageBox.Show($"Phòng {m.RoomCode} đang ở trạng thái: {m.State}");
        }

        private Color GetRoomColor(RoomState state)
        {
            // gần giống ảnh (xanh là sạch/trống, vàng là đặt/bận, đỏ là đang sửa)
            return state switch
            {
                RoomState.Clean => Color.FromArgb(22, 163, 74),       // xanh
                RoomState.Empty => Color.FromArgb(34, 197, 94),       // xanh tươi
                RoomState.Reserved => Color.FromArgb(202, 138, 4),    // vàng
                RoomState.Using => Color.FromArgb(16, 185, 129),      // xanh ngọc
                RoomState.Repair => Color.FromArgb(239, 68, 68),      // đỏ
                RoomState.Dirty => Color.FromArgb(148, 163, 184),     // xám
                RoomState.ReadyArrive => Color.FromArgb(59, 130, 246),// xanh dương
                _ => Color.FromArgb(22, 163, 74),
            };
        }

        // ===== Demo seed =====
        private void SeedDemoData()
        {
            _allRooms.Clear();
            using var context = new SystemHotelManagementContext();
            var rooms = context.Rooms.Include(r => r.RoomType).ToList();
            foreach (var ro in rooms) {
                _allRooms.Add(new RoomCardModel(
                    ro.RoomId,
                    ro.RoomCode,
                    ro.RoomType.Note ?? "",
                    "",
                    ro.RoomType.TypeName,
                    ro.RoomStatus switch
                    {
                        0 => RoomState.Empty, // phòng trống
                        1 => RoomState.Using, // đang ở
                        2 => RoomState.Dirty, // phòng bẩn
                        3 => RoomState.ReadyArrive, // chuẩn bị đến
                        4 => RoomState.Clean, // phòng sạch
                        5 => RoomState.Reserved, // đã đặt
                        6 => RoomState.Repair, // đang sửa
                        _ => RoomState.Empty // default
                    }
                ));
            }

            // Demo giống kiểu hiển thị trong ảnh
            //_allRooms.AddRange(new[]
            //{
            //    new RoomCardModel("301", "VIP", "", "VIP", RoomState.Clean),
            //    new RoomCardModel("302", "TRPL-MV", "", "Deluxe", RoomState.Reserved),
            //    new RoomCardModel("303", "TRPL-SV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("304", "TWN-MV", "", "Standard", RoomState.Repair),
            //    new RoomCardModel("305", "TWN-SV", "", "Standard", RoomState.Clean),
            //    new RoomCardModel("306", "TRPL-MV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("307", "TRPL-SV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("308", "TRPL-MV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("309", "TRPL-SV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("401", "VIP", "", "VIP", RoomState.Clean),

            //    new RoomCardModel("402", "TRPL-MV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("403", "TRPL-SV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("404", "TWN-MV", "", "Standard", RoomState.Using),
            //    new RoomCardModel("405", "TWN-SV", "", "Standard", RoomState.Clean),
            //    new RoomCardModel("406", "TRPL-MV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("407", "TRPL-SV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("408", "TRPL-MV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("409", "TRPL-SV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("501", "VIP", "", "VIP", RoomState.Clean),
            //    new RoomCardModel("502", "TRPL-MV", "", "Deluxe", RoomState.Clean),

            //    new RoomCardModel("601", "VIP", "", "VIP", RoomState.Clean),
            //    new RoomCardModel("602", "TWN-MV", "", "Standard", RoomState.Clean),
            //    new RoomCardModel("603", "TWN-SV", "", "Standard", RoomState.Clean),
            //    new RoomCardModel("604", "TWN-MV", "", "Standard", RoomState.Clean),
            //    new RoomCardModel("605", "TWN-SV", "", "Standard", RoomState.Clean),
            //    new RoomCardModel("606", "TWN-MV", "", "Standard", RoomState.Clean),
            //    new RoomCardModel("703", "DBL-SV", "", "Deluxe", RoomState.Clean),
            //    new RoomCardModel("704", "TRPL-MV", "", "Deluxe", RoomState.Clean),

            //    // thêm vài phòng trống/dirty/readyArrive để test filter
            //    new RoomCardModel("201", "STD", "", "Standard", RoomState.Empty),
            //    new RoomCardModel("202", "STD", "", "Standard", RoomState.Empty),
            //    new RoomCardModel("210", "STD", "", "Standard", RoomState.Dirty),
            //    new RoomCardModel("220", "DLX", "", "Deluxe", RoomState.ReadyArrive),
            //});
        }

        // ===== Types =====
        private enum RoomState
        {
            ReadyArrive,
            Using,
            Dirty,
            Empty,
            Clean,
            Reserved,
            Repair
        }

        private enum RoomStateFilter
        {
            All,
            ReadyArrive,
            Using,
            Dirty,
            Empty,
            Clean,
            Reserved,
            Repair
        }

        private sealed class RoomCardModel
        {
            public RoomCardModel(int roomId, string roomCode, string tag1, string tag2, string roomType, RoomState state)
            {
                RoomId = roomId;
                RoomCode = roomCode;
                Tag1 = tag1;
                Tag2 = tag2;
                RoomType = roomType;
                State = state;
            }
            public int RoomId { get; set; }
            public string RoomCode { get; }
            public string Tag1 { get; }
            public string Tag2 { get; }
            public string RoomType { get; }
            public RoomState State { get; }
        }
        private void ShowView(string view)
        {
            // ẩn tất cả view
            pnlContent.Visible = false;      // dashboard
            pnlEmployees.Visible = false;    // employees

            switch (view)
            {
                case "dashboard":
                    pnlContent.Visible = true;
                    lblTitleTop.Text = "Sơ đồ phòng";
                    break;

                case "employees":
                    pnlEmployees.Visible = true;
                    lblTitleTop.Text = "Quản lý nhân viên";
                    break;
            }
        }
        private void OpenChildForm(Form child)
        {
            if (_activeChildForm != null)
            {
                _activeChildForm.Close();
                _activeChildForm.Dispose();
            }

            _activeChildForm = child;

            // Xóa dashboard controls để nhét form con
            pnlContent.Controls.Clear();

            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(child);
            pnlContent.Tag = child;
            child.Show();
        }
        private void lbl_db_Click(object sender, EventArgs e)
        {

        }
    }
}
