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

namespace Homework
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();


            this.DoubleBuffered = true;
            Button[] buttons = { Bai01, Bai02, Bai03, Bai04, Bai05, Bai06, Bai07, Bai08 };
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
            // Tạo các điểm node ngẫu nhiên
            nodes = new Point[30];
            Random rand = new Random();
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new Point(rand.Next(this.Width), rand.Next(this.Height));
            }
        }

        // Thêm biến này ở đầu class
        private Point[] nodes;

        // Override phương thức OnPaint để vẽ background
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        //    // Vẽ background màu tối với gradient
        //    using (LinearGradientBrush bgBrush = new LinearGradientBrush(
        //        this.ClientRectangle,
        //        Color.FromArgb(15, 32, 48),
        //        Color.FromArgb(8, 20, 35),
        //        45f))
        //    {
        //        g.FillRectangle(bgBrush, this.ClientRectangle);
        //    }

        //    // Vẽ các đường nối giữa các node
        //    using (Pen linePen = new Pen(Color.FromArgb(40, 100, 150, 200), 1))
        //    {
        //        for (int i = 0; i < nodes.Length; i++)
        //        {
        //            for (int j = i + 1; j < nodes.Length; j++)
        //            {
        //                float distance = (float)Math.Sqrt(
        //                    Math.Pow(nodes[i].X - nodes[j].X, 2) +
        //                    Math.Pow(nodes[i].Y - nodes[j].Y, 2));

        //                if (distance < 200)
        //                {
        //                    int alpha = (int)(40 * (1 - distance / 200));
        //                    linePen.Color = Color.FromArgb(alpha, 100, 180, 220);
        //                    g.DrawLine(linePen, nodes[i], nodes[j]);
        //                }
        //            }
        //        }
        //    }

        //    // Vẽ các node (điểm sáng)
        //    for (int i = 0; i < nodes.Length; i++)
        //    {
        //        // Hiệu ứng phát sáng
        //        using (PathGradientBrush glowBrush = new PathGradientBrush(
        //            new PointF[] {
        //        new PointF(nodes[i].X - 10, nodes[i].Y - 10),
        //        new PointF(nodes[i].X + 10, nodes[i].Y - 10),
        //        new PointF(nodes[i].X + 10, nodes[i].Y + 10),
        //        new PointF(nodes[i].X - 10, nodes[i].Y + 10)
        //            }))
        //        {
        //            glowBrush.CenterColor = Color.FromArgb(180, 100, 200, 255);
        //            glowBrush.SurroundColors = new Color[] { Color.FromArgb(0, 100, 200, 255) };
        //            g.FillEllipse(glowBrush, nodes[i].X - 10, nodes[i].Y - 10, 20, 20);
        //        }

        //        // Node trung tâm
        //        g.FillEllipse(Brushes.Cyan, nodes[i].X - 3, nodes[i].Y - 3, 6, 6);
        //    }
        //}

        private void Bai01_Click(object sender, EventArgs e)
        {
            Bai01 bai01 = new Bai01();
            this.Hide();
            bai01.Show();
        }
        private void Bai02_Click(object sender, EventArgs e)
        {
            Bai02 bai02 = new Bai02();
            this.Hide();
            bai02.Show();
        }

        private void Bai03_Click(object sender, EventArgs e)
        {
            Bai03 bai03 = new Bai03();
            this.Hide();
            bai03.Show();
        }

        private void Bai04_Click(object sender, EventArgs e)
        {
            Bai04 bai04 = new Bai04();
            this.Hide();
            bai04.Show();
        }

        private void Bai031_Click(object sender, EventArgs e)
        {
            Bai031 bai031 = new Bai031();
            this.Hide();
            bai031.Show();
        }

        private void Bai08_Click(object sender, EventArgs e)
        {
            Bai08 bai08 = new Bai08();
            this.Hide();
            bai08.Show();
        }

        private void Bai05_Click(object sender, EventArgs e)
        {
            Bai05 bai05 = new Bai05();
            this.Hide();
            bai05.Show();
        }

        private void Bai07_Click(object sender, EventArgs e)
        {
            Bai07 bai07 = new Bai07();
            this.Hide();
            bai07.Show();
        }

        private void Bai06_Click(object sender, EventArgs e)
        {
            Bai06 bai06 = new Bai06();
            this.Hide();
            bai06.Show();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }
    }
}
