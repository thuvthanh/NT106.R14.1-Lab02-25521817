using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Lab2
{
    public partial class Bài_4 : Form
    {
        List<Student> students = new List<Student>();
        int page = 0;
        public Bài_4()
        {
            InitializeComponent();
        }
        private void DisplayStudent()
        {
            if (students.Count == 0)
                return;
            Student s = students[page];
            txtNameR.Text = s.Name;
            txtIDR.Text = s.ID.ToString();
            txtPhoneNumberR.Text = s.PhoneNumber;
            txtCourse1R.Text = s.Course1.ToString();
            txtCourse2R.Text = s.Course2.ToString();
            txtCourse3R.Text = s.Course3.ToString();
            txtAverageR.Text = s.Average.ToString();
            btnBack.Enabled = (page > 0);
            btnNext.Enabled = (page < students.Count - 1);
            lbPage.Text = (page + 1).ToString();
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (students.Count == 0)
                    throw new Exception("Student list is emty");
                string json = JsonSerializer.Serialize(students);
                File.WriteAllText("input4.txt", json);
                MessageBox.Show("Saved to input4.txt successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "" || txtID.Text.Trim() == "" || txtPhoneNumber.Text.Trim() == "" || txtCourse1.Text.Trim() == "" || txtCourse2.Text.Trim() == "" || txtCourse3.Text.Trim() == "")
                {
                    throw new Exception("Please enter all required information");
                }
                int id = Int32.Parse(txtID.Text.Trim());
                if (txtID.Text.Length != 8)
                    throw new Exception("Student ID must contain enough 8 digits");
                string phonenumber = txtPhoneNumber.Text.Trim();
                if (phonenumber.Length != 10 || phonenumber[0] != '0')
                    throw new Exception("Phone number must contain 10 digits and start with 0");
                foreach (char c in phonenumber)
                {
                    if (c < '0' || c > '9')
                        throw new Exception("Phone number must contain digits only");
                }
                float course1 = float.Parse(txtCourse1.Text.Trim());
                float course2 = float.Parse(txtCourse2.Text.Trim());
                float course3 = float.Parse(txtCourse3.Text.Trim());
                if (course1 < 0 || course1 > 10 || course2 < 0 || course2 > 10 || course3 < 0 || course3 > 10)
                {
                    throw new Exception("Scores must be between 0 to 10");
                }
                Student student = new Student();
                student.Name = txtName.Text;
                student.ID = id;
                student.PhoneNumber = phonenumber;
                student.Course1 = course1;
                student.Course2 = course2;
                student.Course3 = course3;
                student.Average = 0;
                students.Add(student);
                rtxtKetQua.AppendText(student.Name + "\n" + student.ID + "\n" + student.PhoneNumber + "\n" + student.Course1 + "\n" + student.Course2 + "\n" + student.Course3 + "\r\n");
                txtName.Clear();
                txtID.Clear();
                txtPhoneNumber.Clear();
                txtCourse1.Clear();
                txtCourse2.Clear();
                txtCourse3.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Student ID and scores must be valid numbers");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input4.txt"))
                    throw new Exception("File input4.txt does not exist");
                string json = File.ReadAllText("input4.txt");
                students = JsonSerializer.Deserialize<List<Student>>(json);
                foreach (Student s in students)
                {
                    s.Average = (s.Course1 + s.Course2 + s.Course3) / 3;
                }
                string outputjson = JsonSerializer.Serialize(students);
                File.WriteAllText("output4.txt", json);
                page = 0;
                DisplayStudent();
                MessageBox.Show("Read file successfully and saved to output4.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                DisplayStudent();
            }    
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page < students.Count - 1)
            {
                page++;
                DisplayStudent();
            }    
        }
    }
}
