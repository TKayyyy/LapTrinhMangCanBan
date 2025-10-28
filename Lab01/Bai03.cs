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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(Nhap.Text.Trim(), out n))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nhap.Clear();
                Nhap.Focus();
                return;
            }

            if (n < 0 || n > 9)
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 9");
                Output.Clear();
                Nhap.Focus();
            }
            else
            {
                switch (n)
                {
                    case 0: Output.Text = "Không"; break;
                    case 1: Output.Text = "Một"; break;
                    case 2: Output.Text = "Hai"; break;
                    case 3: Output.Text = "Ba"; break;
                    case 4: Output.Text = "Bốn"; break;
                    case 5: Output.Text = "Năm"; break;
                    case 6: Output.Text = "Sáu"; break;
                    case 7: Output.Text = "Bảy"; break;
                    case 8: Output.Text = "Tám"; break;
                    case 9: Output.Text = "Chín"; break;
                }
            }
        }

        private void Nhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bai03_Load(object sender, EventArgs e)
        {
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lab01 lab01 = new Lab01();
            lab01.Show();
            this.Hide();
        }
    }
}
