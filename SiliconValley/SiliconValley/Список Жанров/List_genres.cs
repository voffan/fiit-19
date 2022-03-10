using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_Жанров
{
    public partial class List_genres : Form
    {
        public List_genres()
        {
            InitializeComponent();
        }

        private void List_genres_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                gridGenre.DataSource = context.Genres.ToList();
            }
        }

        private void AddGenre_Click(object sender, EventArgs e)
        {
            Form_genres form_Genres = new Form_genres("Добавить жанр","Добавить");
            form_Genres.ShowDialog();

            var db = new Context();
            gridGenre.DataSource = db.Genres.ToList();
        }

        private void ChangeGenre_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridGenre.CurrentRow.Cells[0].Value);
            Form_genres form_Genres = new Form_genres("Изменить жанр", "Изменить",id);
            form_Genres.ShowDialog();

            var db = new Context();
            gridGenre.DataSource = db.Genres.ToList();
        }

        private void gridGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DeleteGenre_Click(object sender, EventArgs e)
        {
            MessageBoxButtons box = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить?", "", box);

            if (result == DialogResult.No)
                return;

            for (int i = 0; i < gridGenre.SelectedRows.Count; i++)
            {
                int currentId = Convert.ToInt32(gridGenre.SelectedRows[i].Cells[0].Value);
                Genre genre = ListsComponent.GetObjById<Genre>(currentId);

                ListsComponent.Delete(genre);
            }

            using (Context db = new Context())
            {
                gridGenre.DataSource = db.Genres.ToList();
            }
        }
    }
}
