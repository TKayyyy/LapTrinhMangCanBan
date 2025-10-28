namespace Homework
{
    partial class Bai08
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
            this.label1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.TextBox();
            this.Findfood = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập món ăn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(256, 66);
            this.input1.Multiline = true;
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(206, 35);
            this.input1.TabIndex = 1;
            this.input1.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Cyan;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(349, 129);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(113, 40);
            this.Add.TabIndex = 2;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(498, 68);
            this.input2.Multiline = true;
            this.input2.Name = "input2";
            this.input2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input2.Size = new System.Drawing.Size(268, 167);
            this.input2.TabIndex = 3;
            this.input2.TextChanged += new System.EventHandler(this.input2_TextChanged);
            // 
            // Findfood
            // 
            this.Findfood.BackColor = System.Drawing.Color.Cyan;
            this.Findfood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findfood.Location = new System.Drawing.Point(109, 260);
            this.Findfood.Name = "Findfood";
            this.Findfood.Size = new System.Drawing.Size(156, 55);
            this.Findfood.TabIndex = 4;
            this.Findfood.Text = "Tìm món ăn";
            this.Findfood.UseVisualStyleBackColor = false;
            this.Findfood.Click += new System.EventHandler(this.Findfood_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Cyan;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(349, 261);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(134, 53);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Cyan;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(563, 261);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(141, 52);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Món ăn hôm nay là";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(301, 390);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(225, 22);
            this.output.TabIndex = 8;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(636, 365);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 47);
            this.Back.TabIndex = 9;
            this.Back.Text = "Quay lại";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework.Properties.Resources._789jqk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Findfood);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label1);
            this.Name = "Bai08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bai08";
            this.Load += new System.EventHandler(this.Bai08_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button Findfood;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button Back;
    }
}