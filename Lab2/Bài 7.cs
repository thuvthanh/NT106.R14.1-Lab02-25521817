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
    public partial class Bài_7 : Form
    {
        string currentPath = @"C:\";
        public Bài_7()
        {
            InitializeComponent();
        }
        private void Bài_7_Load(object sender, EventArgs e)
        {
            lboThuMuc.Items.Clear();
            DriveInfo[] odia = DriveInfo.GetDrives();
            foreach (DriveInfo d in odia)
            {
                lboThuMuc.Items.Add(d.Name);
            }
        }
        private void LoadFolder(string path)
        {
            try
            {
                lboThuMuc.Items.Clear();
                currentPath = path;
                txtDuongDan.Text = currentPath;
                string[] thumuc = Directory.GetDirectories(path);
                foreach (string t in thumuc)
                    lboThuMuc.Items.Add(t);
                string[] teptin = Directory.GetFiles(path);
                foreach (string t in teptin)
                    lboThuMuc.Items.Add(t);
            }
            catch
            {
                MessageBox.Show("Không mở được thư mục");
            }
        }
        private void lboThuMuc_DoubleClick(object sender, EventArgs e)
        {
            if (lboThuMuc.SelectedItem == null)
                return;
            string path = lboThuMuc.SelectedItem.ToString();
            if (Directory.Exists(path))
                LoadFolder(path);

        }
        private void lboThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboThuMuc.SelectedItem == null)
                return;
            string path = lboThuMuc.SelectedItem.ToString();
            if (File.Exists(path))
            {
                string morong = Path.GetExtension(path).ToLower();
                try
                {
                    if (morong == ".txt" || morong == ".cs" || morong == ".cpp")
                    {
                        rtxtNoiDung.Visible = true;
                        picNoiDung.Visible = false;
                        rtxtNoiDung.Text = File.ReadAllText(path);
                    }
                    else if (morong == ".jpg")
                    {
                        rtxtNoiDung.Visible = false;
                        picNoiDung.Visible = true;
                        picNoiDung.Image = Image.FromFile(path);
                    }    
                    else
                    {
                        rtxtNoiDung.Visible = true;
                        picNoiDung.Visible = false;
                        rtxtNoiDung.Text = "Loại file: " + morong + "\nChương trình không hỗ trợ hiển thị nội dung.";
                    }    
                }
                catch
                {
                    MessageBox.Show("Không mở được file");
                }
            }    
        }
    }
}
