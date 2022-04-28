using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportAchievements.ResultBtns;

namespace SportAchievements.Links
{
    public partial class LinkResult : Form
    {
        public LinkResult()
        {
            InitializeComponent();
        }

        private void LinkResult_Load(object sender, EventArgs e)
        {
            InitTable();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void InitTable()
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Results.ToList();
        }

        private void AddRes_Click(object sender, EventArgs e)
        {
            AddResult addResult = new AddResult();
            addResult.ShowDialog();
            InitTable();
        }

        private void EdRes_Click(object sender, EventArgs e)
        {

        }

        private void DelRes_Click(object sender, EventArgs e)
        {

        }
    }
}
