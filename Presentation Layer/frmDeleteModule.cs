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
    public partial class frmDeleteModule : Form
    {
        DataHandler data = new DataHandler();
        public frmDeleteModule()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmModuleNEW module = new frmModuleNEW();
            module.Show();
            this.Close();
        }

        private void frmDeleteModule_Load(object sender, EventArgs e)
        {

        }

        private void frmDeleteModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                data.DeleteModule(txtModuleCode.Text);
                MessageBox.Show("Successfully deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to delete module");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvdelete.DataSource = data.SearchModule(txtModuleCode.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to search module");
            }
        }
    }
}
