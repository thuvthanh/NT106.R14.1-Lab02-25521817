namespace Lab2
{
    partial class Bài_4
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
            btnWrite = new Button();
            lbName = new Label();
            lbID = new Label();
            lbPhoneNumber = new Label();
            lbCourse1 = new Label();
            lbCourse2 = new Label();
            lbCourse3 = new Label();
            lbAverage = new Label();
            btnAdd = new Button();
            rtxtKetQua = new RichTextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCourse1 = new TextBox();
            txtCourse2 = new TextBox();
            txtCourse3 = new TextBox();
            txtAverage = new TextBox();
            btnRead = new Button();
            lbNameR = new Label();
            txtNameR = new TextBox();
            lbIDR = new Label();
            txtIDR = new TextBox();
            lbPhoneNumberR = new Label();
            txtPhoneNumberR = new TextBox();
            lbCourse1R = new Label();
            txtCourse1R = new TextBox();
            lbCourse2R = new Label();
            txtCourse2R = new TextBox();
            lbCourse3R = new Label();
            txtCourse3R = new TextBox();
            lbAverageR = new Label();
            txtAverageR = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            label1 = new Label();
            lbPage = new Label();
            SuspendLayout();
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnWrite.Location = new Point(51, 44);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(362, 42);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Write to a file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(51, 121);
            lbName.Name = "lbName";
            lbName.Size = new Size(66, 28);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(51, 186);
            lbID.Name = "lbID";
            lbID.Size = new Size(32, 28);
            lbID.TabIndex = 2;
            lbID.Text = "ID";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhoneNumber.Location = new Point(51, 257);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(149, 28);
            lbPhoneNumber.TabIndex = 3;
            lbPhoneNumber.Text = "Phone number";
            // 
            // lbCourse1
            // 
            lbCourse1.AutoSize = true;
            lbCourse1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourse1.Location = new Point(51, 329);
            lbCourse1.Name = "lbCourse1";
            lbCourse1.Size = new Size(89, 28);
            lbCourse1.TabIndex = 4;
            lbCourse1.Text = "Course 1";
            // 
            // lbCourse2
            // 
            lbCourse2.AutoSize = true;
            lbCourse2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourse2.Location = new Point(51, 394);
            lbCourse2.Name = "lbCourse2";
            lbCourse2.Size = new Size(92, 28);
            lbCourse2.TabIndex = 5;
            lbCourse2.Text = "Course 2";
            // 
            // lbCourse3
            // 
            lbCourse3.AutoSize = true;
            lbCourse3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourse3.Location = new Point(51, 464);
            lbCourse3.Name = "lbCourse3";
            lbCourse3.Size = new Size(92, 28);
            lbCourse3.TabIndex = 6;
            lbCourse3.Text = "Course 3";
            // 
            // lbAverage
            // 
            lbAverage.AutoSize = true;
            lbAverage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAverage.Location = new Point(51, 538);
            lbAverage.Name = "lbAverage";
            lbAverage.Size = new Size(86, 28);
            lbAverage.TabIndex = 7;
            lbAverage.Text = "Average";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(206, 600);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rtxtKetQua
            // 
            rtxtKetQua.Location = new Point(481, 44);
            rtxtKetQua.Name = "rtxtKetQua";
            rtxtKetQua.Size = new Size(447, 596);
            rtxtKetQua.TabIndex = 9;
            rtxtKetQua.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 121);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 46);
            txtName.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Location = new Point(89, 186);
            txtID.Name = "txtID";
            txtID.Size = new Size(207, 31);
            txtID.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(206, 257);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(207, 31);
            txtPhoneNumber.TabIndex = 12;
            // 
            // txtCourse1
            // 
            txtCourse1.Location = new Point(146, 329);
            txtCourse1.Name = "txtCourse1";
            txtCourse1.Size = new Size(150, 31);
            txtCourse1.TabIndex = 13;
            // 
            // txtCourse2
            // 
            txtCourse2.Location = new Point(149, 394);
            txtCourse2.Name = "txtCourse2";
            txtCourse2.Size = new Size(150, 31);
            txtCourse2.TabIndex = 14;
            // 
            // txtCourse3
            // 
            txtCourse3.Location = new Point(149, 464);
            txtCourse3.Name = "txtCourse3";
            txtCourse3.Size = new Size(150, 31);
            txtCourse3.TabIndex = 15;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(143, 538);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(150, 31);
            txtAverage.TabIndex = 16;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(991, 44);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(362, 42);
            btnRead.TabIndex = 17;
            btnRead.Text = "Read a file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lbNameR
            // 
            lbNameR.AutoSize = true;
            lbNameR.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameR.Location = new Point(991, 121);
            lbNameR.Name = "lbNameR";
            lbNameR.Size = new Size(66, 28);
            lbNameR.TabIndex = 18;
            lbNameR.Text = "Name";
            // 
            // txtNameR
            // 
            txtNameR.Location = new Point(1063, 121);
            txtNameR.Multiline = true;
            txtNameR.Name = "txtNameR";
            txtNameR.ReadOnly = true;
            txtNameR.Size = new Size(290, 46);
            txtNameR.TabIndex = 19;
            // 
            // lbIDR
            // 
            lbIDR.AutoSize = true;
            lbIDR.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIDR.Location = new Point(991, 186);
            lbIDR.Name = "lbIDR";
            lbIDR.Size = new Size(32, 28);
            lbIDR.TabIndex = 20;
            lbIDR.Text = "ID";
            // 
            // txtIDR
            // 
            txtIDR.Location = new Point(1063, 186);
            txtIDR.Name = "txtIDR";
            txtIDR.ReadOnly = true;
            txtIDR.Size = new Size(207, 31);
            txtIDR.TabIndex = 21;
            // 
            // lbPhoneNumberR
            // 
            lbPhoneNumberR.AutoSize = true;
            lbPhoneNumberR.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhoneNumberR.Location = new Point(991, 257);
            lbPhoneNumberR.Name = "lbPhoneNumberR";
            lbPhoneNumberR.Size = new Size(149, 28);
            lbPhoneNumberR.TabIndex = 22;
            lbPhoneNumberR.Text = "Phone number";
            // 
            // txtPhoneNumberR
            // 
            txtPhoneNumberR.Location = new Point(1146, 257);
            txtPhoneNumberR.Name = "txtPhoneNumberR";
            txtPhoneNumberR.ReadOnly = true;
            txtPhoneNumberR.Size = new Size(207, 31);
            txtPhoneNumberR.TabIndex = 23;
            // 
            // lbCourse1R
            // 
            lbCourse1R.AutoSize = true;
            lbCourse1R.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourse1R.Location = new Point(991, 329);
            lbCourse1R.Name = "lbCourse1R";
            lbCourse1R.Size = new Size(89, 28);
            lbCourse1R.TabIndex = 24;
            lbCourse1R.Text = "Course 1";
            // 
            // txtCourse1R
            // 
            txtCourse1R.Location = new Point(1086, 329);
            txtCourse1R.Name = "txtCourse1R";
            txtCourse1R.ReadOnly = true;
            txtCourse1R.Size = new Size(150, 31);
            txtCourse1R.TabIndex = 25;
            // 
            // lbCourse2R
            // 
            lbCourse2R.AutoSize = true;
            lbCourse2R.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourse2R.Location = new Point(991, 394);
            lbCourse2R.Name = "lbCourse2R";
            lbCourse2R.Size = new Size(92, 28);
            lbCourse2R.TabIndex = 26;
            lbCourse2R.Text = "Course 2";
            // 
            // txtCourse2R
            // 
            txtCourse2R.Location = new Point(1089, 394);
            txtCourse2R.Name = "txtCourse2R";
            txtCourse2R.ReadOnly = true;
            txtCourse2R.Size = new Size(150, 31);
            txtCourse2R.TabIndex = 27;
            // 
            // lbCourse3R
            // 
            lbCourse3R.AutoSize = true;
            lbCourse3R.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCourse3R.Location = new Point(991, 464);
            lbCourse3R.Name = "lbCourse3R";
            lbCourse3R.Size = new Size(92, 28);
            lbCourse3R.TabIndex = 28;
            lbCourse3R.Text = "Course 3";
            // 
            // txtCourse3R
            // 
            txtCourse3R.Location = new Point(1089, 464);
            txtCourse3R.Name = "txtCourse3R";
            txtCourse3R.ReadOnly = true;
            txtCourse3R.Size = new Size(150, 31);
            txtCourse3R.TabIndex = 29;
            // 
            // lbAverageR
            // 
            lbAverageR.AutoSize = true;
            lbAverageR.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAverageR.Location = new Point(991, 538);
            lbAverageR.Name = "lbAverageR";
            lbAverageR.Size = new Size(86, 28);
            lbAverageR.TabIndex = 30;
            lbAverageR.Text = "Average";
            // 
            // txtAverageR
            // 
            txtAverageR.Location = new Point(1083, 538);
            txtAverageR.Name = "txtAverageR";
            txtAverageR.ReadOnly = true;
            txtAverageR.Size = new Size(150, 31);
            txtAverageR.TabIndex = 31;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(991, 600);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 40);
            btnBack.TabIndex = 32;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(1241, 600);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 40);
            btnNext.TabIndex = 33;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 34;
            label1.Text = "label1";
            // 
            // lbPage
            // 
            lbPage.AutoSize = true;
            lbPage.Location = new Point(1164, 609);
            lbPage.Name = "lbPage";
            lbPage.Size = new Size(22, 25);
            lbPage.TabIndex = 35;
            lbPage.Text = "1";
            // 
            // Bài_4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 664);
            Controls.Add(lbPage);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txtAverageR);
            Controls.Add(lbAverageR);
            Controls.Add(txtCourse3R);
            Controls.Add(lbCourse3R);
            Controls.Add(txtCourse2R);
            Controls.Add(lbCourse2R);
            Controls.Add(txtCourse1R);
            Controls.Add(lbCourse1R);
            Controls.Add(txtPhoneNumberR);
            Controls.Add(lbPhoneNumberR);
            Controls.Add(txtIDR);
            Controls.Add(lbIDR);
            Controls.Add(txtNameR);
            Controls.Add(lbNameR);
            Controls.Add(btnRead);
            Controls.Add(txtAverage);
            Controls.Add(txtCourse3);
            Controls.Add(txtCourse2);
            Controls.Add(txtCourse1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(rtxtKetQua);
            Controls.Add(btnAdd);
            Controls.Add(lbAverage);
            Controls.Add(lbCourse3);
            Controls.Add(lbCourse2);
            Controls.Add(lbCourse1);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbID);
            Controls.Add(lbName);
            Controls.Add(btnWrite);
            Name = "Bài_4";
            Text = "Bài_4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWrite;
        private Label lbName;
        private Label lbID;
        private Label lbPhoneNumber;
        private Label lbCourse1;
        private Label lbCourse2;
        private Label lbCourse3;
        private Label lbAverage;
        private Button btnAdd;
        private RichTextBox rtxtKetQua;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtPhoneNumber;
        private TextBox txtCourse1;
        private TextBox txtCourse2;
        private TextBox txtCourse3;
        private TextBox txtAverage;
        private Button btnRead;
        private Label lbNameR;
        private TextBox txtNameR;
        private Label lbIDR;
        private TextBox txtIDR;
        private Label lbPhoneNumberR;
        private TextBox txtPhoneNumberR;
        private Label lbCourse1R;
        private TextBox txtCourse1R;
        private Label lbCourse2R;
        private TextBox txtCourse2R;
        private Label lbCourse3R;
        private TextBox txtCourse3R;
        private Label lbAverageR;
        private TextBox txtAverageR;
        private Button btnBack;
        private Button btnNext;
        private Label label1;
        private Label lbPage;
    }
}