namespace Lab02
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
            cboMovies = new ComboBox();
            panelSeats = new Panel();
            txtCustomName = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            lblSelectedSeats = new Label();
            lblTotalPrice = new Label();
            label1 = new Label();
            btnReset = new Button();
            btnConfirm = new Button();
            Back = new Button();
            Button_ImportFile = new Button();
            Button_ExportFile = new Button();
            ProgressBar = new ProgressBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cboMovies
            // 
            cboMovies.FormattingEnabled = true;
            cboMovies.Location = new Point(23, 49);
            cboMovies.Margin = new Padding(3, 4, 3, 4);
            cboMovies.Name = "cboMovies";
            cboMovies.Size = new Size(256, 36);
            cboMovies.TabIndex = 1;
            // 
            // panelSeats
            // 
            panelSeats.AutoScroll = true;
            panelSeats.BorderStyle = BorderStyle.FixedSingle;
            panelSeats.Location = new Point(637, 350);
            panelSeats.Margin = new Padding(3, 4, 3, 4);
            panelSeats.Name = "panelSeats";
            panelSeats.Size = new Size(558, 461);
            panelSeats.TabIndex = 3;
            panelSeats.Paint += panelSeats_Paint;
            // 
            // txtCustomName
            // 
            txtCustomName.Location = new Point(34, 279);
            txtCustomName.Margin = new Padding(3, 4, 3, 4);
            txtCustomName.Name = "txtCustomName";
            txtCustomName.Size = new Size(463, 34);
            txtCustomName.TabIndex = 4;
            txtCustomName.TextChanged += txtCustomName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 255);
            groupBox1.Controls.Add(cboMovies);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(74, 133);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(308, 118);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn Phim";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 255);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(391, 133);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(200, 209);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn phòng chiếu";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(15, 139);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(110, 32);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Phòng 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 89);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 32);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Phòng 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 41);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 32);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Phòng 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(128, 255, 255);
            groupBox3.Controls.Add(lblSelectedSeats);
            groupBox3.Controls.Add(lblTotalPrice);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnReset);
            groupBox3.Controls.Add(btnConfirm);
            groupBox3.Controls.Add(txtCustomName);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(74, 350);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(517, 461);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin đặt vé";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lblSelectedSeats
            // 
            lblSelectedSeats.AutoSize = true;
            lblSelectedSeats.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedSeats.Location = new Point(38, 62);
            lblSelectedSeats.Name = "lblSelectedSeats";
            lblSelectedSeats.Size = new Size(108, 23);
            lblSelectedSeats.TabIndex = 13;
            lblSelectedSeats.Text = "Ghế đã chọn";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(38, 180);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(104, 28);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.Text = "Tổng Tiền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 240);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 11;
            label1.Text = "Tên Khách Hàng";
            label1.Click += label1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(34, 351);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(113, 50);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(379, 351);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(113, 50);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += BtnConfirm_Click;
            Button_ExportFile.Click += Button_ExportFile_Click;
            // 
            // Back
            // 
            Back.Location = new Point(1272, 813);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(93, 64);
            Back.TabIndex = 10;
            Back.Text = "Quay lại";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Button_ImportFile
            // 
            Button_ImportFile.Location = new Point(74, 39);
            Button_ImportFile.Name = "Button_ImportFile";
            Button_ImportFile.Size = new Size(125, 45);
            Button_ImportFile.TabIndex = 11;
            Button_ImportFile.Text = "ImportFile";
            Button_ImportFile.UseVisualStyleBackColor = true;
            Button_ImportFile.Click += Button_ImportFile_Click;
            // 
            // Button_ExportFile
            // 
            Button_ExportFile.Location = new Point(466, 39);
            Button_ExportFile.Name = "Button_ExportFile";
            Button_ExportFile.Size = new Size(125, 45);
            Button_ExportFile.TabIndex = 12;
            Button_ExportFile.Text = "ExportFile";
            Button_ExportFile.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(74, 272);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(308, 46);
            ProgressBar.TabIndex = 13;
            ProgressBar.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Daophopiano;
            pictureBox1.Location = new Point(637, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 171);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Mai;
            pictureBox2.Location = new Point(848, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 171);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Chibau;
            pictureBox3.Location = new Point(1060, 133);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(170, 171);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Tarot;
            pictureBox4.Location = new Point(1260, 133);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(170, 171);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(937, 56);
            label2.Name = "label2";
            label2.Size = new Size(258, 41);
            label2.TabIndex = 18;
            label2.Text = "Các bộ phim hot";
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Anhnen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1511, 890);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ProgressBar);
            Controls.Add(Button_ExportFile);
            Controls.Add(Button_ImportFile);
            Controls.Add(Back);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panelSeats);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bai05";
            Text = "Bai05";
            Load += Bai05_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMovies;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSelectedSeats;
        private Button Button_ImportFile;
        private Button Button_ExportFile;
        private ProgressBar ProgressBar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
    }
}