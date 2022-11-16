using PRG2782Project.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2782Project
{
    public partial class frmUpdateStudent : Form
    {
        DataHandler data = new DataHandler();

        public frmUpdateStudent()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmStudentNEW student = new frmStudentNEW();
            student.Show();
            this.Hide();
        }

        private void frmUpdateStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //string studentGender, string studentPhone, string studentAddress, string moduleCode, string studentImage
                //pbStudentImage.Text???
                data.UpdateStudent(txtStudentCode.Text, txtStudentNameandSurname.Text, txtstudentsurname.Text, DateTime.Parse(dtpdob.Text), txtGender.Text, txtPhone.Text, txtAddress.Text, pbStudentImage.Text);
                MessageBox.Show("Student Updated");
                txtStudentNameandSurname.Clear();
                txtstudentsurname.Clear();
                //dtpdob;
                txtGender.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to update module");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = new List<Student>();
                students = data.SearchStudent(txtStudentCode.Text);
                foreach (var item in students)
                {
                    //Image.Text???
                    txtStudentNameandSurname.Text = item.StudentName;
                    txtstudentsurname.Text = item.StudentSurname;
                    pbStudentImage.Text = item.StudentImage;
                    txtGender.Text = item.StudentGender;
                    txtPhone.Text = item.StudentPhone;
                    txtAddress.Text = item.StudentAddress;
                    //modulecode
                    //studentDOB
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to search module");
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            string image;
            try
            {
                OpenFileDialog imageUpload = new OpenFileDialog();
                imageUpload.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
                if (imageUpload.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    image = imageUpload.FileName;
                    pbStudentImage.ImageLocation = image;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error occurred");
            }
        }
    }
}
