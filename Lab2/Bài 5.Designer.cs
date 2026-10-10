namespace Lab2
{
    partial class Bài_5
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
            lbThongTin = new Label();
            lbVe = new Label();
            lbTen = new Label();
            txtTen = new TextBox();
            lbPhim = new Label();
            lbPhongChieu = new Label();
            lbGhe = new Label();
            cbPhim = new ComboBox();
            cbPhong = new ComboBox();
            clbGhe = new CheckedListBox();
            btnThem = new Button();
            btnHuy = new Button();
            btnThanhToan = new Button();
            btnNap = new Button();
            btnXuat = new Button();
            pgrbTienTrinh = new ProgressBar();
            lbTienTrinh = new Label();
            rtxtThongKe = new RichTextBox();
            lbThongKe = new Label();
            lboVe = new ListBox();
            SuspendLayout();
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(235, 31);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(299, 38);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "QUẢN LÝ PHÒNG VÉ";
            // 
            // lbThongTin
            // 
            lbThongTin.AutoSize = true;
            lbThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThongTin.Location = new Point(70, 249);
            lbThongTin.Name = "lbThongTin";
            lbThongTin.Size = new Size(219, 28);
            lbThongTin.TabIndex = 1;
            lbThongTin.Text = "Thông tin khách hàng";
            // 
            // lbVe
            // 
            lbVe.AutoSize = true;
            lbVe.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVe.Location = new Point(528, 249);
            lbVe.Name = "lbVe";
            lbVe.Size = new Size(220, 28);
            lbVe.TabIndex = 2;
            lbVe.Text = "Danh sách vé đã chọn";
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTen.Location = new Point(34, 309);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(86, 28);
            lbTen.TabIndex = 3;
            lbTen.Text = "Họ tên: ";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(153, 309);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(150, 31);
            txtTen.TabIndex = 4;
            // 
            // lbPhim
            // 
            lbPhim.AutoSize = true;
            lbPhim.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhim.Location = new Point(34, 374);
            lbPhim.Name = "lbPhim";
            lbPhim.Size = new Size(108, 28);
            lbPhim.TabIndex = 5;
            lbPhim.Text = "Tên phim: ";
            // 
            // lbPhongChieu
            // 
            lbPhongChieu.AutoSize = true;
            lbPhongChieu.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhongChieu.Location = new Point(34, 441);
            lbPhongChieu.Name = "lbPhongChieu";
            lbPhongChieu.Size = new Size(138, 28);
            lbPhongChieu.TabIndex = 6;
            lbPhongChieu.Text = "Phòng chiếu: ";
            // 
            // lbGhe
            // 
            lbGhe.AutoSize = true;
            lbGhe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGhe.Location = new Point(38, 500);
            lbGhe.Name = "lbGhe";
            lbGhe.Size = new Size(107, 28);
            lbGhe.TabIndex = 7;
            lbGhe.Text = "Ghế ngồi: ";
            // 
            // cbPhim
            // 
            cbPhim.FormattingEnabled = true;
            cbPhim.Location = new Point(148, 374);
            cbPhim.Name = "cbPhim";
            cbPhim.Size = new Size(182, 33);
            cbPhim.TabIndex = 8;
            cbPhim.SelectedIndexChanged += cbPhim_SelectedIndexChanged;
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(178, 441);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(182, 33);
            cbPhong.TabIndex = 9;
            // 
            // clbGhe
            // 
            clbGhe.FormattingEnabled = true;
            clbGhe.Location = new Point(151, 503);
            clbGhe.Name = "clbGhe";
            clbGhe.Size = new Size(213, 144);
            clbGhe.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(70, 695);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 42);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm vé";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(329, 695);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 42);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy chọn";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.Location = new Point(586, 695);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(129, 42);
            btnThanhToan.TabIndex = 14;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnNap
            // 
            btnNap.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNap.Location = new Point(121, 104);
            btnNap.Name = "btnNap";
            btnNap.Size = new Size(152, 47);
            btnNap.TabIndex = 16;
            btnNap.Text = "Nạp dữ liệu";
            btnNap.UseVisualStyleBackColor = true;
            btnNap.Click += btnNap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuat.Location = new Point(511, 104);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(151, 47);
            btnXuat.TabIndex = 17;
            btnXuat.Text = "Xuất báo cáo";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // pgrbTienTrinh
            // 
            pgrbTienTrinh.Location = new Point(144, 176);
            pgrbTienTrinh.Name = "pgrbTienTrinh";
            pgrbTienTrinh.Size = new Size(604, 34);
            pgrbTienTrinh.TabIndex = 18;
            // 
            // lbTienTrinh
            // 
            lbTienTrinh.AutoSize = true;
            lbTienTrinh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTienTrinh.Location = new Point(38, 176);
            lbTienTrinh.Name = "lbTienTrinh";
            lbTienTrinh.Size = new Size(100, 28);
            lbTienTrinh.TabIndex = 19;
            lbTienTrinh.Text = "Tiến trình";
            // 
            // rtxtThongKe
            // 
            rtxtThongKe.Location = new Point(70, 828);
            rtxtThongKe.Name = "rtxtThongKe";
            rtxtThongKe.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtxtThongKe.Size = new Size(633, 185);
            rtxtThongKe.TabIndex = 20;
            rtxtThongKe.Text = "";
            // 
            // lbThongKe
            // 
            lbThongKe.AutoSize = true;
            lbThongKe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThongKe.Location = new Point(39, 774);
            lbThongKe.Name = "lbThongKe";
            lbThongKe.Size = new Size(99, 28);
            lbThongKe.TabIndex = 21;
            lbThongKe.Text = "Thống kê";
            // 
            // lboVe
            // 
            lboVe.FormattingEnabled = true;
            lboVe.Location = new Point(528, 309);
            lboVe.Name = "lboVe";
            lboVe.Size = new Size(220, 229);
            lboVe.TabIndex = 22;
            // 
            // Bài_5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1063);
            Controls.Add(lboVe);
            Controls.Add(lbThongKe);
            Controls.Add(rtxtThongKe);
            Controls.Add(lbTienTrinh);
            Controls.Add(pgrbTienTrinh);
            Controls.Add(btnXuat);
            Controls.Add(btnNap);
            Controls.Add(btnThanhToan);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(clbGhe);
            Controls.Add(cbPhong);
            Controls.Add(cbPhim);
            Controls.Add(lbGhe);
            Controls.Add(lbPhongChieu);
            Controls.Add(lbPhim);
            Controls.Add(txtTen);
            Controls.Add(lbTen);
            Controls.Add(lbVe);
            Controls.Add(lbThongTin);
            Controls.Add(lbTieuDe);
            Name = "Bài_5";
            Text = "Bài_5";
            Load += Bài_5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTieuDe;
        private Label lbThongTin;
        private Label lbVe;
        private Label lbTen;
        private TextBox txtTen;
        private Label lbPhim;
        private Label lbPhongChieu;
        private Label lbGhe;
        private ComboBox cbPhim;
        private ComboBox cbPhong;
        private CheckedListBox clbGhe;
        private Button btnThem;
        private Button btnHuy;
        private Button btnThanhToan;
        private Button btnNap;
        private Button btnXuat;
        private ProgressBar pgrbTienTrinh;
        private Label lbTienTrinh;
        private RichTextBox rtxtThongKe;
        private Label lbThongKe;
        private ListBox lboVe;
    }
}