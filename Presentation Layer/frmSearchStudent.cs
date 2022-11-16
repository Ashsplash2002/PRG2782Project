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
    public partial class frmSearchStudent : Form
    {
        DataHandler data = new DataHandler();

        public frmSearchStudent()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmStudentNEW student = new frmStudentNEW();
            student.Show();
            this.Hide();
        }

        private void frmSearchStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSearch.DataSource = data.SearchStudent(txtStudentCode.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to search for student");
            }
        }
    }
}
