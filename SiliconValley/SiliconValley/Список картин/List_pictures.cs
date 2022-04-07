using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_картин
{
    public partial class List_pictures : Form
    {
        public List_pictures()
        {
            InitializeComponent();
            this.Name = "list";
        }

        private void List_pictures_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                dataGridView1.DataSource = context.Pictures.ToList();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form_pictures formPictures = new Form_pictures("Добавить картину", "Добавить");
            formPictures.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Pictures.ToList();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Form_pictures formPicture = new Form_pictures("Изменить картину", "Изменить");
            formPicture.Index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            formPicture.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Pictures.ToList();
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
                PictureComponent.Delete(currentId);
            }

            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Pictures.ToList();
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите картину");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int placementId= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            Journal_picture journal = new Journal_picture(id,placementId);

            journal.ShowDialog();
        }
    }
}
