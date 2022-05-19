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
            int kindOfSportId = (from KindOfSport ks in vitsporta.Items where
                                 ks.Name == vitsporta.SelectedValue.ToString() select ks.Id).FirstOrDefault();
            if (Place.Value.ToString() != "" && Points.Value.ToString() != "")
            {
                try
                {
                    ResultComp.EditResult(Id, (int)vitsporta.SelectedValue, (int)vesovkat.SelectedValue, (int)Place.Value, (int)Points.Value);
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
            vitsporta.DataSource = (new Context()).KindsOfSports.ToList();
            vitsporta.DisplayMember = "Name";
            vitsporta.ValueMember = "Id";
            vitsporta.SelectedItem = (from KindOfSport wc in vitsporta.Items where wc.Id == res.KindOfSportId select wc).FirstOrDefault();

            vesovkat.DataSource = (new Context()).WeightCategories.ToList();
            vesovkat.DisplayMember = "Name";
            vesovkat.ValueMember = "Id";
            vesovkat.SelectedItem = (from WeightCategory wc in vesovkat.Items where wc.Id == res.WeightCategoryId select wc).FirstOrDefault();

            Points.Value = res.Points;
            Place.Value = res.Place;
        }
    }
}
