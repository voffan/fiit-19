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
    public partial class LinkKindOfSport : Form
    {
        public LinkKindOfSport()
        {
            InitializeComponent();
        }

        private void LinkKindOfSport_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            dataGridView1.DataSource = c.KindsOfSports.ToList();
            //dataGridView1.Columns[0].Visible = false;    ВИЖОН
            //dataGridView1.Columns[1].HeaderText = "";    МОЖНО МЕНЯТЬ НАЗВАНИЕ ВАУ!
        }
    }
}
