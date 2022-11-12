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
    public partial class frmMenuNEW : Form
    {
        public frmMenuNEW()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudentNEW student = new frmStudentNEW();
                student.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuleNEW module = new frmModuleNEW();
                module.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoginNEW login = new frmLoginNEW();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void frmMenuNEW_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
