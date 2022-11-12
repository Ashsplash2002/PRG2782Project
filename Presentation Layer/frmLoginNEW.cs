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
using System.Runtime.InteropServices;

namespace PRG2782Project.Presentation_Layer
{
    public partial class frmLoginNEW : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightWllipse
        );

        public frmLoginNEW()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        FileHandler loginsData = new FileHandler();
        List<Login> loginsList = new List<Login>();


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool valid = false;
            try
            {
                if ((txtUsername.Text != String.Empty) && (txtPassword.Text != String.Empty))
                {
                    string username = txtUsername.Text; string password = txtPassword.Text;

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
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Username or Password");
                    txtUsername.Select();
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
                if ((txtUsername.Text != String.Empty) && (txtPassword.Text != String.Empty))
                {
                    loginsData.WriteLogin(new Login(txtUsername.Text, txtPassword.Text));
                }
                else
                {
                    MessageBox.Show("Enter Username or Password");
                    txtUsername.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void frmLoginNEW_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void lblMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
