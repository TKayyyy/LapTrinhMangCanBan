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
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();

            // Thiết lập gợi ý cho TextBox input
            input.Text = "Ví dụ: Nguyễn Thị A, 7.5, 5, 8, 10, 9, 10, 8.5, 9, 10, 3.5, 5.5, 2";
            input.ForeColor = Color.Gray;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            if (input.ForeColor == Color.Gray)
            {
                input.Text = "";
                input.ForeColor = Color.Black;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = input.Text.Trim();

                if (string.IsNullOrEmpty(inputText) || input.ForeColor == Color.Gray)
                {
                    MessageBox.Show("Vui lòng nhập thông tin sinh viên!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string[] parts = inputText.Split(',');

                if (parts.Length < 2)
                {
                    MessageBox.Show("Định dạng sai!\n\nCần nhập: Họ tên, điểm1, điểm2, ...\nVí dụ: Nguyễn Văn A, 8, 9, 7",
                                    "Lỗi định dạng",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                string hoTen = parts[0].Trim();
                List<double> danhSachDiem = new List<double>();

                for (int i = 1; i < parts.Length; i++)
                {
                    string diemStr = parts[i].Trim();

                    if (string.IsNullOrEmpty(diemStr))
                        continue;

                    if (!double.TryParse(diemStr, out double diem))
                    {
                        MessageBox.Show($"Giá trị '{diemStr}' không phải là số hợp lệ!\n\nVui lòng kiểm tra lại định dạng.",
                                        "Sai format",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                    if (diem < 0 || diem > 10)
                    {
                        MessageBox.Show($"Điểm '{diem}' không hợp lệ!\n\nĐiểm phải trong khoảng từ 0 đến 10.",
                                        "Sai format",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                    danhSachDiem.Add(diem);
                }

                if (danhSachDiem.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy điểm hợp lệ nào!",
                                    "Lỗi dữ liệu",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }


                double diemTrungBinh = danhSachDiem.Average();
                double diemCaoNhat = danhSachDiem.Max();
                double diemThapNhat = danhSachDiem.Min();

                int soMonDau = danhSachDiem.Count(d => d >= 5);
                int soMonKhongDau = danhSachDiem.Count(d => d < 5);

                string xepLoai = XepLoaiSinhVien(diemTrungBinh, danhSachDiem);

                StringBuilder result = new StringBuilder();
                result.AppendLine("            KẾT QUẢ ĐIỂM SINH VIÊN");
                result.AppendLine();

                result.AppendLine($"Họ và tên: {hoTen}");
                result.AppendLine();


                result.AppendLine("Danh sách điểm:");
                for (int i = 0; i < danhSachDiem.Count; i++)
                {
                    result.AppendLine($"  Môn {i + 1}: {danhSachDiem[i]}");
                }
                result.AppendLine();

                result.AppendLine("                  THỐNG KÊ");
                result.AppendLine($"Điểm trung bình:     {diemTrungBinh:0.00}");
                result.AppendLine($"Điểm cao nhất:       {diemCaoNhat}");
                result.AppendLine($"Điểm thấp nhất:      {diemThapNhat}");
                result.AppendLine($"Số môn đậu (≥5):     {soMonDau}");
                result.AppendLine($"Số môn không đậu:    {soMonKhongDau}");
                result.AppendLine();
                result.AppendLine($"Xếp loại:            {xepLoai}");
                output.Text = result.ToString();
                output.ForeColor = Color.Black;


                MessageBox.Show("Đã xử lý thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private string XepLoaiSinhVien(double diemTB, List<double> danhSachDiem)
        {
            if (diemTB >= 8 && !danhSachDiem.Any(d => d < 6.5))
                return "Giỏi";

   
            if (diemTB >= 6.5 && !danhSachDiem.Any(d => d < 5))
                return "Khá";

            if (diemTB >= 5 && !danhSachDiem.Any(d => d < 3.5))
                return "Trung bình";

            if (diemTB >= 3.5 && !danhSachDiem.Any(d => d < 2))
                return "Yếu";
            return "Kém";
        }

        private void output_TextChanged(object sender, EventArgs e)
        {
        }

        private void Bai07_Load(object sender, EventArgs e)
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