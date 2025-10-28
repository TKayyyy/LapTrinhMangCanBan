using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Bai08 : Form
    {
        private string danhSachMonAn = "";
        private Random random = new Random();

        public Bai08()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
        }
        private void Them_Click(object sender, EventArgs e)
        {
            string monAnMoi = input1.Text.Trim();

            if (string.IsNullOrEmpty(monAnMoi))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(danhSachMonAn))
            {
                string[] cacMonAn = danhSachMonAn.Split(';');
                if (cacMonAn.Contains(monAnMoi))
                {
                    MessageBox.Show("Món ăn này đã có trong danh sách!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (string.IsNullOrEmpty(danhSachMonAn))
            {
                danhSachMonAn = monAnMoi;
            }
            else
            {
                danhSachMonAn += ";" + monAnMoi;
            }
            CapNhatDanhSach();

            input1.Clear();

            MessageBox.Show($"Đã thêm món '{monAnMoi}' vào danh sách!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Findfood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(danhSachMonAn))
            {
                MessageBox.Show("Danh sách món ăn trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] cacMonAn = danhSachMonAn.Split(';');

            int viTriNgauNhien = random.Next(0, cacMonAn.Length);
            string monAnDuocChon = cacMonAn[viTriNgauNhien];


            output.Text = monAnDuocChon;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string monAnCanXoa = output.Text.Trim();

            if (string.IsNullOrEmpty(monAnCanXoa))
            {
                MessageBox.Show("Chưa có món ăn nào được chọn để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string[] cacMonAn = danhSachMonAn.Split(';');
            List<string> danhSachMoi = new List<string>();


            foreach (string mon in cacMonAn)
            {
                if (mon != monAnCanXoa)
                {
                    danhSachMoi.Add(mon);
                }
            }


            if (danhSachMoi.Count == cacMonAn.Length)
            {
                MessageBox.Show("Không tìm thấy món ăn này trong danh sách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

 
            danhSachMonAn = string.Join(";", danhSachMoi);


            CapNhatDanhSach();
            output.Clear();

            MessageBox.Show($"Đã xóa món '{monAnCanXoa}' khỏi danh sách!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void CapNhatDanhSach()
        {
            if (!string.IsNullOrEmpty(danhSachMonAn))
            {

                string[] cacMonAn = danhSachMonAn.Split(';');
                input2.Text = string.Join(Environment.NewLine, cacMonAn);
            }
            else
            {
                input2.Text = "";
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            string monAnMoi = input1.Text.Trim();

            if (string.IsNullOrEmpty(monAnMoi))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!string.IsNullOrEmpty(danhSachMonAn))
            {
                string[] cacMonAn = danhSachMonAn.Split(';');
                if (cacMonAn.Contains(monAnMoi))
                {
                    MessageBox.Show("Món ăn này đã có trong danh sách!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            if (string.IsNullOrEmpty(danhSachMonAn))
            {
                danhSachMonAn = monAnMoi;
            }
            else
            {
                danhSachMonAn += ";" + monAnMoi;
            }

            CapNhatDanhSach();

            input1.Clear();
            input1.Focus();
        }

        private void Bai08_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lab01 lab01 = new Lab01();  // Tạo lại form 1
            lab01.Show();               // Hiện form 1
            this.Hide();
        }
    }
}