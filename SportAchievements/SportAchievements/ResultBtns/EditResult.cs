using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportAchievements.Classes;
using SportAchievements.Components;

namespace SportAchievements.ResultBtns
{
    public partial class EditResult : Form
    {
        int Id;
        Result res;
        public EditResult(int Id)
        {
            this.Id = Id;
            InitializeComponent();
            res = (new Context()).Results.Find(Id);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Place.Value.ToString() != "" && Points.Value.ToString() != "")
            {
                try
                {
                    ResultComp.EditResult(Id, vitsporta.SelectedValue.ToString(), vesovkat.SelectedValue.ToString(), (int)Place.Value, (int)Points.Value);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void EditResult_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                vitsporta.DataSource = c.KindsOfSports.ToList();
                vitsporta.DisplayMember = "Name";
                vitsporta.ValueMember = "Id";
                vesovkat.DataSource = c.WeightCategories.ToList();
                vesovkat.DisplayMember = "Name";
                vesovkat.ValueMember = "Id";
            }
            Points.Value = res.Points;
            Place.Value = res.Place;
        }
    }
}
