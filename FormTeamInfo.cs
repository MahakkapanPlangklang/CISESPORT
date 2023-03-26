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
        List<Team> listteam = new List<Team>();
             

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
        private void AddRowToDataGridView(string column1Value, string column2Value, string column3Value)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView2);

            row.Cells[0].Value = column1Value;
            row.Cells[1].Value = column2Value;
            row.Cells[2].Value = column3Value;
           // row.Cells[3].Value = column4Value;

            dataGridView2.Rows.Add(row);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row.CreateCells(dataGridView2);
            //row.Cells[0].Value = tbName.Text;
            //row.Cells[1].Value = textBox1.Text;
            //row.Cells[2].Value = textBox6.Text;
            //row.Cells[1].Value = textBox2.Text;
            //row.Cells[2].Value =textBox7.Text;
            //dataGridView2.Rows.Add(row);

            string column1Value = tbName.Text;
            string column2Value = textBox1.Text;
            string column3Value = textBox6.Text;
            //string column4Value = textBox4.Text;

            AddRowToDataGridView(column1Value, column2Value, column3Value);

            // เคลียร์ค่าใน TextBox ทุกช่องหลังจากเพิ่มแถวใหม่เรียบร้อยแล้ว
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();
            // textBox4.Clear();
        }

    }
        
    
}

