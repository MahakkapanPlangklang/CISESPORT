using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CISESPORT
{
    public partial class ApplicationForm : Form
    {
        
        private FormAllPlayer fop;
        private FormTeamInfo fti;

        public ApplicationForm()
        {
            InitializeComponent();
            //fop = new FormAllPlayer();
            //fop.TopLevel = false;
            //fop.FormBorderStyle = FormBorderStyle.None;
            //fop.Dock = DockStyle.Fill;
            ////panel1.Controls.Add(fop);
            //fop.Show();
        }

        private void allPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormAllPlayer formAllPlayer = new FormAllPlayer();
            ////formAllPlayer.MdiParent = this;
            //formAllPlayer.ShowDialog();

            this.Hide();
            FormAllPlayer fop = new FormAllPlayer();
            fop.ShowDialog();
            fop = null;
            this.Show();

        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormTeamInfo team = new FormTeamInfo();
            //team.MdiParent = this;
            //team.Show();
            this.Hide();
            FormTeamInfo fti = new FormTeamInfo();
            fti.ShowDialog();
            fti = null;
            this.Show();
        }
    }
}
