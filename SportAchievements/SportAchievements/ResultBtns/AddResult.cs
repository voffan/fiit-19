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

namespace SportAchievements.ResultBtns
{
    public partial class AddResult : Form
    {
        
        public AddResult()
        {
            
            InitializeComponent();
            
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            

            sportsman.DataSource = c.Sportsmen.ToList();
            sportsman.DisplayMember = "Name";
            sportsman.ValueMember = "Id";

            vesovkat.DataSource = c.WeightCategories.ToList();
            vesovkat.DisplayMember = "Name";
            vesovkat.ValueMember = "Id";

            competition.DataSource = c.Competitions.Include("KindOfSports").ToList();
            competition.DisplayMember = "Name";
            competition.ValueMember = "Id";

            Competition comp = (Competition)competition.SelectedItem;
            SetSportKind(comp);
        }

        private void competition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Competition comp = (Competition)competition.SelectedItem;
            SetSportKind(comp);
        }

        private void SetSportKind(Competition comp)
        {
            if (comp == null)
            {
                vitsporta.Items.Clear();
                return;
            }
            vitsporta.DataSource = comp.KindOfSports.ToList();
            vitsporta.DisplayMember = "Name";
            vitsporta.ValueMember = "Id";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value.ToString() != "" && numericUpDown2.Value.ToString() != "")
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
