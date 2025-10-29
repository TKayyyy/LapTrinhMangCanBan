using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai05 : Form
    {
        private Dictionary<int, Dictionary<string, Seat>> roomSeats;
        private Dictionary<string, TicketCategory> seatCategories;
        private Dictionary<string, Movie> movies;
        private Dictionary<int, List<string>> selectedSeatsByRoom;
        private HashSet<string> gheDaBan = new();
        private Movie currentMovie;
        private int currentRoom = 1;
        private Dictionary<string, List<(Customer, List<string>)>> bookingHistory = new();

        public Bai05()
        {
            InitializeComponent();
            InitializeData();
            DisableUI();
        }

        private void DisableUI()
        {
            cboMovies.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            btnConfirm.Enabled = false;
            btnReset.Enabled = false;
        }

        private void EnableUI()
        {
            cboMovies.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            btnConfirm.Enabled = true;
            btnReset.Enabled = true;
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

            movies = new Dictionary<string, Movie>();

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

        private void Bai05_Load(object sender, EventArgs e)
        {
            if (radioButton1 == null) return;

            radioButton1.CheckedChanged -= RadioButton_CheckedChanged;
            radioButton2.CheckedChanged -= RadioButton_CheckedChanged;
            radioButton3.CheckedChanged -= RadioButton_CheckedChanged;
            cboMovies.SelectedIndexChanged -= CboMovies_SelectedIndexChanged;
            btnConfirm.Click -= BtnConfirm_Click;
            btnReset.Click -= BtnReset_Click;
            Button_ImportFile.Click -= Button_ImportFile_Click;
            Button_ExportFile.Click -= Button_ExportFile_Click;

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;

            cboMovies.SelectedIndexChanged += CboMovies_SelectedIndexChanged;
            btnConfirm.Click += BtnConfirm_Click;
            btnReset.Click += BtnReset_Click;
            Button_ImportFile.Click += Button_ImportFile_Click;
            Button_ExportFile.Click += Button_ExportFile_Click;
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

            if (isSelected)
            {
                selectedSeatsByRoom[currentRoom].Remove(seatKey);
            }
            else
            {
                int roomsWithSeats = selectedSeatsByRoom.Count(kvp => kvp.Value.Count > 0);

                if (roomsWithSeats <= 1)
                {
                    selectedSeatsByRoom[currentRoom].Add(seatKey);
                }
                else
                {
                    if (selectedSeatsByRoom[currentRoom].Count < 2)
                    {
                        selectedSeatsByRoom[currentRoom].Add(seatKey);
                    }
                    else
                    {
                        MessageBox.Show("Mỗi phòng chỉ được chọn tối đa 2 ghế!", "Giới hạn",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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

        private int GetSeatPrice(string seatKey, int basePrice)
        {
            seatKey = seatKey.Trim().ToUpper();
            int price = seatKey switch
            {
                "A1" or "A5" or "C1" or "C5" => basePrice / 4,
                "B2" or "B3" or "B4" => basePrice * 2,
                _ => basePrice
            };
            return price;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (cboMovies.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalSeats = selectedSeatsByRoom.Sum(kvp => kvp.Value.Count);
            if (totalSeats == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomerForm customerForm = new CustomerForm();
            if (customerForm.ShowDialog() != DialogResult.OK)
                return;

            Customer customer = customerForm.GetCustomer();

            if (string.IsNullOrWhiteSpace(customer.Phone) || string.IsNullOrWhiteSpace(customer.Email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMovie = (Movie)cboMovies.SelectedItem;
            int phong = currentRoom;

            string movieKey = currentMovie.Name;
            if (!bookingHistory.ContainsKey(movieKey))
                bookingHistory[movieKey] = new List<(Customer, List<string>)>();

            bookingHistory[movieKey].Add((customer, new List<string>(selectedSeatsByRoom[phong])));

            foreach (var seatKey in selectedSeatsByRoom[phong])
            {
                gheDaBan.Add($"{currentMovie.Name}-{phong}-{seatKey}");
                roomSeats[phong][seatKey].IsBooked = true;
            }

            MessageBox.Show("Đặt vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (var list in selectedSeatsByRoom.Values)
            {
                list.Clear();
            }

            InitializeSeatsDisplay();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (var list in selectedSeatsByRoom.Values)
            {
                list.Clear();
            }
            InitializeSeatsDisplay();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Button_ImportFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new()
            {
                Title = "Chọn file input5.txt",
                Filter = "Text File|*.txt|All Files|*.*",
                FileName = "input5.txt"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                    movies.Clear();
                    gheDaBan.Clear();
                    bookingHistory.Clear();

                    for (int room = 1; room <= 3; room++)
                    {
                        foreach (var seat in roomSeats[room].Values)
                        {
                            seat.IsBooked = false;
                        }
                    }

                    foreach (var list in selectedSeatsByRoom.Values)
                    {
                        list.Clear();
                    }

                    for (int i = 0; i < lines.Length; i += 2)
                    {
                        if (i + 1 < lines.Length)
                        {
                            string tenPhim = lines[i].Trim();
                            if (int.TryParse(lines[i + 1].Trim(), out int gia) && !string.IsNullOrEmpty(tenPhim))
                            {
                                movies[tenPhim] = new Movie
                                {
                                    Name = tenPhim,
                                    Price = gia,
                                    Rooms = new List<int> { 1, 2, 3 }
                                };
                            }
                        }
                    }

                    cboMovies.Items.Clear();
                    foreach (var movie in movies.Values)
                    {
                        cboMovies.Items.Add(movie);
                    }
                    cboMovies.DisplayMember = "Name";
                    if (cboMovies.Items.Count > 0) cboMovies.SelectedIndex = 0;

                    EnableUI();
                    MessageBox.Show($"Import thành công {movies.Count} phim!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_ExportFile_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0)
            {
                MessageBox.Show("Vui lòng import file trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SaveFileDialog sfd = new()
            {
                Title = "Chọn nơi lưu thống kê",
                Filter = "Text File|*.txt",
                FileName = "output5.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var thongKe = movies.Select(kv =>
                    {
                        string tenPhim = kv.Key;
                        int giaChuan = kv.Value.Price;
                        int tongGhe = 3 * 15;
                        int veBan = 0;
                        int doanhThu = 0;

                        for (int phong = 1; phong <= 3; phong++)
                        {
                            var ghePhim = gheDaBan.Where(g => g.StartsWith($"{tenPhim}-{phong}-")).ToList();
                            foreach (var ghe in ghePhim)
                            {
                                veBan++;
                                string seatKey = ghe.Split('-')[2];
                                doanhThu += GetSeatPrice(seatKey, giaChuan);
                            }
                        }

                        int veTon = tongGhe - veBan;
                        double tiLe = tongGhe > 0 ? (double)veBan / tongGhe * 100 : 0;
                        return (tenPhim, veBan, veTon, tiLe, doanhThu);
                    }).OrderByDescending(t => t.doanhThu).ToList();

                    using (StreamWriter sw = new(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("THỐNG KÊ PHÒNG VÉ\n");
                        int rank = 1;

                        foreach (var p in thongKe)
                        {
                            sw.WriteLine($"Hạng {rank++}: {p.tenPhim}");
                            sw.WriteLine($"  Vé bán: {p.veBan}");
                            sw.WriteLine($"  Vé tồn: {p.veTon}");
                            sw.WriteLine($"  Tỉ lệ bán: {p.tiLe:F2}%");
                            sw.WriteLine($"  Doanh thu: {p.doanhThu:N0} đ");

                            if (bookingHistory.ContainsKey(p.tenPhim))
                            {
                                sw.WriteLine($"\n  DANH SÁCH KHÁCH HÀNG:");
                                int customerIdx = 1;
                                foreach (var booking in bookingHistory[p.tenPhim])
                                {
                                    sw.WriteLine($"    {customerIdx}. Tên: {txtCustomName.Text.Trim()}");
                                    sw.WriteLine($"       Điện thoại: {booking.Item1.Phone}");
                                    sw.WriteLine($"       Email: {booking.Item1.Email}");
                                    sw.WriteLine($"       Ghế: {string.Join(", ", booking.Item2)}");
                                    customerIdx++;
                                }
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Đã xuất file thống kê thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try { System.Diagnostics.Process.Start("notepad.exe", sfd.FileName); } catch { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void panelSeats_Paint(object sender, PaintEventArgs e)
        {
            // Paint event
        }

        private void txtCustomName_TextChanged(object sender, EventArgs e)
        {
            // TextBox event
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // GroupBox event
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            // GroupBox event
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label event
        }
    }

    public class CustomerForm : Form
    {
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnOK;
        private Button btnCancel;

        public CustomerForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Nhập thông tin khách hàng";
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lblPhone = new Label
            {
                Text = "Số điện thoại:",
                Location = new Point(20, 30),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            txtPhone = new TextBox { Location = new Point(150, 25), Size = new Size(220, 25) };

            Label lblEmail = new Label
            {
                Text = "Email:",
                Location = new Point(20, 70),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            txtEmail = new TextBox { Location = new Point(150, 65), Size = new Size(220, 25) };

            btnOK = new Button
            {
                Text = "Đồng ý",
                Location = new Point(150, 120),
                Size = new Size(100, 35),
                DialogResult = DialogResult.OK,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            btnCancel = new Button
            {
                Text = "Hủy",
                Location = new Point(270, 120),
                Size = new Size(100, 35),
                DialogResult = DialogResult.Cancel,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            this.Controls.AddRange(new Control[]
            {
                lblPhone, txtPhone,
                lblEmail, txtEmail,
                btnOK, btnCancel
            });
        }

        public Customer GetCustomer()
        {
            return new Customer
            {
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };
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
        public int Price { get; set; }
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

    public class Customer
    {
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}