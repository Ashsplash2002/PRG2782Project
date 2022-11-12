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
        public frmSearchModules()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmModuleNEW module = new frmModuleNEW();
            module.Show();
            this.Close();
        }

        private void frmSearchModules_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmSearchModules_Load(object sender, EventArgs e)
        {
            Refresh();
        }


        private void Refresh(List<Module> modules)
        {
            dgvSearchModules.DataSource = modules;
            dgvSearchModules.Refresh();
        }
    }
}
