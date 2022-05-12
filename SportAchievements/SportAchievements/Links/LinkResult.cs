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
            dataGridView1.DataSource = c.Results.Include("WeightCategory").ToList();

        }

        private void AddRes_Click(object sender, EventArgs e)
        {
            AddResult addResult = new AddResult();
            addResult.ShowDialog();
            InitTable();
        }

        private void EdRes_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            }
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Выберите строку или ячейку!");
                return;
            }

            EditResult result = new EditResult(id);
            result.ShowDialog();
            InitTable();
        }

        private void DelRes_Click(object sender, EventArgs e)
        {

        }
    }
}
