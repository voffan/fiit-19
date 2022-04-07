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
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void Edit_Sprtsmn_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            }
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[3].Value);
            }
            else
            {
                MessageBox.Show("Выберите строку или ячейку!");
                return;
            }

            SportsmanBtns.EditSportsman sportsman = new SportsmanBtns.EditSportsman(id);
            sportsman.ShowDialog();
            InitTable();
        }

        private void Del_Sprtsmn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = -1;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                }
                else if (dataGridView1.SelectedCells.Count > 0)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[3].Value);
                }
                else 
                {
                    MessageBox.Show("Выберите строку или ячейку!");
                    return;
                }
                SportsmanComp.DelSprtsmn(id);
                InitTable();
            }
        }
    }
}
