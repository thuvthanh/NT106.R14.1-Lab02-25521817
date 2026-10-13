using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bài_5 : Form
    {
        public class Movie
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public List<string> PhongChieu { get; set; }
            public int SoVeBan { get; set; }
            public int DoanhThu { get; set; }
            public Movie()
            {
                PhongChieu = new List<string>();
                SoVeBan = 0;
                DoanhThu = 0;
            }
        }
        Dictionary<string, string> VeChon = new Dictionary<string, string>();
        Dictionary<string, bool> VeDaMua = new Dictionary<string, bool>();
        List<Movie> dsPhim = new List<Movie>();
        public Bài_5()
        {
            InitializeComponent();
        }
        private void Bài_5_Load(object sender, EventArgs e)
        {
            for (char hang = 'A'; hang <= 'C'; hang++)
            {
                for (int cot = 1; cot <= 5; cot++)
                {
                    clbGhe.Items.Add(hang + cot.ToString());
                }
            }
            pgrbTienTrinh.Minimum = 0;
            pgrbTienTrinh.Value = 0;
        }
        private void btnNap_Click(object sender, EventArgs e)
        {
            try
            {
                dsPhim.Clear();
                string[] phim = File.ReadAllLines("input5.txt");
                foreach (string p in phim)
                {
                    string[] a = p.Split('|');
                    Movie movie = new Movie()
                    {
                        TenPhim = a[0],
                        GiaVeChuan = int.Parse(a[1])
                    };
                    string[] phong = a[2].Split(',');
                    foreach (string r in phong)
                        movie.PhongChieu.Add("Phòng " + r);
                    dsPhim.Add(movie);
                }
                cbPhim.Items.Clear();
                foreach (Movie movie in dsPhim)
                {
                    cbPhim.Items.Add(movie.TenPhim);
                }
                MessageBox.Show("Đã nạp dữ liệu phim");
            }
            catch
            {
                MessageBox.Show("Không đọc được input5.txt");
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            pgrbTienTrinh.Value = 0;
            pgrbTienTrinh.Maximum = dsPhim.Count;
            List<Movie> xephang = dsPhim.OrderByDescending(movie => movie.DoanhThu).ToList();
            string kq = "";
            for (int i = 0; i < xephang.Count; i++)
            {
                Movie movie = xephang[i];
                int tongghe = movie.PhongChieu.Count * 15;
                int vecon = tongghe - movie.SoVeBan;
                double tile = 0;
                if (tongghe == 0)
                    tile = 0;
                else
                    tile = movie.SoVeBan * 100.0 / tongghe;
                kq += "Tên phim: " + movie.TenPhim + "\r\n";
                kq += "Số phòng chiếu: " + movie.PhongChieu.Count + "\r\n";
                kq += "Tổng số ghế: " + tongghe + "\r\n";
                kq += "Số vé bán: " + movie.SoVeBan + "\r\n";
                kq += "Số vé tồn: " + vecon + "\r\n";
                kq += "Tỉ lệ vé bán: " + tile + "\r\n";
                kq += "Doanh thu: " + movie.DoanhThu + "\r\n";
                kq += "Xếp hạng: " + (i + 1) + "\r\n\r\n";
                pgrbTienTrinh.Value++;
                Application.DoEvents();
            }
            File.WriteAllText("output5.txt", kq);
            rtxtThongKe.Text = kq;
            MessageBox.Show("Xuất thống kê thành công!\nDữ liệu đã được lưu vào file output5.txt");
        }
        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPhong.Items.Clear();
            Movie movie = dsPhim.Find(movie => movie.TenPhim == cbPhim.Text);
            if (movie == null)
                return;
            foreach (string phong in movie.PhongChieu)
                cbPhong.Items.Add(phong);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbPhim.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phim");
                return;
            }    
            if (cbPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng");
                return;
            }    
            if (clbGhe.CheckedItems.Count != 1)
            {
                MessageBox.Show("Mỗi lần chỉ chọn 1 ghế");
                return;
            }    
            if (VeChon.Count >= 2)
            {
                MessageBox.Show("Chỉ được chọn tối đa 2 vé");
                return;
            }
            if (clbGhe.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế");
                return;
            }
            string ghe = clbGhe.CheckedItems[0].ToString();
            string mave = cbPhim.Text + "|" + cbPhong + "|" + ghe;
            if (VeDaMua.ContainsKey(mave))
            {
                MessageBox.Show("Vé đã được mua");
                return;
            }
            VeChon.Add(mave, ghe);
            lboVe.Items.Add(cbPhong.Text + " - " + ghe);
            for (int i = 0; i < clbGhe.Items.Count; i++)
            {
                clbGhe.SetItemChecked(i, false);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            VeChon.Clear();
            lboVe.Items.Clear();
            for (int i = 0; i < cbPhim.Items.Count; i++)
            {
                clbGhe.SetItemChecked(i, false);
            }
            cbPhim.SelectedIndex = -1;
            cbPhong.SelectedIndex = -1;
            cbPhim.Text = "";
            cbPhong.Text = "";
            cbPhong.Items.Clear();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                return;
            }    
            if (VeChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé");
                return;
            }
            Movie movie = dsPhim.Find(movie => movie.TenPhim == cbPhim.Text);
            int giave = movie.GiaVeChuan;
            int tongtien = 0;
            foreach (var ve in VeChon)
            {
                string ghe = ve.Value;
                if (ghe == "A1" || ghe == "A5" || ghe == "C1" || ghe == "C5")
                    tongtien += giave / 4;
                else if (ghe == "B2" || ghe == "B3" || ghe == "B4")
                    tongtien += giave * 2;
                else
                    tongtien += giave;
            }
            movie.SoVeBan += VeChon.Count;
            movie.DoanhThu += tongtien;
            foreach (var ve in VeChon)
            {
                VeDaMua[ve.Key] = true;
            }
            MessageBox.Show("Thanh toán thành công\n" + "Số tiền: " + tongtien);
            VeChon.Clear();
            lboVe.Items.Clear();
        }
    }
}
