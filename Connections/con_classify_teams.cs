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
    static class con_classify_teams
    {
        static private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        static public void Reload(DataGridView datagrid)
        {
            try
            {
                con.Open();
                string command = "SELECT tm_name AS TEAM,sum(player.PLA_SALARY) AS SALARY FROM TEAMS JOIN PLAYER ON teams.tm_id = player.pla_team GROUP BY tm_name ORDER BY sum(player.pla_salary) DESC";
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
