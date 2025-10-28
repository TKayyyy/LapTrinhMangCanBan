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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(day.Text, out int ngay) ||
            !int.TryParse(month.Text, out int thang) ||
            !int.TryParse(year.Text, out int nam))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (nam % 4 == 0 && (nam % 100 != 0 || nam % 400 == 0))
            {
                daysInMonth[1] = 29;
            }

            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng phải từ 1 đến 12!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ngay < 1 || ngay > daysInMonth[thang - 1])
            {
                MessageBox.Show($"Ngày không hợp lệ! Tháng {thang} chỉ có {daysInMonth[thang - 1]} ngày.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((ngay >= 21 && thang == 3) || (ngay <= 20 && thang == 4))
            {
                output.Text = "Bạch Dương";
            }
            else if ((ngay >= 21 && thang == 4) || (ngay <= 21 && thang == 5))
            {
                output.Text = "Kim Ngưu";
            }
            else if ((ngay >= 22 && thang == 5) || (ngay <= 21 && thang == 6))
            {
                output.Text = "Song Tử";
            }
            else if ((ngay >= 22 && thang == 6) || (ngay <= 22 && thang == 7))
            {
                output.Text = "Cự Giải";
            }
            else if ((ngay >= 23 && thang == 7) || (ngay <= 22 && thang == 8))
            {
                output.Text = "Sư Tử";
            }
            else if ((ngay >= 23 && thang == 8) || (ngay <= 22 && thang == 9))
            {
                output.Text = "Xử Nữ";
            }
            else if ((ngay >= 23 && thang == 9) || (ngay <= 23 && thang == 10))
            {
                output.Text = "Thiên Bình";
            }
            else if ((ngay >= 24 && thang == 10) || (ngay <= 22 && thang == 11))
            {
                output.Text = "Bọ Cạp";
            }
            else if ((ngay >= 23 && thang == 11) || (ngay <= 21 && thang == 12))
            {
                output.Text = "Nhân Mã";
            }
            else if ((ngay >= 22 && thang == 12) || (ngay <= 19 && thang == 1))
            {
                output.Text = "Ma Kết";
            }
            else if ((ngay >= 20 && thang == 1) || (ngay <= 18 && thang == 2))
            {
                output.Text = "Bảo Bình";
            }
            else if ((ngay >= 19 && thang == 2) || (ngay <= 20 && thang == 3))
            {
                output.Text = "Song Ngư";
            }
            else
            {
                output.Text = "Ngày tháng không hợp lệ";
            }
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_TextChanged(object sender, EventArgs e)
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
