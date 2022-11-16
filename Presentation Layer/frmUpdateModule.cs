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
                string modCode = txtModuleCode.Text;
                Module mod = new Module();
                mod = data.FindFill(modCode, mod);
                txtModuleDescription.Text = mod.ModuleDescription;
                txtModuleName.Text = mod.ModuleName;
                txtLinks.Text = mod.ModuleLink;
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to search module");
            }
        }
    }
}
