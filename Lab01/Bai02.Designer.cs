namespace Homework
{
    partial class Bai02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai02));
            this.Find = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.Cyan;
            this.Find.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(169, 212);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(124, 53);
            this.Find.TabIndex = 0;
            this.Find.Text = "Tìm";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Cyan;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(349, 212);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(123, 53);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(517, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số thứ 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(343, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số thứ 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(514, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số thứ 3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(168, 142);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(125, 22);
            this.num1.TabIndex = 6;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.num1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num1_KeyDown);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(346, 142);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(126, 22);
            this.num2.TabIndex = 7;
            this.num2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.num2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num2_KeyDown);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(517, 142);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(115, 22);
            this.num3.TabIndex = 8;
            this.num3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.num3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num3_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lớn nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(475, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhỏ nhất";
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(208, 315);
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            this.Max.Size = new System.Drawing.Size(100, 22);
            this.Max.TabIndex = 11;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(606, 315);
            this.Min.Name = "Min";
            this.Min.ReadOnly = true;
            this.Min.Size = new System.Drawing.Size(100, 22);
            this.Min.TabIndex = 12;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(346, 381);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(113, 38);
            this.Back.TabIndex = 13;
            this.Back.Text = "Quay Lại";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Find);
            this.Name = "Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bai02";
            this.Load += new System.EventHandler(this.Bai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.Button Back;
    }
}