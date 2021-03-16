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
using System.Runtime.Remoting.Messaging;
namespace LoginApplication
{
    public partial class frmAddplayer : Form
    {
        static private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public frmAddplayer()
        {
            InitializeComponent();
        }
        private void apply_Click(object sender, EventArgs e)
        {
            frmPlayers frm = new frmPlayers();
            bool male = radio_male.Checked;
            bool female = radio_female.Checked;
            OracleCommand cmd = con.CreateCommand();
            string msg = "Row Inserted Successfully!";
            string msg2 = "Row Inserted Failed!";
            try
            {
                con.Open();
                cmd.CommandText = "SELECT TM_ID FROM TEAMS WHERE TM_NAME = '" + comboBox1.SelectedItem.ToString() + "'";
                string tmp = Convert.ToString(cmd.ExecuteScalar());
                int id = int.Parse(tmp);
                if (male)
                {
                    if (firstname.Text != "" && lastname.Text != "")
                    {
                        if(ranking.Text == "" || salary.Text == "")
                        {
                            ranking.Text = "1000";
                            salary.Text = "0";
                        }
                        cmd.CommandText = "INSERT INTO PLAYER(PLA_FIRSTNAME,PLA_LASTNAME,PLA_RANKING,PLA_TEAM,PLA_BIRTHDAY,PLA_SEX,PLA_CONTINENT,PLA_SALARY)" +
                            "VALUES('" + firstname.Text + "','" + lastname.Text + "','" + int.Parse(ranking.Text) +
                            "','" + id + "','" + date_Time.Text + "','" + radio_male.Text + "','" + comboBox2.Text + "','" + int.Parse(salary.Text) + "')";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            this.Close();
                            MessageBox.Show(msg);
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show(msg2);
                    }
                }
                else if (female)
                {
                    if (ranking.Text != "" && salary.Text != "")
                    {
                        cmd.CommandText = "INSERT INTO PLAYER(PLA_FIRSTNAME,PLA_LASTNAME,PLA_RANKING,PLA_TEAM,PLA_BIRTHDAY,PLA_SEX,PLA_CONTINENT,PLA_SALARY)" +
                        "VALUES('" + firstname.Text + "','" + lastname.Text + "','" + ranking.Text +
                        "','" + id + "','" + date_Time.Text + "','" + radio_female.Text + "','" + comboBox2.Text + "','" + salary.Text + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Close();
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show(msg2);
                    }
                }
            }
            catch (OracleException exception)
            {
                con.Close();
                MessageBox.Show(exception.ToString());
            }
        }
        private void frm_addplayer_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                comboBox1.Items.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT tm_name FROM TEAMS";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["TM_NAME"].ToString());
                }
                comboBox1.SelectedIndex = 0;
                con.Close();              
            }
            catch (OracleException exception)
            {
                con.Close();
                MessageBox.Show(exception.ToString());
            }
        }
        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
