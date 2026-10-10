namespace Lab2
{
    partial class Dashboard
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
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            btnBai4 = new Button();
            btnBai5 = new Button();
            btnBai6 = new Button();
            btnBai7 = new Button();
            btnThoat = new Button();
            lbDashboard = new Label();
            SuspendLayout();
            // 
            // btnBai1
            // 
            btnBai1.BackColor = SystemColors.ButtonHighlight;
            btnBai1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai1.Location = new Point(74, 125);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(112, 34);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = false;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai2
            // 
            btnBai2.BackColor = SystemColors.ButtonHighlight;
            btnBai2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai2.Location = new Point(338, 125);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(112, 34);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = false;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.BackColor = SystemColors.ButtonHighlight;
            btnBai3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai3.Location = new Point(609, 125);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(112, 34);
            btnBai3.TabIndex = 2;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = false;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai4
            // 
            btnBai4.BackColor = SystemColors.ButtonHighlight;
            btnBai4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai4.Location = new Point(74, 240);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(112, 34);
            btnBai4.TabIndex = 3;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = false;
            btnBai4.Click += btnBai4_Click;
            // 
            // btnBai5
            // 
            btnBai5.BackColor = SystemColors.ButtonHighlight;
            btnBai5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai5.Location = new Point(338, 240);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(112, 34);
            btnBai5.TabIndex = 4;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = false;
            btnBai5.Click += btnBai5_Click;
            // 
            // btnBai6
            // 
            btnBai6.BackColor = SystemColors.ButtonHighlight;
            btnBai6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai6.Location = new Point(609, 240);
            btnBai6.Name = "btnBai6";
            btnBai6.Size = new Size(112, 34);
            btnBai6.TabIndex = 5;
            btnBai6.Text = "Bài 6";
            btnBai6.UseVisualStyleBackColor = false;
            btnBai6.Click += btnBai6_Click;
            // 
            // btnBai7
            // 
            btnBai7.BackColor = SystemColors.ButtonHighlight;
            btnBai7.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBai7.Location = new Point(338, 351);
            btnBai7.Name = "btnBai7";
            btnBai7.Size = new Size(112, 34);
            btnBai7.TabIndex = 6;
            btnBai7.Text = "Bài 7";
            btnBai7.UseVisualStyleBackColor = false;
            btnBai7.Click += btnBai7_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ControlText;
            btnThoat.Location = new Point(338, 445);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 41);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // lbDashboard
            // 
            lbDashboard.AutoSize = true;
            lbDashboard.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbDashboard.Location = new Point(303, 41);
            lbDashboard.Name = "lbDashboard";
            lbDashboard.Size = new Size(194, 35);
            lbDashboard.TabIndex = 8;
            lbDashboard.Text = "Dashboard";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 515);
            Controls.Add(lbDashboard);
            Controls.Add(btnThoat);
            Controls.Add(btnBai7);
            Controls.Add(btnBai6);
            Controls.Add(btnBai5);
            Controls.Add(btnBai4);
            Controls.Add(btnBai3);
            Controls.Add(btnBai2);
            Controls.Add(btnBai1);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai4;
        private Button btnBai5;
        private Button btnBai6;
        private Button btnBai7;
        private Button btnThoat;
        private Label lbDashboard;
    }
}