using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace LoginApplication
{
    static class con_database
    {
        static private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        static public void Reload(DataGridView datagrid)
        {
            try
            {
                con.Open();
                string command = "SELECT MTC_ID AS ID,white.pla_firstname || ' ' || white.pla_lastname AS WHITE,MTC_SCORE_WHITE AS SCORE_WHITE" +
                    ",MTC_SCORE_BLACK AS SCORE_BLACK, black.pla_firstname || ' ' || black.pla_lastname AS BLACK, MTC_DATE, debut.deb_name AS DEBUT" +
                    ",MTC_NAME_TOURNAMENT AS TOURNAMENT FROM MATCHES LEFT OUTER JOIN debut ON(matches.mtc_id_debut = debut.deb_id)" +
                    "LEFT OUTER JOIN PLAYER WHITE ON(matches.mtc_plaid_white = WHITE.pla_id)" +
                    "LEFT OUTER JOIN PLAYER BLACK ON(matches.mtc_plaid_black = BLACK.pla_id) ORDER BY MTC_ID ASC";
                OracleDataAdapter link = new OracleDataAdapter(command, con);
                DataTable tb = new DataTable();
                link.Fill(tb);
                datagrid.DataSource = tb;
                con.Close();
            }
            catch (OracleException exception)
            {
                con.Close();
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
