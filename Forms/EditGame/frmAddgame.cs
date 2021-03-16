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
using System.Runtime;

namespace LoginApplication
{
    public partial class frmAddgame : Form
    {
        static private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public frmAddgame()
        {
            InitializeComponent();
        }
        private void apply_Click(object sender, EventArgs e)
        {
            string insert = "Row Inserted Successfully!";
            string invalid = "Row Inserted Failed!";
            OracleCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                string[] tab1 = comboBox1.SelectedItem.ToString().Split(' ');
                string[] tab2 = comboBox2.SelectedItem.ToString().Split(' ');
                cmd.CommandText = "SELECT DEB_ID FROM DEBUT WHERE DEB_NAME = '" + comboBox3.SelectedItem.ToString() + "'";         
                string tmp = Convert.ToString(cmd.ExecuteScalar());
                int id_white = int.Parse(tab1[0]);
                int id_black = int.Parse(tab2[0]);
                int id_debut = int.Parse(tmp);
                if(id_white!=id_black && comboBox4.Text != "" && comboBox5.Text != "" && comboBox4.Text != comboBox5.Text)
                {
                    cmd.CommandText = "INSERT INTO MATCHES(MTC_PLAID_WHITE,MTC_SCORE_WHITE,MTC_SCORE_BLACK,MTC_PLAID_BLACK,MTC_DATE,MTC_ID_DEBUT,MTC_NAME_TOURNAMENT)" +
                              "VALUES('" + id_white + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + id_black + "','" + dateTime.Text +
                              "','" + id_debut + "','" + tournament.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                    MessageBox.Show(insert);
                }
                else
                {
                    con.Close();
                    MessageBox.Show(invalid);
                }
            }
            catch (OracleException exception)
            {
                con.Close();
                MessageBox.Show(exception.ToString());
            }
        }
        private void frmAddgame_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                comboBox1.Items.Clear();
                OracleCommand cmd = con.CreateCommand();
                OracleCommand cmd2 = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd2.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT PLA_ID,PLA_FIRSTNAME,PLA_LASTNAME FROM PLAYER";
                cmd2.CommandText = "SELECT DEB_NAME FROM DEBUT";
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
                da.Fill(dt);
                da2.Fill(dt2);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["PLA_ID"].ToString() + " " + dr["PLA_FIRSTNAME"].ToString() + " " + dr["PLA_LASTNAME"].ToString());
                    comboBox2.Items.Add(dr["PLA_ID"].ToString() + " " + dr["PLA_FIRSTNAME"].ToString() + " " + dr["PLA_LASTNAME"].ToString());
                }
                foreach (DataRow dr in dt2.Rows)
                {
                    comboBox3.Items.Add(dr["DEB_NAME"].ToString());
                }
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
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
