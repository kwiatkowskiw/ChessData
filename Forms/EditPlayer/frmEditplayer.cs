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
using System.Runtime.CompilerServices;
namespace LoginApplication
{
    public partial class frmEditplayer : Form
    {
        static private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public frmEditplayer()
        {
            InitializeComponent();
        }     
        private void apply2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = con.CreateCommand();
            string msg = "Row Update Successfully!";
            try
            {
                con.Open();
                if (ranking.Text == "" || salary.Text == "")
                {
                    ranking.Text = "1000";
                    salary.Text = "0";
                }
                cmd2.CommandText = "UPDATE PLAYER SET PLA_RANKING ='" + int.Parse(ranking.Text) + "', PLA_SALARY = " + int.Parse(salary.Text) + " WHERE PLA_ID =" + int.Parse(identify.Text);
                cmd2.ExecuteNonQuery();
                con.Close();
                this.Close();
                MessageBox.Show(msg);
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
