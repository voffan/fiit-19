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
    public partial class AddKindOfSport : Form
    {
        public AddKindOfSport()
        {
            InitializeComponent();
        }

        private void AddKindOfSport_Load(object sender, EventArgs e)
        {

        }

        private void dovavitkindofsport_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0 )
            {
                try
                {
                    KindofsportComp.AddKindOfSport(name.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void otmenakindofsport_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
