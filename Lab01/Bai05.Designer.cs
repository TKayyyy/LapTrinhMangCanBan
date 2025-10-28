namespace Homework
{
    partial class Bai05
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
            this.Tinhtoan = new System.Windows.Forms.Button();
            this.Option = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Ketqua = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tinhtoan
            // 
            this.Tinhtoan.BackColor = System.Drawing.Color.Cyan;
            this.Tinhtoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tinhtoan.Location = new System.Drawing.Point(74, 248);
            this.Tinhtoan.Name = "Tinhtoan";
            this.Tinhtoan.Size = new System.Drawing.Size(214, 47);
            this.Tinhtoan.TabIndex = 0;
            this.Tinhtoan.Text = "Tính các giá trị";
            this.Tinhtoan.UseVisualStyleBackColor = false;
            this.Tinhtoan.Click += new System.EventHandler(this.Tinhtoan_Click);
            // 
            // Option
            // 
            this.Option.FormattingEnabled = true;
            this.Option.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán"});
            this.Option.Location = new System.Drawing.Point(346, 176);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(157, 24);
            this.Option.TabIndex = 1;
            this.Option.SelectedIndexChanged += new System.EventHandler(this.Option_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Thứ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số thứ 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(568, 92);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 22);
            this.Num2.TabIndex = 4;
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(264, 92);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(100, 22);
            this.Num1.TabIndex = 5;
            // 
            // Ketqua
            // 
            this.Ketqua.Location = new System.Drawing.Point(346, 248);
            this.Ketqua.Multiline = true;
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.ReadOnly = true;
            this.Ketqua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ketqua.Size = new System.Drawing.Size(309, 175);
            this.Ketqua.TabIndex = 6;
            this.Ketqua.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(109, 346);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(97, 45);
            this.Back.TabIndex = 7;
            this.Back.Text = "Quay lại";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework.Properties.Resources._789jqk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.Tinhtoan);
            this.Name = "Bai05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tinhtoan;
        private System.Windows.Forms.ComboBox Option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Ketqua;
        private System.Windows.Forms.Button Back;
    }
}