namespace Homework
{
    partial class Bai01
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
            this.Sum = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.Debai = new System.Windows.Forms.Label();
            this.Ketqua = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sum
            // 
            this.Sum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Sum.BackColor = System.Drawing.Color.Cyan;
            this.Sum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sum.Location = new System.Drawing.Point(577, 353);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(135, 51);
            this.Sum.TabIndex = 0;
            this.Sum.Text = "Kết quả";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(410, 116);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(175, 38);
            this.input1.TabIndex = 1;
            this.input1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input1_KeyDown);
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(410, 195);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(175, 38);
            this.input2.TabIndex = 2;
            this.input2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input2_KeyDown);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.Window;
            this.num1.Location = new System.Drawing.Point(219, 119);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(129, 38);
            this.num1.TabIndex = 3;
            this.num1.Text = "Số thứ 1";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.Color.Transparent;
            this.num2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.Color.White;
            this.num2.Location = new System.Drawing.Point(219, 198);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(129, 38);
            this.num2.TabIndex = 4;
            this.num2.Text = "Số thứ 2";
            this.num2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Debai
            // 
            this.Debai.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Debai.AutoSize = true;
            this.Debai.BackColor = System.Drawing.Color.Transparent;
            this.Debai.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debai.ForeColor = System.Drawing.Color.White;
            this.Debai.Location = new System.Drawing.Point(233, 26);
            this.Debai.Name = "Debai";
            this.Debai.Size = new System.Drawing.Size(347, 41);
            this.Debai.TabIndex = 5;
            this.Debai.Text = "Tính tổng 2 số nguyên";
            // 
            // Ketqua
            // 
            this.Ketqua.AutoSize = true;
            this.Ketqua.BackColor = System.Drawing.Color.Transparent;
            this.Ketqua.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ketqua.ForeColor = System.Drawing.Color.White;
            this.Ketqua.Location = new System.Drawing.Point(219, 286);
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.Size = new System.Drawing.Size(122, 38);
            this.Ketqua.TabIndex = 7;
            this.Ketqua.Text = "Kết Quả";
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(410, 286);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(175, 38);
            this.Output.TabIndex = 8;
            // 
            // Back
            // 
            this.Back.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Back.Location = new System.Drawing.Point(135, 360);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(96, 39);
            this.Back.TabIndex = 9;
            this.Back.Text = "Quay lại";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(806, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(352, 360);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(98, 38);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Bai01
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework.Properties.Resources._789jqk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.Debai);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.Sum);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Bai01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bai01";
            this.Load += new System.EventHandler(this.Bai01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label Debai;
        private System.Windows.Forms.Label Ketqua;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Delete;
    }
}