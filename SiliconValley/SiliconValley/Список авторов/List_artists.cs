using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_авторов
{
    public partial class List_artists : Form
    {
        public List_artists()
        {
            InitializeComponent();
            this.Name = "list";
        }

        private void List_artists_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                dataGridView1.DataSource = context.Artists.ToList();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form_artist formArtist = new Form_artist("Добавить автора", "Добавить");
            formArtist.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Artists.ToList();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Form_artist formArtist = new Form_artist("Изменить автора", "Изменить");
            formArtist.Index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            formArtist.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Artists.ToList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons box = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить?", "", box);

            if (result == DialogResult.No)
                return;

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int currentId = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value);
                ArtistComponent.Delete(currentId);
            }

            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Artists.ToList();
            }
        }
    }
}
