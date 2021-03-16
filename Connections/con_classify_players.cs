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
    static class con_classify_players
    {
        static private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        static public void Reload(DataGridView datagrid)
        {
            try
            {
                con.Open();
                string command = "SELECT PLA_FIRSTNAME AS FIRSTNAME,PLA_LASTNAME AS SURNAME,PLA_RANKING AS RANKING,TEAMS.TM_NAME AS TEAM FROM PLAYER LEFT OUTER JOIN teams ON player.pla_team = teams.tm_id ORDER BY PLA_RANKING DESC";
                OracleDataAdapter link = new OracleDataAdapter(command, con);
                DataTable tb = new DataTable();
                link.Fill(tb);
                datagrid.DataSource = tb;
            }
            catch (OracleException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
