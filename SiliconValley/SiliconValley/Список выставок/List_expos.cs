using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiliconValley.Список_Жанров;

namespace SiliconValley.Список_выставок
{
    public partial class List_expos : Form
    {
        public List_expos()
        {
            InitializeComponent();
        }

        private void List_expos_Load(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                GridExpo.DataSource = db.Expos.ToList();
            }
        }

        private void AddExpo_Click(object sender, EventArgs e)
        {
            Form_expos form_Expos = new Form_expos("Добавить выставку", "Добавить");
            form_Expos.ShowDialog();

            var db = new Context();
            GridExpo.DataSource = db.Expos.ToList();
        }

        private void ChangeExpo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GridExpo.CurrentRow.Cells[0].Value);
            Form_expos form_Expos = new Form_expos("Изменить выставку", "Изменить", id);
            form_Expos.ShowDialog();

            var db = new Context();
            GridExpo.DataSource = db.Expos.ToList();
        }

        private void DeleteExpo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons box = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить?", "", box);

            if (result == DialogResult.No)
                return;

            for (int i = 0; i < GridExpo.SelectedRows.Count; i++)
            {
                int currentId = Convert.ToInt32(GridExpo.SelectedRows[i].Cells[0].Value);
                Expo expo = ListsComponent.GetObjById<Expo>(currentId);

                ListsComponent.Delete(expo);
            }

            using (Context db = new Context())
            {
                GridExpo.DataSource = db.Expos.ToList();
            }
        }
    }
}
