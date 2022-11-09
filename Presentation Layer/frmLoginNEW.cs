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
    }
}
