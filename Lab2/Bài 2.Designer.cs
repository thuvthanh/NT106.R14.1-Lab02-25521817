namespace Lab2
{
    partial class Bài_2
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
            lbTitle = new Label();
            btnDoc = new Button();
            lbTenFile = new Label();
            lbKichThuoc = new Label();
            lbURL = new Label();
            lbSoDong = new Label();
            lbSoTu = new Label();
            lbSoKyTu = new Label();
            lbNoiDung = new Label();
            rtxtNoiDung = new RichTextBox();
            txtTenFile = new TextBox();
            txtKichThuoc = new TextBox();
            txtURL = new TextBox();
            txtSoDong = new TextBox();
            txtSoTu = new TextBox();
            txtSoKyTu = new TextBox();
            btnThoat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(241, 44);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(0, 38);
            lbTitle.TabIndex = 0;
            // 
            // btnDoc
            // 
            btnDoc.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoc.Location = new Point(44, 124);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(112, 41);
            btnDoc.TabIndex = 1;
            btnDoc.Text = "ĐỌC FILE";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // lbTenFile
            // 
            lbTenFile.AutoSize = true;
            lbTenFile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenFile.Location = new Point(25, 203);
            lbTenFile.Name = "lbTenFile";
            lbTenFile.Size = new Size(78, 28);
            lbTenFile.TabIndex = 2;
            lbTenFile.Text = "Tên file";
            // 
            // lbKichThuoc
            // 
            lbKichThuoc.AutoSize = true;
            lbKichThuoc.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbKichThuoc.Location = new Point(25, 262);
            lbKichThuoc.Name = "lbKichThuoc";
            lbKichThuoc.Size = new Size(142, 28);
            lbKichThuoc.TabIndex = 3;
            lbKichThuoc.Text = "Kích thước file";
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbURL.Location = new Point(25, 320);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(48, 28);
            lbURL.TabIndex = 4;
            lbURL.Text = "URL";
            // 
            // lbSoDong
            // 
            lbSoDong.AutoSize = true;
            lbSoDong.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoDong.Location = new Point(25, 394);
            lbSoDong.Name = "lbSoDong";
            lbSoDong.Size = new Size(89, 28);
            lbSoDong.TabIndex = 5;
            lbSoDong.Text = "Số dòng";
            // 
            // lbSoTu
            // 
            lbSoTu.AutoSize = true;
            lbSoTu.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoTu.Location = new Point(25, 447);
            lbSoTu.Name = "lbSoTu";
            lbSoTu.Size = new Size(60, 28);
            lbSoTu.TabIndex = 6;
            lbSoTu.Text = "Số từ";
            // 
            // lbSoKyTu
            // 
            lbSoKyTu.AutoSize = true;
            lbSoKyTu.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoKyTu.Location = new Point(25, 506);
            lbSoKyTu.Name = "lbSoKyTu";
            lbSoKyTu.Size = new Size(87, 28);
            lbSoKyTu.TabIndex = 7;
            lbSoKyTu.Text = "Số ký tự";
            // 
            // lbNoiDung
            // 
            lbNoiDung.AutoSize = true;
            lbNoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbNoiDung.Location = new Point(397, 145);
            lbNoiDung.Name = "lbNoiDung";
            lbNoiDung.Size = new Size(93, 28);
            lbNoiDung.TabIndex = 8;
            lbNoiDung.Text = "Nội dung";
            // 
            // rtxtNoiDung
            // 
            rtxtNoiDung.Location = new Point(397, 176);
            rtxtNoiDung.Name = "rtxtNoiDung";
            rtxtNoiDung.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtxtNoiDung.Size = new Size(333, 361);
            rtxtNoiDung.TabIndex = 9;
            rtxtNoiDung.Text = "";
            // 
            // txtTenFile
            // 
            txtTenFile.Location = new Point(116, 203);
            txtTenFile.Name = "txtTenFile";
            txtTenFile.Size = new Size(234, 31);
            txtTenFile.TabIndex = 10;
            // 
            // txtKichThuoc
            // 
            txtKichThuoc.Location = new Point(173, 262);
            txtKichThuoc.Name = "txtKichThuoc";
            txtKichThuoc.Size = new Size(177, 31);
            txtKichThuoc.TabIndex = 11;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(93, 320);
            txtURL.Multiline = true;
            txtURL.Name = "txtURL";
            txtURL.ScrollBars = ScrollBars.Vertical;
            txtURL.Size = new Size(257, 45);
            txtURL.TabIndex = 12;
            // 
            // txtSoDong
            // 
            txtSoDong.Location = new Point(131, 394);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.Size = new Size(219, 31);
            txtSoDong.TabIndex = 13;
            // 
            // txtSoTu
            // 
            txtSoTu.Location = new Point(105, 447);
            txtSoTu.Name = "txtSoTu";
            txtSoTu.Size = new Size(245, 31);
            txtSoTu.TabIndex = 14;
            // 
            // txtSoKyTu
            // 
            txtSoKyTu.Location = new Point(128, 506);
            txtSoKyTu.Name = "txtSoKyTu";
            txtSoKyTu.Size = new Size(222, 31);
            txtSoKyTu.TabIndex = 15;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(322, 561);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 49);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 44);
            label1.Name = "label1";
            label1.Size = new Size(428, 38);
            label1.TabIndex = 17;
            label1.Text = "ĐỌC THÔNG TIN MỘT FILE.TXT";
            // 
            // Bài_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(txtSoKyTu);
            Controls.Add(txtSoTu);
            Controls.Add(txtSoDong);
            Controls.Add(txtURL);
            Controls.Add(txtKichThuoc);
            Controls.Add(txtTenFile);
            Controls.Add(lbNoiDung);
            Controls.Add(rtxtNoiDung);
            Controls.Add(lbSoKyTu);
            Controls.Add(lbSoTu);
            Controls.Add(lbSoDong);
            Controls.Add(lbURL);
            Controls.Add(lbKichThuoc);
            Controls.Add(lbTenFile);
            Controls.Add(btnDoc);
            Controls.Add(lbTitle);
            Name = "Bài_2";
            Text = "Bài_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btnDoc;
        private Label lbTenFile;
        private Label lbKichThuoc;
        private Label lbURL;
        private Label lbSoDong;
        private Label lbSoTu;
        private Label lbSoKyTu;
        private Label lbNoiDung;
        private RichTextBox rtxtNoiDung;
        private TextBox txtTenFile;
        private TextBox txtKichThuoc;
        private TextBox txtURL;
        private TextBox txtSoDong;
        private TextBox txtSoTu;
        private TextBox txtSoKyTu;
        private Button btnThoat;
        private Label label1;
    }
}