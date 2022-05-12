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
    public partial class AddCompetition : Form
    {
        public AddCompetition()
        {
            InitializeComponent();
            //Context con, string name, DateTime start, DateTime end, int typeid, string type
        }

        private void AddCompetition_Load(object sender, EventArgs e)
        {
            using (Context c = new Context() )
            {
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                
                comboBox2.DataSource = c.CompTypes.ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
                listBox1.DataSource = c.KindsOfSports.ToList();
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "Id";

            } 
         
        }

        private void addEmpl_Click(object sender, EventArgs e)
        {
            
            if (name.Text.Length > 0 &&  start.Value.Date.ToString().Length > 0 && end.Value.Date.ToString().Length > 0 && comboBox2.Text.Length > 0 && listBox1.Text.Length > 0)
            {
                try
                {
                    List<KindOfSport> list = new List<KindOfSport>();                    
                    foreach (KindOfSport item in listBox1.SelectedItems)
                        list.Add(item);
                    CompetitionComp.AddCompetition(name.Text, start.Value.Date, end.Value.Date, ((int)comboBox2.SelectedValue), list);
                    Close();
                }
                catch
                {

                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
