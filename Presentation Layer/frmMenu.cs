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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudent student = new frmStudent();
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
                frmModule module = new frmModule();
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
                frmLogin login = new frmLogin();
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
    }
}
