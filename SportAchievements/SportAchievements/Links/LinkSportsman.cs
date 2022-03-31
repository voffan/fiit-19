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
    public partial class LinkSportsman : Form
    {
        public LinkSportsman()
        {
            InitializeComponent();
        }

        private void LinkSportsman_Load(object sender, EventArgs e)
        {
            InitTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SportsmanBtns.AddSportsman sportsman = new SportsmanBtns.AddSportsman();
            sportsman.ShowDialog();
            InitTable();
        }

        private void InitTable()
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Sportsmen.ToList();
        }
    }
}
