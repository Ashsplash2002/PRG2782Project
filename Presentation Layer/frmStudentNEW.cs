using System;
using System.Collections.Generic;
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
                MessageBox.Show("Not able to go to menu form");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateStudent frm = new frmUpdateStudent();
                frm.Show();
                this.Hide();
            }

            catch (Exception)
            {
                MessageBox.Show("Not able to go to update form");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                frmSearchStudent frmSearch = new frmSearchStudent();
                frmSearch.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to go to search form");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeleteStudent delete = new frmDeleteStudent();
                delete.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to go to delete form");
            }
        }

        private void frmStudentNEW_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to go to exit form");
            }
        }

        private void frmStudentNEW_Load(object sender, EventArgs e)
        {
            Refresh(students);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int studentNumber = int.Parse(txtStudentNumber.Text);
                string studentName = txtStudentName.Text;
                string studentSurname = txtStudentSurname.Text;
                string studentImage = pbStudentImage.Image.ToString();
                string studentGender = txtGender.Text;
                string studentPhone = txtPhone.Text;
                string studentAddress = txtAddress.Text;
                string moduleCodes = txtModuleCodes.Text;
                DateTime studentDOB = dtpDOB.Value.Date;

                data.CreateStudent(studentNumber, studentName, studentSurname, studentImage, studentGender, studentPhone, studentAddress, moduleCodes, studentDOB);

                Refresh(students);
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to add a student");
            }
        }


        private void Refresh(List<Student> students)
        {
            students = data.ReadStudent();
            dgvStudents.DataSource = students;
            dgvStudents.Refresh();
        }

        private void btnUpload_Click(object sender, EventArgs e)
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

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtStudentNumber.Text = dgvStudents.Rows[e.RowIndex].Cells["stdNum"].FormattedValue.ToString();
                txtStudentName.Text = dgvStudents.Rows[e.RowIndex].Cells["stdName"].FormattedValue.ToString();
                txtStudentSurname.Text = dgvStudents.Rows[e.RowIndex].Cells["stdSurname"].FormattedValue.ToString();
                pbStudentImage.ImageLocation = dgvStudents.Rows[e.RowIndex].Cells["stdImage"].FormattedValue.ToString();
                txtGender.Text = dgvStudents.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();
                txtPhone.Text = dgvStudents.Rows[e.RowIndex].Cells["phoneNum"].FormattedValue.ToString();
                txtAddress.Text = dgvStudents.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                txtModuleCodes.Text = dgvStudents.Rows[e.RowIndex].Cells["moduleCode"].FormattedValue.ToString();
                dtpDOB.Text = dgvStudents.Rows[e.RowIndex].Cells["dateObirth"].FormattedValue.ToString();
            }
        }

        private void btnseeall_Click(object sender, EventArgs e)
        {
            try
            {

                dgvStudents.DataSource = data.SeeAll();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to see all students");
            }
        }
    }
}
