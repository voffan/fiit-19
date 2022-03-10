using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportAchievements
{
    public partial class LinkCompetition : Form
    {
        public LinkCompetition()
        {
            InitializeComponent();
        }

        private void LinkCompetition_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Competitions.ToList();
            //dataGridView1.Columns[0].Visible = false;    ВИЖОН
            //dataGridView1.Columns[1].HeaderText = "";    МОЖНО МЕНЯТЬ НАЗВАНИЕ ВАУ!
        }
    }
}
