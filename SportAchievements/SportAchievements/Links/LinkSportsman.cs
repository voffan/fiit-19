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
    public partial class LinkSportsman : Form
    {
        public LinkSportsman()
        {
            InitializeComponent();
        }

        private void LinkSportsman_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Sportsmen.ToList();
            //dataGridView1.Columns[0].Visible = false;    ВИЖОН
            //dataGridView1.Columns[1].HeaderText = "";    МОЖНО МЕНЯТЬ НАЗВАНИЕ ВАУ!
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
            /*dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Имя";
            dataGridView1.Columns[5].HeaderText = "Дата рождения";*/
        }
    }
}
