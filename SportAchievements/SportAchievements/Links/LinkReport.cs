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
using SportAchievements.Classes;
using SportAchievements.ReportBtns;

namespace SportAchievements
{
    public partial class LinkReport : Form
    {
        public LinkReport()
        {
            InitializeComponent();
        }

        private void LinkReport_Load(object sender, EventArgs e)
        {
            InitTable();
        }
        private void InitTable()
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Results.ToList();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddReport Report = new AddReport();
            Report.ShowDialog();
            InitTable();
        }
    }
}
