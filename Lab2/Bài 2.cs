using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bài_2 : Form
    {
        public Bài_2()
        {
            InitializeComponent();
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string ten = ofd.SafeFileName.ToString();
            txtTenFile.Text = ten;
            txtKichThuoc.Text = fs.Length.ToString() + " bytes";
            string url = fs.Name.ToString();
            txtURL.Text = url;
            string noidung = sr.ReadToEnd();
            rtxtNoiDung.Text = noidung;
            int sodong = 0;
            foreach (char c in noidung)
            {
                if (c == '\n')
                    sodong++;
            }
            if (noidung.Length > 0)
                sodong++;
            txtSoDong.Text = sodong.ToString();
            int sotu = 0;
            bool trongtu = false;
            foreach (char c in noidung)
            {
                if (c != ' ' && c != '\n' && c != '\r' && c != '\t' && c != ',' && c != '.' && c != ';' && c != ':' && c != '!' && c != '?')
                {
                    if (trongtu == false)
                    {
                        sotu++;
                        trongtu = true;
                    }
                }
                else
                    trongtu = false;
            }
            txtSoTu.Text = sotu.ToString();
            txtSoKyTu.Text = noidung.Length.ToString();
            sr.Close();
            fs.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
