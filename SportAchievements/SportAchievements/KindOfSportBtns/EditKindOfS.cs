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

namespace SportAchievements.KindOfSportBtns
{
    public partial class EditKindOfS : Form
    {
        int Id;
        KindOfSport ki;
        public EditKindOfS(int Id)
        {
            this.Id = Id;
            InitializeComponent();
            ki = (new Context()).KindsOfSports.Find(Id);
        }

        private void EditKindOfS_Load(object sender, EventArgs e)
        {
            if (ki == null)
            {
                MessageBox.Show("Вид спорта не найден!");
                Close();
            }
            name.Text = ki.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0 )
            {
                try
                {

                    KindofsportComp.ChKind(name.Text, Id);
                    Close();
                }
                catch
                {

                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
