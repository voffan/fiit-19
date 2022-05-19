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

namespace SportAchievements.CompetitionBtns
{
    public partial class EditCompetition : Form
    {
        int Id;
        Competition com;

        public EditCompetition(int Id)
        {
            this.Id = Id;
            InitializeComponent();
            com = (new Context()).Competitions.Find(Id);
        }

        

        private void EditCompetition_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                listBox1.SelectionMode = SelectionMode.MultiExtended;

                /*comboBox2.DataSource = c.CompTypes.ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";*/
                listBox1.DataSource = c.KindsOfSports.ToList();
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "Id";

            }
            name.Text = com.Name;
            start.Value = com.DateBeginning;
            end.Value = com.DateEnding;
            comboBox2.DataSource = (new Context()).CompTypes.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedItem = (from CompType wc in comboBox2.Items where wc.Id == com.CompTypeId select wc).FirstOrDefault();
            listBox1.SelectedItems.Clear();
            foreach (KindOfSport item in com.KindOfSports)
            {
                listBox1.SetSelected(item.Id - 1, true);
            }


            if (com == null)
            {
                MessageBox.Show("Сотрудник не найден!");
                Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0 && start.Value.Date.ToString().Length > 0 && end.Value.Date.ToString().Length > 0 && comboBox2.Text.Length > 0 && listBox1.Text.Length > 0)
            {
                try
                {
                    List<KindOfSport> list = new List<KindOfSport>();
                    CompetitionComp.ChCom(name.Text, start.Value.Date, end.Value.Date, ((int)comboBox2.SelectedValue), list, Id);
                    Close();
                }
                catch
                {

                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
