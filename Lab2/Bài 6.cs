using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab2
{
    public partial class Bài_6 : Form
    {
        string connect = @"Server = MINE\SQLEXPRESS01; Database = Món Ăn; Trusted_Connection = true; TrustServerCertificate = true;";
        public class ThongTinMonAn
        {
            public string TenMonAn { get; set; }
            public string HinhAnh { get; set; }
            public string NguoiDongGop { get; set; }
        }
        public Bài_6()
        {
            InitializeComponent();
        }
        private void Bài_6_Load(object sender, EventArgs e)
        {

        }
        private void btnThucDon_Click(object sender, EventArgs e)
        {
            try
            {
                lboThucDon.Items.Clear();
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    string sql = "SELECT TenMonAn FROM MonAn";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                        lboThucDon.Items.Add(rd["TenMonAn"].ToString());
                }
                MessageBox.Show("Đã tải thực đơn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                List<ThongTinMonAn> dsMon = new List<ThongTinMonAn>();
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    string sql = @"SELECT TenMonAn, HinhAnh, HoVaTen FROM MonAn JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        ThongTinMonAn mon = new ThongTinMonAn();
                        mon.TenMonAn = rd["TenMonAn"].ToString();
                        mon.HinhAnh = rd["HinhAnh"].ToString();
                        mon.NguoiDongGop = rd["HoVaTen"].ToString();
                        dsMon.Add(mon);
                    }
                }
                if (dsMon.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu món ăn");
                    return;
                }
                Random random = new Random();
                int vitri = random.Next(dsMon.Count);
                txtMon.Text = dsMon[vitri].TenMonAn;
                txtNguoi.Text = dsMon[vitri].NguoiDongGop;
                try
                {
                    picHinh.Image = Image.FromFile(@"Images\" + dsMon[vitri].HinhAnh);
                    
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy ảnh " + dsMon[vitri].HinhAnh);
                    picHinh.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        
    }
}
