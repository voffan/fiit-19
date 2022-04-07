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
    public partial class EditSportsman : Form
    {
        int Id;

        public EditSportsman(int Id)
        {
            this.Id = Id;
            InitializeComponent();

        }

        private void EditSportsman_Load(object sender, EventArgs e)
        {
            gen.DataSource = new BindingSource(Classes.DescriptionAttributes<Classes.Gender>.RetrieveAttributes(), null);
            gen.DisplayMember = "Key";
            gen.ValueMember = "Value";
            comboBox1.DataSource = (new Context()).WeightCategories.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (FIO.Text.Length > 0 && bdate.Value.Date.ToString().Length > 0 && gen.Text.Length > 0)
            {
                try
                {

                    SportsmanComp.ChSprtsmn(FIO.Text, bdate.Value.Date, (Classes.Gender)Enum.Parse(typeof(Classes.Gender), (string)gen.SelectedValue), (int)comboBox1.SelectedValue, Id);
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
