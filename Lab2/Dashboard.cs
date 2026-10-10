using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bài_1 bai1 = new Bài_1();
            bai1.Show();
        }
        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bài_2 bai2 = new Bài_2();
            bai2.Show();
        }
        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bài_3 bai3 = new Bài_3();
            bai3.Show();
        }
        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bài_4 bai4 = new Bài_4();
            bai4.Show();
        }
        private void btnBai5_Click(object sender, EventArgs e)
        {
            Bài_5 bai5 = new Bài_5();
            bai5.Show();
        }
        private void btnBai6_Click(object sender, EventArgs e)
        {
            Bài_6 bai6 = new Bài_6();
            bai6.Show();
        }
        private void btnBai7_Click(object sender, EventArgs e)
        {
            Bài_7 bai7 = new Bài_7();
            bai7.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
