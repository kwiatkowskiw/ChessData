using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class frmMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        public frmMainMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.DarkRed;
                    currentButton.ForeColor = Color.WhiteSmoke;
                    currentButton.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                previousBtn.BackColor = Color.FromArgb(51,51,76);
                previousBtn.ForeColor = Color.WhiteSmoke;
                previousBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
                bt_Logout.BackColor = Color.FromArgb(0, 48, 0);
                panelTimer.BackColor = Color.FromArgb(39, 39, 58);
            }
        }
        private void openForms(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelTop.Controls.Add(childForm);
            this.panelTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void bt_Home_Click(object sender, EventArgs e)
        {
            openForms(new frmHome(), sender);
        }

        private void bt_Database_Click(object sender, EventArgs e)
        {
            openForms(new frmDatabase(), sender);
        }

        private void bt_Players_Click(object sender, EventArgs e)
        {
            openForms(new frmPlayers(), sender);
        }

        private void bt_Classification_Click(object sender, EventArgs e)
        {
            openForms(new frmClassification(), sender);
        }

        private void bt_Contact_Click(object sender, EventArgs e)
        {
            openForms(new frmContact(), sender);
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to logout", "Logout", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                this.Close();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to quit", "Exit", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelTop_Load(object sender, PaintEventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
        }
    }
}
