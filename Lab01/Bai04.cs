using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Homework
{
    public partial class Bai04 : Form
    {
        private Dictionary<int, Dictionary<string, Seat>> roomSeats;
        private Dictionary<string, TicketCategory> seatCategories;
        private Dictionary<string, Movie> movies;
        private Dictionary<int, List<string>> selectedSeatsByRoom;
        private Movie currentMovie;
        private int currentRoom = 1;

        public Bai04()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            roomSeats = new Dictionary<int, Dictionary<string, Seat>>();
            for (int i = 1; i <= 3; i++)
            {
                roomSeats[i] = new Dictionary<string, Seat>();
            }

            seatCategories = new Dictionary<string, TicketCategory>
            {
                {"A1", TicketCategory.Discounted},
                {"A5", TicketCategory.Discounted},
                {"B1", TicketCategory.Discounted},
                {"B5", TicketCategory.Discounted},
                {"C1", TicketCategory.Discounted},
                {"C5", TicketCategory.Discounted},
                {"A2", TicketCategory.Standard},
                {"A3", TicketCategory.Standard},
                {"A4", TicketCategory.Standard},
                {"C2", TicketCategory.Standard},
                {"C3", TicketCategory.Standard},
                {"C4", TicketCategory.Standard},
                {"B2", TicketCategory.VIP},
                {"B3", TicketCategory.VIP},
                {"B4", TicketCategory.VIP}
            };

            movies = new Dictionary<string, Movie>
            {
                {"Đào, phở và piano", new Movie { Name = "Đào, phở và piano", Price = 45000, Rooms = new List<int> {1, 2, 3} }},
                {"Mai", new Movie { Name = "Mai", Price = 100000, Rooms = new List<int> {2, 3} }},
                {"Gặp lại chị bầu", new Movie { Name = "Gặp lại chị bầu", Price = 70000, Rooms = new List<int> {1} }},
                {"Tarot", new Movie { Name = "Tarot", Price = 90000, Rooms = new List<int> {3} }}
            };

            selectedSeatsByRoom = new Dictionary<int, List<string>>
            {
                {1, new List<string>()},
                {2, new List<string>()},
                {3, new List<string>()}
            };

            CreateAllSeats();
        }

        private void CreateAllSeats()
        {
            string[] rows = { "A", "B", "C" };

            for (int room = 1; room <= 3; room++)
            {
                foreach (string row in rows)
                {
                    for (int col = 1; col <= 5; col++)
                    {
                        string seatKey = row + col;

                        roomSeats[room][seatKey] = new Seat
                        {
                            SeatNumber = seatKey,
                            Row = row,
                            Number = col.ToString(),
                            Category = seatCategories[seatKey],
                            IsBooked = false
                        };
                    }
                }
            }
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            foreach (var movie in movies.Values)
            {
                cboMovies.Items.Add(movie);
            }
            cboMovies.DisplayMember = "Name";
            cboMovies.SelectedIndex = 0;

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton1.Checked = true;

            cboMovies.SelectedIndexChanged += CboMovies_SelectedIndexChanged;
            cboMovies.SelectedIndexChanged += CboMovies_SelectedIndexChanged;
            btnConfirm.Click += BtnConfirm_Click;
            btnReset.Click += BtnReset_Click;

            UpdateMovieSelection();
        }

        private void CboMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMovieSelection();
        }

        private void UpdateMovieSelection()
        {
            if (cboMovies.SelectedItem != null)
            {
                currentMovie = (Movie)cboMovies.SelectedItem;

                radioButton1.Enabled = currentMovie.Rooms.Contains(1);
                radioButton2.Enabled = currentMovie.Rooms.Contains(2);
                radioButton3.Enabled = currentMovie.Rooms.Contains(3);

                if (!currentMovie.Rooms.Contains(currentRoom))
                {
                    currentRoom = currentMovie.Rooms[0];
                }

                radioButton1.Checked = (currentRoom == 1);
                radioButton2.Checked = (currentRoom == 2);
                radioButton3.Checked = (currentRoom == 3);

                InitializeSeatsDisplay();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked && rb.Enabled)
            {
                if (rb == radioButton1) currentRoom = 1;
                else if (rb == radioButton2) currentRoom = 2;
                else if (rb == radioButton3) currentRoom = 3;

                InitializeSeatsDisplay();
            }
        }

        private void InitializeSeatsDisplay()
        {
            panelSeats.Controls.Clear();

            int btnSize = 55;
            int spacing = 12;
            int startX = 60;
            int startY = 90;

            Label lblScreen = new Label
            {
                Text = "SCREEN",
                Font = new Font("Arial", 16, FontStyle.Bold),
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(startX, 20),
                Size = new Size(5 * (btnSize + spacing) - spacing, 40)
            };
            panelSeats.Controls.Add(lblScreen);

            Label lblRoom = new Label
            {
                Text = $"PHÒNG CHIẾU {currentRoom}",
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(startX, 65),
                AutoSize = true
            };
            panelSeats.Controls.Add(lblRoom);

            string[] rows = { "A", "B", "C" };

            for (int row = 0; row < rows.Length; row++)
            {
                Label lblRowLeft = new Label
                {
                    Text = rows[row],
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    ForeColor = Color.DarkSlateGray,
                    Location = new Point(startX - 35, startY + row * (btnSize + spacing) + 15),
                    AutoSize = true
                };
                panelSeats.Controls.Add(lblRowLeft);

                for (int col = 1; col <= 5; col++)
                {
                    string seatKey = rows[row] + col;
                    Seat seat = roomSeats[currentRoom][seatKey];

                    if (seat.Category == TicketCategory.NotAvailable)
                    {
                        Label lblX = new Label
                        {
                            Text = "✕",
                            Font = new Font("Arial", 28, FontStyle.Bold),
                            ForeColor = Color.Gray,
                            Location = new Point(startX + (col - 1) * (btnSize + spacing) + 10,
                                                startY + row * (btnSize + spacing) + 8),
                            Size = new Size(btnSize, btnSize),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        panelSeats.Controls.Add(lblX);
                        continue;
                    }

                    Button btn = new Button
                    {
                        Text = seatKey,
                        Tag = seatKey,
                        Size = new Size(btnSize, btnSize),
                        Location = new Point(startX + (col - 1) * (btnSize + spacing),
                                            startY + row * (btnSize + spacing)),
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Enabled = !seat.IsBooked
                    };

                    bool isSelected = selectedSeatsByRoom[currentRoom].Contains(seatKey);

                    if (seat.IsBooked)
                    {
                        btn.BackColor = Color.FromArgb(60, 40, 20);
                        btn.ForeColor = Color.White;
                    }
                    else if (isSelected)
                    {
                        btn.BackColor = Color.FromArgb(128, 128, 128);
                        btn.ForeColor = Color.White;
                        btn.Text = "✕";
                        btn.Font = new Font("Arial", 20, FontStyle.Bold);
                    }
                    else
                    {
                        switch (seat.Category)
                        {
                            case TicketCategory.Discounted:
                                btn.BackColor = Color.FromArgb(108, 117, 125);
                                btn.ForeColor = Color.White;
                                break;
                            case TicketCategory.Standard:
                                btn.BackColor = Color.FromArgb(40, 167, 69);
                                btn.ForeColor = Color.White;
                                break;
                            case TicketCategory.VIP:
                                btn.BackColor = Color.FromArgb(220, 53, 69);
                                btn.ForeColor = Color.White;
                                break;
                        }
                    }

                    btn.FlatAppearance.BorderColor = Color.Black;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.Click += SeatButton_Click;

                    panelSeats.Controls.Add(btn);
                }

                Label lblRowRight = new Label
                {
                    Text = rows[row],
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    ForeColor = Color.DarkSlateGray,
                    Location = new Point(startX + 5 * (btnSize + spacing) + 15,
                                        startY + row * (btnSize + spacing) + 15),
                    AutoSize = true
                };
                panelSeats.Controls.Add(lblRowRight);
            }

            int legendY = startY + 3 * (btnSize + spacing) + 25;
            AddLegend("Vé vớt (1/4 giá)", Color.FromArgb(108, 117, 125), startX, legendY);
            AddLegend("Vé thường (giá chuẩn)", Color.FromArgb(40, 167, 69), startX, legendY + 30);
            AddLegend("Vé VIP (2x giá)", Color.FromArgb(220, 53, 69), startX, legendY + 60);
            AddLegend("Đang chọn", Color.FromArgb(128, 128, 128), startX, legendY + 90);
            AddLegend("Đã đặt", Color.FromArgb(60, 40, 20), startX, legendY + 120);

            UpdateDisplay();
        }

        private void AddLegend(string text, Color color, int x, int y)
        {
            Panel pnl = new Panel
            {
                BackColor = color,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(x, y),
                Size = new Size(25, 25)
            };
            panelSeats.Controls.Add(pnl);

            Label lbl = new Label
            {
                Text = text,
                Location = new Point(x + 32, y + 4),
                AutoSize = true,
                Font = new Font("Arial", 9, FontStyle.Bold)
            };
            panelSeats.Controls.Add(lbl);
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string seatKey = btn.Tag.ToString();
            Seat seat = roomSeats[currentRoom][seatKey];

            if (seat.IsBooked)
            {
                MessageBox.Show("Ghế này đã được đặt!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isSelected = selectedSeatsByRoom[currentRoom].Contains(seatKey);

            if (!isSelected)
            {
                int roomsWithSeats = selectedSeatsByRoom.Count(kvp => kvp.Value.Count > 0);

                if (roomsWithSeats >= 2)
                {
                    if (selectedSeatsByRoom[currentRoom].Count >= 2)
                    {
                        MessageBox.Show("Khi chọn vé ở 2 phòng chiếu, mỗi phòng chỉ được chọn tối đa 2 ghế!",
                            "Giới hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (roomsWithSeats == 2 && selectedSeatsByRoom[currentRoom].Count == 0)
                {
                    MessageBox.Show("Không thể chọn vé ở quá 2 phòng chiếu!",
                        "Giới hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (isSelected)
            {
                selectedSeatsByRoom[currentRoom].Remove(seatKey);
            }
            else
            {
                selectedSeatsByRoom[currentRoom].Add(seatKey);
            }

            InitializeSeatsDisplay();
        }

        private void UpdateDisplay()
        {
            var allSelected = new List<string>();
            foreach (var kvp in selectedSeatsByRoom)
            {
                if (kvp.Value.Count > 0)
                {
                    allSelected.Add($"Phòng {kvp.Key}: {string.Join(", ", kvp.Value.OrderBy(s => s))}");
                }
            }

            if (allSelected.Count > 0)
            {
                lblSelectedSeats.Text = "Ghế đã chọn:\n" + string.Join("\n", allSelected);
            }
            else
            {
                lblSelectedSeats.Text = "Ghế đã chọn: Chưa chọn";
            }

            decimal totalPrice = 0;
            if (currentMovie != null)
            {
                foreach (var kvp in selectedSeatsByRoom)
                {
                    int room = kvp.Key;
                    foreach (string seatKey in kvp.Value)
                    {
                        Seat seat = roomSeats[room][seatKey];
                        decimal multiplier = GetPriceMultiplier(seat.Category);
                        totalPrice += currentMovie.Price * multiplier;
                    }
                }
            }

            lblTotalPrice.Text = $"Tổng tiền: {totalPrice:N0} VNĐ";
        }

        private decimal GetPriceMultiplier(TicketCategory category)
        {
            switch (category)
            {
                case TicketCategory.Discounted: return 0.25m;
                case TicketCategory.Standard: return 1.0m;
                case TicketCategory.VIP: return 2.0m;
                default: return 1.0m;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomName.Focus();
                return;
            }

            int totalSeats = selectedSeatsByRoom.Sum(kvp => kvp.Value.Count);
            if (totalSeats == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bookingInfo = "";
            bookingInfo += "THÔNG TIN ĐẶT VÉ XEM PHIM\n";
            bookingInfo += "\n\n";
            bookingInfo += $"Khách hàng: {txtCustomName.Text}\n";
            bookingInfo += $"Phim: {currentMovie.Name}\n";
            bookingInfo += $"Giá vé chuẩn: {currentMovie.Price:N0} VNĐ\n\n";

            decimal grandTotal = 0;

            foreach (var kvp in selectedSeatsByRoom.OrderBy(k => k.Key))
            {
                if (kvp.Value.Count > 0)
                {
                    bookingInfo += $" PHÒNG CHIẾU {kvp.Key} \n";

                    foreach (string seatKey in kvp.Value.OrderBy(s => s))
                    {
                        Seat seat = roomSeats[kvp.Key][seatKey];
                        decimal multiplier = GetPriceMultiplier(seat.Category);
                        decimal price = currentMovie.Price * multiplier;
                        grandTotal += price;

                        string categoryName = "";
                        switch (seat.Category)
                        {
                            case TicketCategory.Discounted: categoryName = "Vé vớt"; break;
                            case TicketCategory.Standard: categoryName = "Vé thường"; break;
                            case TicketCategory.VIP: categoryName = "Vé VIP"; break;
                        }

                        bookingInfo += $"  • Ghế {seatKey} ({categoryName}): {price:N0} VNĐ\n";
                    }
                    bookingInfo += "\n";
                }
            }

            bookingInfo += $"\n";
            bookingInfo += $"TỔNG THANH TOÁN: {grandTotal:N0} VNĐ\n";
            bookingInfo += $"";

            DialogResult result = MessageBox.Show(
                bookingInfo + "\n\nXác nhận đặt vé?",
                "Xác nhận đặt vé",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                foreach (var kvp in selectedSeatsByRoom)
                {
                    foreach (string seatKey in kvp.Value)
                    {
                        roomSeats[kvp.Key][seatKey].IsBooked = true;
                    }
                }

                MessageBox.Show("Đặt vé thành công!\n\nCảm ơn quý khách!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var list in selectedSeatsByRoom.Values)
                {
                    list.Clear();
                }
                txtCustomName.Clear();
                InitializeSeatsDisplay();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (var list in selectedSeatsByRoom.Values)
            {
                list.Clear();
            }
            txtCustomName.Clear();
            InitializeSeatsDisplay();
        }

        private void panelSeats_Paint(object sender, EventArgs e)
        {
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lab01 lab01 = new Lab01();
            lab01.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }

    public enum TicketCategory
    {
        Discounted,
        Standard,
        VIP,
        NotAvailable
    }

    public class Movie
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<int> Rooms { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Seat
    {
        public string SeatNumber { get; set; }
        public string Row { get; set; }
        public string Number { get; set; }
        public TicketCategory Category { get; set; }
        public bool IsBooked { get; set; }
    }
}