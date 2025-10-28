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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Option_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tinhtoan_Click(object sender, EventArgs e)
        {
            int num1, num2;

            if (!int.TryParse(Num1.Text.Trim(), out num1) || !int.TryParse(Num2.Text.Trim(), out num2))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                if (Option.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phép tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (num1 <= 0 || num2 <= 0)
            {
                MessageBox.Show("Vui lòng nhập các số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int res = num2 - num1;
            string bangcuuchuong = Option.SelectedItem.ToString().Trim();

            if (bangcuuchuong == "Bảng cửu chương")
            {
                if (num2 < num1)
                {
                    MessageBox.Show("Số thứ hai phải lớn hơn số thứ nhất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Ketqua.Text = "";
                for (int i = 1; i <= 10; i++)
                {
                    Ketqua.Text += $"{res} x {i} = {i * res}\r\n";
                }
            } else if (bangcuuchuong == "Tính toán")
            {
                if (num1 < num2)
                {
                    MessageBox.Show("Số thứ nhất phải lớn hơn số thứ hai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int it = 1;
                for (int i = 1; i <= (num1 - num2); i++)
                {
                    it *= i;
                }

                int somu = 0;
                for (int i = 1; i <= num2; i++)
                {
                    somu += (int)Math.Pow(num1, i);
                }
                Ketqua.Text = it.ToString();
                Ketqua.Text += "\r\n";
                Ketqua.Text += somu.ToString();

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lab01 lab01 = new Lab01();  // Tạo lại form 1
            lab01.Show();               // Hiện form 1
            this.Hide();
        }
    }
}
