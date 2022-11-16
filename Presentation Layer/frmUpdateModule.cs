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
    public partial class frmUpdateModule : Form
    {
        DataHandler data = new DataHandler();

        public frmUpdateModule()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            frmModuleNEW module = new frmModuleNEW();
            module.Show();
            this.Close();
        }

        private void frmUpdateModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                data.UpdateModule(txtModuleCode.Text, txtModuleName.Text, txtModuleDescription.Text, txtLinks.Text);
                MessageBox.Show("Module Updated");
                txtModuleName.Clear();
                txtModuleDescription.Clear();
                txtLinks.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to update module");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Module> modules = new List<Module>();
                modules = data.SearchModule(txtModuleCode.Text);
                foreach (var item in modules)
                {
                    txtModuleName.Text = item.ModuleName;
                    txtModuleDescription.Text = item.ModuleDescription;
                    txtLinks.Text = item.ModuleLink;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to search module");
            }
        }
    }
}
