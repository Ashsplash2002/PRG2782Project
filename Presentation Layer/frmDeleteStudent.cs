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
    public partial class frmDeleteStudent : Form
    {
        DataHandler data = new DataHandler();
        public frmDeleteStudent()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmStudentNEW student = new frmStudentNEW();
            student.Show();
            this.Close();
        }

        private void frmDeleteStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                data.DeleteStudent(txtStudentCode.Text);
                MessageBox.Show("Student Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to delete student");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDelete.DataSource = data.SearchStudent(txtStudentCode.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to search student");
            }
        }
    }
}
