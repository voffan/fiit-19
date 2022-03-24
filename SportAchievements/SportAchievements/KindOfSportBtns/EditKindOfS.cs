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

namespace SportAchievements.KindOfSportBtns
{
    public partial class EditKindOfS : Form
    {
        int Id;
        public EditKindOfS(int Id)
        {
            this.Id = Id;
            InitializeComponent();
        }

        private void EditKindOfS_Load(object sender, EventArgs e)
        {

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
