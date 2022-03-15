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
    public partial class AddCompetition : Form
    {
        public AddCompetition()
        {
            InitializeComponent();
            //Context con, string name, DateTime start, DateTime end, int typeid, string type
        }

        private void AddCompetition_Load(object sender, EventArgs e)
        {
            
        }

        private void addEmpl_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0 &&  start.Value.Date.ToString().Length > 0 && end.Value.Date.ToString().Length > 0 && typeid.Text.Length > 0 && type.Text.Length > 0)
            {
                try
                {
                    CompetitionComp.AddCompetition(Authorization.con, name.Text, start.Value.Date, end.Value.Date, ((int)typeid.Value), type.Text);
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
