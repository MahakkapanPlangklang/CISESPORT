using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FormAllPlayer : Form
    {
        List<Player> listPlayer = new List<Player>();
        Player selectedPlayer;
        public FormAllPlayer()
        {
            InitializeComponent();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK) {
                Player newPlayer = formInfo.getPlayer();
                //Add new Player to List
                this.listPlayer.Add(newPlayer);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                //Add list to Datagrid view
                formInfo.Close();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save data from list to CSV file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Player item in listPlayer)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                            item.Name,
                            item.Lastname,
                            item.ID,
                            item.Major,
                            item.Displayname,
                            item.Mail,
                            item.Phone,
                            item.Age));
                    }
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.selectedPlayer =  (Player)row.DataBoundItem;

                this.tbName.Text = selectedPlayer.Name;
            }
        }
    }
}
