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
    public partial class frmSearchModules : Form
    {
        DataHandler data = new DataHandler();
        public frmSearchModules()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuleNEW module = new frmModuleNEW();
                module.Show();
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Not able to return to module form");
            }
           
        }

        private void frmSearchModules_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to exit");
            }

        }

        private void frmSearchModules_Load(object sender, EventArgs e)
        {
            Refresh();
        }


        private void Refresh(List<Module> modules)
        {
            //dgvSearchModules.DataSource = modules;
            //dgvSearchModules.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSearchModules.DataSource = data.SearchModule(txtModuleCode.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Not able to search");
            }
        }
    }
}
