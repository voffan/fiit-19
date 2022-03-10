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
    }
}
