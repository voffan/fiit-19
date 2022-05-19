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
    public partial class DovavitLink : Form
    {
        public DovavitLink()
        {
            InitializeComponent();
        }

        private void LinkKindOfSport_Load(object sender, EventArgs e)
        {
            bibor.Items.AddRange(new string[] { "ID", "Название"});
            InitTable();
        }

        private void InitTable()
        {
            Context c = new Context();
            dataGridView1.DataSource = c.KindsOfSports.ToList();
        }

        private void addlinkkindofsport_Click(object sender, EventArgs e)
        {
            AddKindOfSport kindOfSport = new AddKindOfSport();
            kindOfSport.ShowDialog();
            InitTable();
            /*
            AddEmployee Employee = new AddEmployee();
            Employee.ShowDialog();
            InitTable();*/
        }

        private void EditLinkkindofsport_Click(object sender, EventArgs e)
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

            KindOfSportBtns.EditKindOfS KindOfSport = new KindOfSportBtns.EditKindOfS(id);
            KindOfSport.ShowDialog();
            InitTable();
        }

        private void Deletlinkkindofsport_Click(object sender, EventArgs e)
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
                KindofsportComp.DelKind(id);
                InitTable();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {

                string asd = bibor.Text;
                switch (asd)
                {
                    case "ID":
                        if (searchTextBox.Text.Length > 0)
                        {

                            dataGridView1.DataSource = c.KindsOfSports.Where(o => o.Id.ToString().Contains(searchTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView1.DataSource = c.KindsOfSports.ToList();
                        }
                        break;
                    case "Название":
                        if (searchTextBox.Text.Length > 0)
                        {

                            dataGridView1.DataSource = c.KindsOfSports.Where(o => o.Name.ToString().Contains(searchTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView1.DataSource = c.KindsOfSports.ToList();
                        }
                        break;
                }
            }
        }
    }
}
