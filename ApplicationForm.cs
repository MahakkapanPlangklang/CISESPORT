using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void allPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.MdiParent = this;
            formAllPlayer.Show();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeamInfo team = new FormTeamInfo();
            team.MdiParent = this;
            team.Show();
        }
    }
}
