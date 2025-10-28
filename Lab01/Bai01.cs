using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Homework
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }
        private Point[] nodes;

        private void Sum_Click(object sender, EventArgs e)
        {
            try
            {
                if (!long.TryParse(input1.Text.Trim(), out _))
                {
                    MessageBox.Show("Ô 1 phải là số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input1.Focus();
                    input1.SelectAll();
                    return;
                }
                if (!long.TryParse(input2.Text.Trim(), out _))
                {
                    MessageBox.Show("Ô 2 phải là số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input2.Focus();
                    input2.SelectAll();
                    return;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số quá lớn hoặc quá nhỏ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                long num1 = Convert.ToInt64(input1.Text.Trim());
                long num2 = Convert.ToInt64(input2.Text.Trim());
                long sum = num1 + num2;

                Output.Text = sum.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bai01_Load(object sender, EventArgs e)
        {
            //AttachKeyDownToTextBoxes(this);
        }

        private void AttachKeyDownToTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
                    // tránh gắn nhiều lần nếu chạy nhiều lần Load
                    tb.KeyDown -= TextBox_KeyDown_MoveNext;
                    tb.KeyDown += TextBox_KeyDown_MoveNext;
                }

                if (c.HasChildren)
                {
                    AttachKeyDownToTextBoxes(c);
                }
            }
        }

        private void TextBox_KeyDown_MoveNext(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // CHÍNH XÁC: SuppressKeyPress (không phải "Supperess...")
                // Di chuyển tới control kế tiếp theo thứ tự Tab
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void input1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!long.TryParse(input1.Text.Trim(), out _))
                {
                    MessageBox.Show("Ô 1 phải là số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input1.Focus();
                    input1.SelectAll();
                }
                else
                {
                    input2.Focus();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void input2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!long.TryParse(input2.Text.Trim(), out _))
                {
                    MessageBox.Show("Ô 2 phải là số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input2.Focus();
                    input2.SelectAll();
                }
                else
                {
                    Sum.PerformClick(); // tự động tính sum luôn
                }
                e.SuppressKeyPress = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lab01 lab01 = new Lab01();  // Tạo lại form 1
            lab01.Show();               // Hiện form 1
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            input1.Text = "";
            input2.Text = "";

            // Đưa con trỏ về ô đầu tiên
            input1.Focus();
        }
    }
}
