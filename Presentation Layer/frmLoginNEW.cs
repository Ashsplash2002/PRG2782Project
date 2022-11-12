using PRG2782Project.Data_Access_Layer;
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
    public partial class frmLoginNEW : Form
    {
        public frmLoginNEW()
        {
            InitializeComponent();
        }

        FileHandler loginsData = new FileHandler();
        List<Login> loginsList = new List<Login>();


        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool valid = false;
            try
            {
                string username = txtusername.Text; string password = txtPassword.Text;

                loginsList = loginsData.ReadLogin();

                foreach (Login login in loginsList)
                {
                    if ((username == login.Username) && (password == login.Password))
                    {
                        valid = true;
                    }
                }

                if (valid)
                {
                    frmMenuNEW menu = new frmMenuNEW();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    txtusername.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                loginsData.WriteLogin(new Login(txtusername.Text, txtPassword.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }
    }
}
