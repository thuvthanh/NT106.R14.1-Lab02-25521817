namespace Lab2
{
    partial class Bài_7
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
            rtxtNoiDung = new RichTextBox();
            lbNoiDung = new Label();
            lboThuMuc = new ListBox();
            lbDuonngDan = new Label();
            txtDuongDan = new TextBox();
            picNoiDung = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picNoiDung).BeginInit();
            SuspendLayout();
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTieuDe.Location = new Point(41, 37);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(259, 38);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "DUYỆT THƯ MỤC";
            // 
            // rtxtNoiDung
            // 
            rtxtNoiDung.Location = new Point(483, 224);
            rtxtNoiDung.Name = "rtxtNoiDung";
            rtxtNoiDung.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtxtNoiDung.Size = new Size(312, 200);
            rtxtNoiDung.TabIndex = 2;
            rtxtNoiDung.Text = "";
            // 
            // lbNoiDung
            // 
            lbNoiDung.AutoSize = true;
            lbNoiDung.Location = new Point(483, 193);
            lbNoiDung.Name = "lbNoiDung";
            lbNoiDung.Size = new Size(98, 28);
            lbNoiDung.TabIndex = 3;
            lbNoiDung.Text = "Nội dung";
            // 
            // lboThuMuc
            // 
            lboThuMuc.FormattingEnabled = true;
            lboThuMuc.HorizontalScrollbar = true;
            lboThuMuc.Location = new Point(41, 224);
            lboThuMuc.Name = "lboThuMuc";
            lboThuMuc.ScrollAlwaysVisible = true;
            lboThuMuc.Size = new Size(372, 200);
            lboThuMuc.TabIndex = 4;
            lboThuMuc.SelectedIndexChanged += lboThuMuc_SelectedIndexChanged;
            lboThuMuc.DoubleClick += lboThuMuc_DoubleClick;
            // 
            // lbDuonngDan
            // 
            lbDuonngDan.AutoSize = true;
            lbDuonngDan.Location = new Point(41, 110);
            lbDuonngDan.Name = "lbDuonngDan";
            lbDuonngDan.Size = new Size(188, 28);
            lbDuonngDan.TabIndex = 5;
            lbDuonngDan.Text = "Đường dẫn hiện tại";
            // 
            // txtDuongDan
            // 
            txtDuongDan.Location = new Point(79, 141);
            txtDuongDan.Name = "txtDuongDan";
            txtDuongDan.Size = new Size(716, 34);
            txtDuongDan.TabIndex = 6;
            // 
            // picNoiDung
            // 
            picNoiDung.Location = new Point(483, 224);
            picNoiDung.Name = "picNoiDung";
            picNoiDung.Size = new Size(312, 200);
            picNoiDung.SizeMode = PictureBoxSizeMode.StretchImage;
            picNoiDung.TabIndex = 8;
            picNoiDung.TabStop = false;
            // 
            // Bài_7
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 504);
            Controls.Add(txtDuongDan);
            Controls.Add(lbDuonngDan);
            Controls.Add(lboThuMuc);
            Controls.Add(lbNoiDung);
            Controls.Add(rtxtNoiDung);
            Controls.Add(lbTieuDe);
            Controls.Add(picNoiDung);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Bài_7";
            Text = "Bài_7";
            Load += Bài_7_Load;
            ((System.ComponentModel.ISupportInitialize)picNoiDung).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTieuDe;
        private RichTextBox rtxtNoiDung;
        private Label lbNoiDung;
        private ListBox lboThuMuc;
        private Label lbDuonngDan;
        private TextBox txtDuongDan;
        private PictureBox picNoiDung;
    }
}