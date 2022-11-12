using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2782Project.Presentation_Layer
{
    public partial class frmStudentNEW : Form
    {
        public frmStudentNEW()
        {
            InitializeComponent();
        }

        DataHandler data = new DataHandler();
        List<Student> students = new List<Student>();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenuNEW menu = new frmMenuNEW();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateStudent frm = new frmUpdateStudent();
            frm.Show();
            this.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchStudent frmSearch = new frmSearchStudent();
            frmSearch.Show();
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteStudent delete = new frmDeleteStudent();
            delete.Show();
            this.Close();
        }

        private void frmStudentNEW_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmStudentNEW_Load(object sender, EventArgs e)
        {
            Refresh(students);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNumber.Text;
            string studentName = txtStudentName.Text;
            string studentSurname = txtStudentSurname.Text;
            string studentImage = pbStudentImage.Image.ToString();
            string studentGender = txtGender.Text;
            string studentPhone = txtPhone.Text;
            string studentAddress = txtAddress.Text;
            string moduleCodes = txtModuleCodes.Text;
            DateTime studentDOB = DateTime.Parse(txtDOB.Text);

            data.CreateStudent(studentNumber, studentName, studentSurname, studentImage, studentGender, studentPhone, studentAddress, moduleCodes, studentDOB);

            Refresh(students);
        }


        private void Refresh(List<Student> students)
        {
            students = data.ReadStudent();
            dgvStudents.DataSource = students;
            dgvStudents.Refresh();
        }
    }
}
