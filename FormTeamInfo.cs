using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace CISESPORT
{



    public partial class FormTeamInfo : Form
    {
        public DataGridView dataGridView1;

        FormAllPlayer formInfo = new FormAllPlayer();
        List<Player> listPlayer = new List<Player>();


        public FormTeamInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (FormAllPlayer fap = new FormAllPlayer())
            {
                fap.ShowDialog();

                if (!string.IsNullOrEmpty(fap.Name))
                {
                    string selectedData = fap.Name;
                    string selectedData2 = fap.LastName;

                    textBox1.Text = selectedData;
                    textBox6.Text = selectedData2;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FormAllPlayer fap = new FormAllPlayer())
            {
                fap.ShowDialog();

                if (!string.IsNullOrEmpty(fap.Name))
                {
                    string selectedData = fap.Name;
                    string selectedData2 = fap.LastName;

                    textBox2.Text = selectedData;
                    textBox7.Text = selectedData2;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FormAllPlayer fap = new FormAllPlayer())
            {
                fap.ShowDialog();

                if (!string.IsNullOrEmpty(fap.Name))
                {
                    string selectedData = fap.Name;
                    string selectedData2 = fap.LastName;

                    textBox3.Text = selectedData;
                    textBox8.Text = selectedData2;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (FormAllPlayer fap = new FormAllPlayer())
            {
                fap.ShowDialog();

                if (!string.IsNullOrEmpty(fap.Name))
                {
                    string selectedData = fap.Name;
                    string selectedData2 = fap.LastName;

                    textBox5.Text = selectedData;
                    textBox10.Text = selectedData2;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FormAllPlayer fap = new FormAllPlayer())
            {
                fap.ShowDialog();

                if (!string.IsNullOrEmpty(fap.Name))
                {
                    string selectedData = fap.Name;
                    string selectedData2 = fap.LastName;

                    textBox4.Text = selectedData;
                    textBox9.Text = selectedData2;
                }
            }
        }
    }
}

