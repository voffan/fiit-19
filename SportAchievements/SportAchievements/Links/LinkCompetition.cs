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
            dataGridView1.DataSource = c.Competitions.Include("Type").ToList();
            dataGridView1.Columns[4].Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
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

            CompetitionBtns.EditCompetition Competition = new CompetitionBtns.EditCompetition(id);
            Competition.ShowDialog();
            InitTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                CompetitionComp.DelCom(id);
                InitTable();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            //Competition competition = c.Competitions.Find(searchTextBox.Text);

            Competition cmp = new Competition();
            CompType cmpType = (from CompType ct in c.CompTypes
                                where ct.Name == searchTextBox.Text
                                select ct).FirstOrDefault();

            //MessageBox.Show(cmpType.Name);
            /*if (cmp != null)
            {
                try
                {
                    ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Название: " + cmpType.Name);
                }
            }*/
        }
    }
}
