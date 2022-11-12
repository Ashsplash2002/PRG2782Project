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
    public partial class frmModuleNEW : Form
    {
        public frmModuleNEW()
        {
            InitializeComponent();
        }

        DataHandler data = new DataHandler();
        List<Module> modules = new List<Module>();


        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenuNEW menu = new frmMenuNEW();
                menu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string moduleCode = txtModuleCode.Text;
            string moduleName = txtModuleName.Text;
            string moduleDescription = txtModuleDescription.Text;
            string moduleLink = txtLinks.Text;
            data.CreateModule(moduleCode, moduleName, moduleDescription, moduleLink);

            Refresh(modules);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchModules search = new frmSearchModules();
            search.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteModule delete = new frmDeleteModule(); 
            delete.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateModule update = new frmUpdateModule();
            update.Show();
            this.Close();
        }

        private void frmModuleNEW_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmModuleNEW_Load(object sender, EventArgs e)
        {
            Refresh(modules);
        }


        private void Refresh(List<Module> modules)
        {
            modules = data.ReadModule();
            dgvModules.DataSource = modules;
            dgvModules.Refresh();
        }
    }
}
