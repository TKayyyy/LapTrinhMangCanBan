namespace Homework
{
    partial class Bai03
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
            this.Nhap = new System.Windows.Forms.TextBox();
            this.Tieude = new System.Windows.Forms.Label();
            this.Read = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Ketqua = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nhap
            // 
            this.Nhap.Location = new System.Drawing.Point(552, 128);
            this.Nhap.Name = "Nhap";
            this.Nhap.Size = new System.Drawing.Size(126, 22);
            this.Nhap.TabIndex = 0;
            this.Nhap.TextChanged += new System.EventHandler(this.Nhap_TextChanged);
            // 
            // Tieude
            // 
            this.Tieude.AutoSize = true;
            this.Tieude.BackColor = System.Drawing.Color.Transparent;
            this.Tieude.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tieude.ForeColor = System.Drawing.Color.White;
            this.Tieude.Location = new System.Drawing.Point(63, 120);
            this.Tieude.Name = "Tieude";
            this.Tieude.Size = new System.Drawing.Size(424, 38);
            this.Tieude.TabIndex = 1;
            this.Tieude.Text = "Nhập các số nguyên từ 0 đến 9";
            this.Tieude.Click += new System.EventHandler(this.label1_Click);
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.Color.Cyan;
            this.Read.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read.Location = new System.Drawing.Point(586, 303);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(109, 49);
            this.Read.TabIndex = 2;
            this.Read.Text = "Đọc";
            this.Read.UseVisualStyleBackColor = false;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(387, 230);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(149, 22);
            this.Output.TabIndex = 3;
            // 
            // Ketqua
            // 
            this.Ketqua.AutoSize = true;
            this.Ketqua.BackColor = System.Drawing.Color.Transparent;
            this.Ketqua.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ketqua.ForeColor = System.Drawing.Color.White;
            this.Ketqua.Location = new System.Drawing.Point(139, 222);
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.Size = new System.Drawing.Size(118, 38);
            this.Ketqua.TabIndex = 4;
            this.Ketqua.Text = "Kết quả";
            this.Ketqua.Click += new System.EventHandler(this.label2_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(146, 303);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(111, 49);
            this.Back.TabIndex = 5;
            this.Back.Text = "Quay lại";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework.Properties.Resources._789jqk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Tieude);
            this.Controls.Add(this.Nhap);
            this.Name = "Bai03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bai03";
            this.Load += new System.EventHandler(this.Bai03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nhap;
        private System.Windows.Forms.Label Tieude;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label Ketqua;
        private System.Windows.Forms.Button Back;
    }
}