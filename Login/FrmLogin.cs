using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Threading;

namespace LoginApplication
{
    public partial class frmLogin : Form
    {
        Hashcode hash = new Hashcode();
        private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public frmLogin()
        {
            Thread t1 = new Thread(new ThreadStart(Start));
            t1.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t1.Abort();
        }
        private bool dragging;
        private Point startPoint = new Point(0, 0);  
        private void username_Click(object sender, EventArgs e)
        {
            username.Clear();
            username.ForeColor = Color.FromArgb(78, 184, 206);
            password.ForeColor = Color.WhiteSmoke;
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Clear();
            password.PasswordChar = '*';
            password.ForeColor = Color.FromArgb(78, 184, 206);

            username.ForeColor = Color.WhiteSmoke;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to quit", "Exit", MessageBoxButtons.YesNo);
            if(check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void minimalized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }
        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void sign_in_Click(object sender, EventArgs e)
        {
            GetLoginData();
        }
        private void register_Click(object sender, EventArgs e)
        {
            frmRegister obj_registr = new frmRegister();
            obj_registr.Show();
        }
        public void Start()
        {
            try
            {
                Application.Run(new frmRunApplication());
            }
            catch(InvalidCastException)
            {
                
            }
        }
        private void GetLoginData()
        {
            DataTable tb = new DataTable();
            try
            {             
                con.Open();
                if (username.Text != "" || password.Text != "")
                {              
                   string login = "SELECT *FROM ACCOUNT WHERE US_LOGIN = '" + username.Text.Trim() + "' AND US_PASSWORD = '" + hash.PassHash(password.Text.Trim()) + "'";
                   OracleDataAdapter log = new OracleDataAdapter(login, con);
                   log.Fill(tb);
                   if (tb.Rows.Count == 1)
                   {
                        con.Close();
                        frmMainMenu obj_main = new frmMainMenu();
                        this.Hide();
                        Thread.Sleep(2000);
                        obj_main.Show();
                   }
                   else
                   {
                        Thread.Sleep(2000);
                        con.Close();
                        MessageBox_Login msg = new MessageBox_Login();
                        msg.Show();
                   }
                }
                else
                {
                    Thread.Sleep(2000);
                    con.Close();
                    MessageBox_Login msg = new MessageBox_Login();
                    msg.Show();
                }
                con.Close();
            }
            catch (OracleException exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
