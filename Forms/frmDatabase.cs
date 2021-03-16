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
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using System.Xml.Serialization;
using LoginApplication.Serialize;
using System.IO;
using System.Xml;

namespace LoginApplication
{
    public partial class frmDatabase : Form
    {
        static private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public frmDatabase()
        {
            InitializeComponent();
            GetData_DataBase();
        }
        private void frmDatabase_Load(object sender, EventArgs e)
        {
            GetData_DataBase();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            GetData_DataBase();
        }
        private void add_match_Click(object sender, EventArgs e)
        {
            frmAddgame obj_add = new frmAddgame();
            obj_add.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            frmEditgame obj_edit = new frmEditgame();
            obj_edit.identify.Text = database_viev.CurrentRow.Cells[0].Value.ToString();
            obj_edit.name_white.Text = database_viev.CurrentRow.Cells[1].Value.ToString();
            obj_edit.score_white.Text = database_viev.CurrentRow.Cells[2].Value.ToString();
            obj_edit.score_black.Text = database_viev.CurrentRow.Cells[3].Value.ToString();
            obj_edit.name_black.Text = database_viev.CurrentRow.Cells[4].Value.ToString();
            obj_edit.dateTime.Text = database_viev.CurrentRow.Cells[5].Value.ToString();
            obj_edit.debut.Text = database_viev.CurrentRow.Cells[6].Value.ToString();
            obj_edit.tournament.Text = database_viev.CurrentRow.Cells[7].Value.ToString();
            obj_edit.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            OracleCommand cmd = con.CreateCommand();
            string msg = "Row Delete Successfully!";
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM MATCHES WHERE MTC_ID =" + int.Parse(database_viev.CurrentRow.Cells[0].Value.ToString());
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
            if (database_viev.CurrentRow != null)
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
        private void GetData_DataBase()
        {
            con_database.Reload(this.database_viev);
            foreach (DataGridViewColumn column in database_viev.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            row_selected();
        }
        private void file_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            var path = file.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Database>));
            StreamReader reader = new StreamReader(path);
            var input = serializer.Deserialize(reader);
            reader.Close();
            this.database_viev.DataSource = input;
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
                    serializer.Serialize(writer, database_viev.DataSource);
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
