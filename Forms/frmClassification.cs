using LoginApplication.Serialize;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LoginApplication
{
    public partial class frmClassification : Form
    {
        public frmClassification()
        {
            InitializeComponent();
            Get_Players();
        }
        private void Classification_Load(object sender, EventArgs e)
        {
            Get_Players();
        }
        private void players_Click(object sender, EventArgs e)
        {
            Get_Players();
        }
        private void teams_Click(object sender, EventArgs e)
        {
            Get_Teams();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Update();
        }
        private void Get_Players()
        {
            con_classify_players.Reload(this.dataGridView1);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void Get_Teams()
        {
            con_classify_teams.Reload(this.dataGridView1);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void file_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            var path = file.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Classification>));
            StreamReader reader = new StreamReader(path);
            var input = serializer.Deserialize(reader);
            reader.Close();
            this.dataGridView1.DataSource = input;
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
                    serializer.Serialize(writer, dataGridView1.DataSource);
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

