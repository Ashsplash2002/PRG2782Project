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

        FileHandler logins = new FileHandler();
        List<Login> loginsList = new List<Login>();

        private void btnlogin_Click(object sender, EventArgs e)
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                logins.WriteLogin(new Login(txtusername.Text, txtPassword.Text));
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }
    }
}
