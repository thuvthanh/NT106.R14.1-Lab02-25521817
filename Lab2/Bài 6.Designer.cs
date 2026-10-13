namespace Lab2
{
    partial class Bài_6
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
            lbTieuDe = new Label();
            btnThucDon = new Button();
            btnChon = new Button();
            lboThucDon = new ListBox();
            lbThucDon = new Label();
            lbChon = new Label();
            lbMon = new Label();
            lbNguoi = new Label();
            txtMon = new TextBox();
            txtNguoi = new TextBox();
            lbHinh = new Label();
            picHinh = new PictureBox();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)picHinh).BeginInit();
            SuspendLayout();
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTieuDe.ForeColor = Color.SaddleBrown;
            lbTieuDe.Location = new Point(261, 46);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(259, 38);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "HÔM NAY ĂN GÌ?";
            // 
            // btnThucDon
            // 
            btnThucDon.BackColor = Color.PeachPuff;
            btnThucDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnThucDon.ForeColor = Color.SaddleBrown;
            btnThucDon.Location = new Point(117, 119);
            btnThucDon.Name = "btnThucDon";
            btnThucDon.Size = new Size(128, 43);
            btnThucDon.TabIndex = 1;
            btnThucDon.Text = "Thực đơn";
            btnThucDon.UseVisualStyleBackColor = false;
            btnThucDon.Click += btnThucDon_Click;
            // 
            // btnChon
            // 
            btnChon.BackColor = Color.IndianRed;
            btnChon.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChon.ForeColor = Color.White;
            btnChon.Location = new Point(463, 119);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(189, 43);
            btnChon.TabIndex = 2;
            btnChon.Text = "Hôm nay ăn gì?";
            btnChon.UseVisualStyleBackColor = false;
            btnChon.Click += btnChon_Click;
            // 
            // lboThucDon
            // 
            lboThucDon.BackColor = Color.LemonChiffon;
            lboThucDon.FormattingEnabled = true;
            lboThucDon.Location = new Point(83, 217);
            lboThucDon.Name = "lboThucDon";
            lboThucDon.Size = new Size(208, 154);
            lboThucDon.TabIndex = 3;
            // 
            // lbThucDon
            // 
            lbThucDon.AutoSize = true;
            lbThucDon.BackColor = Color.SandyBrown;
            lbThucDon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThucDon.Location = new Point(83, 186);
            lbThucDon.Name = "lbThucDon";
            lbThucDon.Size = new Size(182, 28);
            lbThucDon.TabIndex = 4;
            lbThucDon.Text = "Danh sách món ăn";
            // 
            // lbChon
            // 
            lbChon.AutoSize = true;
            lbChon.BackColor = Color.SandyBrown;
            lbChon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbChon.Location = new Point(313, 432);
            lbChon.Name = "lbChon";
            lbChon.Size = new Size(177, 28);
            lbChon.TabIndex = 5;
            lbChon.Text = "Thông tin món ăn";
            // 
            // lbMon
            // 
            lbMon.AutoSize = true;
            lbMon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbMon.Location = new Point(187, 485);
            lbMon.Name = "lbMon";
            lbMon.Size = new Size(119, 28);
            lbMon.TabIndex = 6;
            lbMon.Text = "Tên món ăn";
            // 
            // lbNguoi
            // 
            lbNguoi.AutoSize = true;
            lbNguoi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbNguoi.Location = new Point(187, 585);
            lbNguoi.Name = "lbNguoi";
            lbNguoi.Size = new Size(156, 28);
            lbNguoi.TabIndex = 7;
            lbNguoi.Text = "Người đóng góp";
            // 
            // txtMon
            // 
            txtMon.BackColor = Color.LemonChiffon;
            txtMon.Location = new Point(290, 516);
            txtMon.Name = "txtMon";
            txtMon.ReadOnly = true;
            txtMon.Size = new Size(230, 31);
            txtMon.TabIndex = 8;
            // 
            // txtNguoi
            // 
            txtNguoi.BackColor = Color.LemonChiffon;
            txtNguoi.Location = new Point(290, 616);
            txtNguoi.Name = "txtNguoi";
            txtNguoi.ReadOnly = true;
            txtNguoi.Size = new Size(230, 31);
            txtNguoi.TabIndex = 9;
            // 
            // lbHinh
            // 
            lbHinh.AutoSize = true;
            lbHinh.BackColor = Color.SandyBrown;
            lbHinh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHinh.Location = new Point(365, 186);
            lbHinh.Name = "lbHinh";
            lbHinh.Size = new Size(171, 28);
            lbHinh.TabIndex = 10;
            lbHinh.Text = "Hình ảnh món ăn";
            // 
            // picHinh
            // 
            picHinh.Location = new Point(365, 217);
            picHinh.Name = "picHinh";
            picHinh.Size = new Size(350, 180);
            picHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinh.TabIndex = 11;
            picHinh.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(341, 697);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 45);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bài_6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 764);
            Controls.Add(btnThoat);
            Controls.Add(picHinh);
            Controls.Add(lbHinh);
            Controls.Add(txtNguoi);
            Controls.Add(txtMon);
            Controls.Add(lbNguoi);
            Controls.Add(lbMon);
            Controls.Add(lbChon);
            Controls.Add(lbThucDon);
            Controls.Add(lboThucDon);
            Controls.Add(btnChon);
            Controls.Add(btnThucDon);
            Controls.Add(lbTieuDe);
            Name = "Bài_6";
            Text = "Bài_6";
            Load += Bài_6_Load;
            ((System.ComponentModel.ISupportInitialize)picHinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTieuDe;
        private Button btnThucDon;
        private Button btnChon;
        private ListBox lboThucDon;
        private Label lbThucDon;
        private Label lbChon;
        private Label lbMon;
        private Label lbNguoi;
        private TextBox txtMon;
        private TextBox txtNguoi;
        private Label lbHinh;
        private PictureBox picHinh;
        private Button btnThoat;
    }
}