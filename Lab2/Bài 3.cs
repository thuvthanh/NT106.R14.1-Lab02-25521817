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
    public partial class Bài_3 : Form
    {
        string bieuthuc = "";
        int vitri = 0;
        public Bài_3()
        {
            InitializeComponent();
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input3.txt"))
                {
                    string noidung = sr.ReadToEnd();
                    rtxtKetQua.Text = noidung;
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Lỗi đọc file: " + loi.Message);
            }
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            string[] dong = rtxtKetQua.Lines;
            string ketqua = "";
            foreach (string d in dong)
            {
                if (d.Trim() != "")
                {
                    try
                    {
                        double kq = Tinh(d);
                        ketqua += d + " = " + kq.ToString() + "\r\n";
                    }
                    catch (Exception loi)
                    {
                        ketqua += d + " = Lỗi: " + loi.Message + "\r\n";
                    }
                }
            }
            rtxtKetQua.Text = ketqua;
        }
        private double Tinh(string a)
        {
            bieuthuc = a.Replace(" ", "");
            vitri = 0;
            double ketqua = CongTru();
            if (vitri < bieuthuc.Length)
                throw new Exception("Biểu thức không hợp lệ");
            return ketqua;
        }
        private double CongTru()
        {
            double ketqua = NhanChia();
            while (vitri < bieuthuc.Length)
            {
                char pheptinh = bieuthuc[vitri];
                if (pheptinh == ')')
                    break;
                switch (pheptinh)
                {
                    case '+':
                        vitri++;
                        double sohang = NhanChia();
                        ketqua += sohang;
                        break;
                    case '-':
                        vitri++;
                        double sotru = NhanChia();
                        ketqua -= sotru;
                        break;
                    default:
                        return ketqua;
                }
            }
            return ketqua;
        }
        private double NhanChia()
        {
            double ketqua = DocSo();
            while (vitri < bieuthuc.Length)
            {
                char pheptinh = bieuthuc[vitri];
                switch (pheptinh)
                {
                    case '*':
                        vitri++;
                        double thuaso = DocSo();
                        ketqua *= thuaso;
                        break;
                    case '/':
                        vitri++;
                        double sochia = DocSo();
                        if (sochia == 0)
                            throw new Exception("Không thể chia cho 0");
                        ketqua /= sochia;
                        break;
                    default:
                        return ketqua;
                }    
            }
            return ketqua;
        }
        private double DocSo()
        {
            if (vitri >= bieuthuc.Length)
                throw new Exception("Thiếu số");
            int dau = 1;
            if (bieuthuc[vitri] == '-')
            {
                dau = -1;
                vitri++;
            }    
            else if (bieuthuc[vitri] == '+')
            {
                vitri++;
            }
            if (vitri >= bieuthuc.Length)
                throw new Exception("Thiếu số");
            if (bieuthuc[vitri] == '(')
            {
                vitri++;
                double ketqua = CongTru();
                if (vitri >= bieuthuc.Length || bieuthuc[vitri] != ')')
                    throw new Exception("Thiếu dấu )");
                vitri++;
                return dau * ketqua;
            }
            if (!char.IsDigit(bieuthuc[vitri]))
                throw new Exception("Ký tự không hợp lệ");
            string chuoiso = "";
            while (vitri < bieuthuc.Length)
            {
                char c = bieuthuc[vitri];
                if (char.IsDigit(c) || c == '.')
                {
                    chuoiso += c;
                    vitri++;
                }
                else
                    break;
            }    double so;
            try
            {
                so = double.Parse(chuoiso);
            }
            catch
            {
                throw new Exception("Sai kiểu dữ liệu");
            }
            return dau * so;
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("output3.txt"))
                {
                    sw.Write(rtxtKetQua.Text);
                    MessageBox.Show("Ghi file thành công!");
                }
            }
            catch (Exception loi) 
            {
                MessageBox.Show("Lỗi ghi file" + loi.Message);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
