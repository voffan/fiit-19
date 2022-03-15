using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportAchievements.Components;

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
            InitTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCompetition Competition = new AddCompetition();
            Competition.ShowDialog();
            InitTable();
        }
        private void InitTable()
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Competitions.ToList();
            
        }
    }
}
