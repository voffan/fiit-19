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

namespace SportAchievements.SportsmanBtns
{
    public partial class AddSportsman : Form
    {
        public AddSportsman()
        {
            InitializeComponent();
        }

        private void AddSportsman_Load(object sender, EventArgs e)
        {
            gen.DataSource = new BindingSource(Classes.DescriptionAttributes<Classes.Position>.RetrieveAttributes(), null);
            gen.DisplayMember = "Key";
            gen.ValueMember = "Value";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addSprtmn_Click(object sender, EventArgs e)
        {
            if (FIO.Text.Length > 0 && bdate.Value.Date.ToString().Length > 0 && gen.Text.Length > 0)
            {
                try
                {
                    SportsmanComp.AddSportsman(FIO.Text, bdate.Value.Date, (Classes.Gender)Enum.Parse(typeof(Classes.Gender), (string)gen.SelectedValue), (Classes.WeightCategory)Enum.Parse(typeof(Classes.WeightCategory), (string)comboBox1.SelectedValue));
                    Close();
                }
                catch
                {

                }
            }
            else MessageBox.Show("Заполните все поля!");
        }
    
    }
}
