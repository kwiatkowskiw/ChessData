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
using System.Configuration;
using System.Security.Cryptography;

namespace LoginApplication
{
    public partial class frmRegister : Form
    {
        Hashcode hash = new Hashcode();
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public frmRegister()
        {
            InitializeComponent();
        }
        private void username_Click(object sender, EventArgs e)
        {
            username.Clear();
            username.ForeColor = Color.FromArgb(78, 184, 206);

            password.ForeColor = Color.WhiteSmoke;
            country.ForeColor = Color.WhiteSmoke;
        }
        private void password_Click(object sender, EventArgs e)
        {
            password.Clear();
            password.PasswordChar = '*';
            password.ForeColor = Color.FromArgb(78, 184, 206);

            username.ForeColor = Color.WhiteSmoke;
            country.ForeColor = Color.WhiteSmoke;
        }

        private void country_Click(object sender, EventArgs e)
        {
            country.Clear();
            country.ForeColor = Color.FromArgb(78, 184, 206);

            username.ForeColor = Color.WhiteSmoke;
            password.ForeColor = Color.WhiteSmoke;
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            bool male = radio_male.Checked;
            bool female = radio_female.Checked;
            string msg = "Invalid Register!";
            string msg2 = "This username is use. Please try write another!";
            try
            {
                DataTable tb = new DataTable();
                con.Open();
                if (username.Text != "" && password.Text != "" && country.Text != "" && radio_male.Text != "")
                {
                    string login = "SELECT *FROM ACCOUNT WHERE US_LOGIN = '" + username.Text.Trim() + "'";
                    OracleDataAdapter log = new OracleDataAdapter(login, con);
                    log.Fill(tb);
                    if (tb.Rows.Count != 1)
                    {
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        if (male)
                        {
                            cmd.CommandText = "INSERT INTO ACCOUNT(US_LOGIN,US_PASSWORD,US_SEX,US_COUNTRY)" +
                                "VALUES('" + username.Text + "','" + hash.PassHash(password.Text) + "','" + radio_male.Text +
                                "','" + country.Text + "')";
                        }
                        else if (female)
                        {
                            cmd.CommandText = "INSERT INTO ACCOUNT(US_LOGIN,US_PASSWORD,US_SEX,US_COUNTRY)" +
                                "VALUES('" + username.Text + "','" + hash.PassHash(password.Text) + "','" + radio_female.Text +
                                "','" + country.Text + "')";
                        }
                        cmd.ExecuteNonQuery();
                        con.Close();
                        frmAlert_Register obj_register = new frmAlert_Register();
                        this.Hide();
                        obj_register.Show();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show(msg2);
                    }
                }
                else
                {
                    con.Close();
                    MessageBox.Show(msg);
                }
            }         
            catch (OracleException exception)
            {
                con.Close();
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
