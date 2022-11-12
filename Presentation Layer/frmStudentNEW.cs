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
    }
}
