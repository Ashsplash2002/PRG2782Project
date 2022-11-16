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
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string moduleCode = txtModuleCode.Text;
                string moduleName = txtModuleName.Text;
                string moduleDescription = txtModuleDescription.Text;
                string moduleLink = txtLinks.Text;
                data.CreateModule(moduleCode, moduleName, moduleDescription, moduleLink);

                Refresh(modules);
            }
            catch(Exception)
            {
                MessageBox.Show("Was not able to add the Module");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                frmSearchModules search = new frmSearchModules();
                search.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Was not able to open search form");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeleteModule delete = new frmDeleteModule();
                delete.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Was not able to open delete form");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateModule update = new frmUpdateModule();
                update.Show();
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Was not able to open update form");
            }
        }

        private void frmModuleNEW_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception)
            {
                MessageBox.Show("Was not able to exit form");
            }

        }

        private void frmModuleNEW_Load(object sender, EventArgs e)
        {
            Refresh(modules);
        }


        private void Refresh(List<Module> modules)
        {
            //modules = data.ReadModule();
            dgvModules.DataSource = data.ReadModule();
            //dgvModules.Refresh();
        }

        private void btnseeall_Click(object sender, EventArgs e)
        {
            try
            {
                dgvModules.DataSource = data.ReadModule();
            }
            catch (Exception)
            {
                MessageBox.Show("User will not be able to see all data");
            }
        }
    }
}
