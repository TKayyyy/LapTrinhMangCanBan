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
    public partial class Bai031 : Form
    {
        public Bai031()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
        }

        private void Read_Click(object sender, EventArgs e)
        {
            try
            {
                string input_text = input.Text.Trim();

                if (string.IsNullOrEmpty(input_text))
                {
                    MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (input_text.Length > 12)
                {
                    MessageBox.Show("Số không được quá 12 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
        
                string result = DocSo(input_text);

                output.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập đúng số tự nhiên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DocSo(string so)
        {

            if (long.Parse(so) == 0)
                return "Không";
            so = so.PadLeft(12, '0');
            string ty = so.Substring(0, 3);
            string trieu = so.Substring(3, 3);
            string nghin = so.Substring(6, 3);
            string donvi = so.Substring(9, 3);

            string result = "";
            if (int.Parse(ty) > 0)
            {
                result += DocBaNSo(ty) + " tỷ";
            }
            if (int.Parse(trieu) > 0)
            {
                result += (result != "" ? " " : "") + DocBaNSo(trieu) + " triệu";
            }
            else if (result != "" && (int.Parse(nghin) > 0 || int.Parse(donvi) > 0))
            {

            }

            if (int.Parse(nghin) > 0)
            {
                result += (result != "" ? " " : "") + DocBaNSo(nghin) + " nghìn";
            }
            else if (result != "" && int.Parse(donvi) > 0)
            {
  
            }

            if (int.Parse(donvi) > 0)
            {
                result += (result != "" ? " " : "") + DocBaNSo(donvi);
            }

            if (result.Length > 0)
            {
                result = char.ToUpper(result[0]) + result.Substring(1);
            }

            return result;
        }

        private string DocBaNSo(string ba_so)
        {
            string[] so_chu = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            int tram = int.Parse(ba_so[0].ToString());
            int chuc = int.Parse(ba_so[1].ToString());
            int donvi = int.Parse(ba_so[2].ToString());

            string result = "";


            if (tram > 0)
            {
                result = so_chu[tram] + " trăm";
            }

  
            if (chuc > 1)
            {
                result += (result != "" ? " " : "") + so_chu[chuc] + " mươi";

                if (donvi == 1)
                {
                    result += " mốt";
                }
                else if (donvi == 5)
                {
                    result += " lăm";
                }
                else if (donvi > 0)
                {
                    result += " " + so_chu[donvi];
                }
            }
            else if (chuc == 1)
            {
                result += (result != "" ? " " : "") + "mười";

                if (donvi == 5)
                {
                    result += " lăm";
                }
                else if (donvi > 0)
                {
                    result += " " + so_chu[donvi];
                }
            }
            else
            {
                if (donvi > 0 && result != "")
                {
                    result += " lẻ " + so_chu[donvi];
                }
                else if (donvi > 0)
                {
                    result = so_chu[donvi];
                }
            }


            return result;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lab01 lab01 = new Lab01();  // Tạo lại form 1
            lab01.Show();               // Hiện form 1
            this.Hide();
        }
    }
}