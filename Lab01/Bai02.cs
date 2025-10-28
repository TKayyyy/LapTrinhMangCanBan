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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            double number1, number2, number3, max, min;

            number1 = Convert.ToDouble(num1.Text.Trim());
            number2 = Convert.ToDouble(num2.Text.Trim());
            number3 = Convert.ToDouble(num3.Text.Trim());

            max = Math.Max(number1, Math.Max(number2, number3));
            min = Math.Min(number1, Math.Min(number2, number3));
            Max.Text = max.ToString();
            Min.Text = min.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            num3.Text = "";
            num1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void num1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (!double.TryParse(num1.Text.Trim(), out _))
                {
                    MessageBox.Show("Ô 1 phải là số thực!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    num1.Focus();
                    num1.SelectAll();
                }
                else
                {
                    num2.Focus();
                }
            }
        }

        private void num2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (!double.TryParse(num2.Text.Trim(), out _))
                {
                    MessageBox.Show("Ô 2 phải là số thực!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    num2.Focus();
                    num2.SelectAll();
                }
                else
                {
                    num3.Focus();
                } 
                
            }
        }

        private void num3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (!double.TryParse(num3.Text.Trim(), out _))
                {
                    MessageBox.Show("Ô 3 phải là số thực!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    num3.Focus();
                    num3.SelectAll();
                }
                else
                {
                    Find.PerformClick();
                }
            }
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
