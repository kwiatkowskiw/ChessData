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
    public partial class frmEditgame : Form
    {
        static private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public frmEditgame()
        {
            InitializeComponent();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            string msg = "Row Update Successfully!";
            string msg2 = "Row Update Failed!";
            try
            {
                if(score_white.Text != score_black.Text)
                {
                con.Open();
                cmd.CommandText = "UPDATE MATCHES SET MTC_SCORE_WHITE ='" + int.Parse(score_white.Text) + "', MTC_SCORE_BLACK = " + int.Parse(score_black.Text) + " WHERE MTC_ID =" + int.Parse(identify.Text);
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
