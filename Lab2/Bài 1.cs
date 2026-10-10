namespace Lab2
{
    public partial class Bài_1 : Form
    {
        public Bài_1()
        {
            InitializeComponent();
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("input1.txt"))
            {
                string noidung = sr.ReadToEnd();
                rtxtKetQua.Text = noidung;
            }
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            string noidung = rtxtKetQua.Text;
            string inhoa = noidung.ToUpper();
            using (StreamWriter sw = new StreamWriter("ouput1.txt"))
            {
                sw.Write(inhoa);
            }
            MessageBox.Show("Đã lưu thành công vào ouput1.txt");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
