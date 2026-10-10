namespace Lab2
{
    partial class Bài_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDoc = new Button();
            btnGhi = new Button();
            lbTieuDe = new Label();
            lbNoiDung = new Label();
            btnThoat = new Button();
            rtxtKetQua = new RichTextBox();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoc.Location = new Point(83, 105);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(112, 40);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "ĐỌC FILE";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGhi.Location = new Point(83, 237);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(112, 42);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "GHI FILE";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(271, 31);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(213, 38);
            lbTieuDe.TabIndex = 3;
            lbTieuDe.Text = "Ghi và Đọc file";
            // 
            // lbNoiDung
            // 
            lbNoiDung.AutoSize = true;
            lbNoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbNoiDung.Location = new Point(293, 90);
            lbNoiDung.Name = "lbNoiDung";
            lbNoiDung.Size = new Size(93, 28);
            lbNoiDung.TabIndex = 4;
            lbNoiDung.Text = "Nội dung";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(83, 360);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 42);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // rtxtKetQua
            // 
            rtxtKetQua.Location = new Point(293, 105);
            rtxtKetQua.Name = "rtxtKetQua";
            rtxtKetQua.Size = new Size(437, 297);
            rtxtKetQua.TabIndex = 7;
            rtxtKetQua.Text = "";
            // 
            // Bài_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNoiDung);
            Controls.Add(rtxtKetQua);
            Controls.Add(btnThoat);
            Controls.Add(lbTieuDe);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Name = "Bài_1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoc;
        private Button btnGhi;
        private Label lbTieuDe;
        private Label lbNoiDung;
        private Button btnThoat;
        private RichTextBox rtxtKetQua;
    }
}
