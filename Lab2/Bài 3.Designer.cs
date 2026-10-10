namespace Lab2
{
    partial class Bài_3
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
            btnDoc = new Button();
            btnTinh = new Button();
            btnGhi = new Button();
            btnThoat = new Button();
            rtxtKetQua = new RichTextBox();
            SuspendLayout();
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(177, 50);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(429, 38);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "ĐỌC, GHI FILE VÀ TÍNH TOÁN";
            // 
            // btnDoc
            // 
            btnDoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoc.Location = new Point(38, 369);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(112, 42);
            btnDoc.TabIndex = 1;
            btnDoc.Text = "ĐỌC";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinh.Location = new Point(238, 369);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(112, 42);
            btnTinh.TabIndex = 2;
            btnTinh.Text = "TÍNH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnGhi
            // 
            btnGhi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGhi.Location = new Point(449, 369);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(112, 42);
            btnGhi.TabIndex = 3;
            btnGhi.Text = "GHI";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(643, 369);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 42);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // rtxtKetQua
            // 
            rtxtKetQua.Location = new Point(87, 125);
            rtxtKetQua.Name = "rtxtKetQua";
            rtxtKetQua.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtxtKetQua.Size = new Size(615, 183);
            rtxtKetQua.TabIndex = 5;
            rtxtKetQua.Text = "";
            // 
            // Bài_3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtxtKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnGhi);
            Controls.Add(btnTinh);
            Controls.Add(btnDoc);
            Controls.Add(lbTieuDe);
            Name = "Bài_3";
            Text = "Bài_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTieuDe;
        private Button btnDoc;
        private Button btnTinh;
        private Button btnGhi;
        private Button btnThoat;
        private RichTextBox rtxtKetQua;
    }
}