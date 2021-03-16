using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using System.Xml.Serialization;
using System.IO;
using LoginApplication.Serialize;

namespace LoginApplication
{
    public partial class frmPlayers : Form
    {
        public frmPlayers()
        {
            InitializeComponent();
            GetData();
        }
        public void frmPlayers_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void add_Click(object sender, EventArgs e)
        {
            frmAddplayer obj_add = new frmAddplayer();
            obj_add.Show();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            GetData();
        }
        private void edit_Click(object sender, EventArgs e)
        {
            frmEditplayer obj_edit = new frmEditplayer();
            try
            {
                obj_edit.identify.Text = data_players.CurrentRow.Cells[0].Value.ToString();
                obj_edit.firstname.Text = data_players.CurrentRow.Cells[1].Value.ToString();
                obj_edit.lastname.Text = data_players.CurrentRow.Cells[2].Value.ToString();
                obj_edit.ranking.Text = data_players.CurrentRow.Cells[3].Value.ToString();
                obj_edit.team.Text = data_players.CurrentRow.Cells[4].Value.ToString();
                obj_edit.date_Time.Text = data_players.CurrentRow.Cells[5].Value.ToString();
                obj_edit.sex.Text = data_players.CurrentRow.Cells[6].Value.ToString();
                obj_edit.continent.Text = data_players.CurrentRow.Cells[7].Value.ToString();
                obj_edit.salary.Text = data_players.CurrentRow.Cells[8].Value.ToString();
            }
            catch (OracleException exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            OracleCommand cmd = con.CreateCommand();
            string msg = "Row Delete Successfully!";
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM PLAYER WHERE PLA_ID =" + int.Parse(data_players.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(msg);
            }
            catch (OracleException exception)
            {
                con.Close();
                MessageBox.Show(exception.ToString());
            }
        }
        private void row_selected()
        {
            if (data_players.CurrentRow != null)
            {
                edit.Enabled = true;
                delete.Enabled = true;
            }
            else
            {
                edit.Enabled = false;
                delete.Enabled = false;
            }
        }
        private void GetData()
        {
            con_players.Reload(this.data_players);
            foreach (DataGridViewColumn column in data_players.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            row_selected();
        }

        private void file_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            var path = file.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Players>));
            StreamReader reader = new StreamReader(path);
            var input = serializer.Deserialize(reader);
            reader.Close();
            this.data_players.DataSource = input;
        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                var path = save.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(List<Database>));
                StreamWriter writer = new StreamWriter(path);
                try
                {
                    serializer.Serialize(writer, data_players.DataSource);
                    MessageBox.Show("File Inserted!");
                }
                catch
                {
                    MessageBox.Show("Fail!");
                }
                writer.Close();
            }
        }
    }
}
