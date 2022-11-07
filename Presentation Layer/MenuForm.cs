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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentForm student = new StudentForm();
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
                ModuleForm module = new ModuleForm();
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
                LoginForm login = new LoginForm();
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
