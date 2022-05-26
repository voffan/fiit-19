using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

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
                comboBox1.DataSource = context.Placements.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";

                comboBox2.DataSource = context.Genres.ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";

                comboBox3.DataSource = context.Artists.ToList();
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Id";

                dataGridView1.DataSource = context.Pictures.Include("Placement").Include("Genre").Include("Artist").ToList();
                dataGridView1.Columns["Date"].DefaultCellStyle.Format = "yyyy";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form_pictures formPictures = new Form_pictures("Добавить картину", "Добавить");
            formPictures.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Pictures.Include("Placement").Include("Genre").Include("Artist").ToList();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            int? id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Form_pictures formPicture = new Form_pictures("Изменить картину", "Изменить");
            formPicture.Index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            formPicture.ShowDialog();
            var db = new Context();
            dataGridView1.DataSource = db.Pictures.Include("Placement").Include("Genre").Include("Artist").ToList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons box = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить?", "", box);

            if (result == DialogResult.No)
                return;

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int? currentId = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value);
                PictureComponent.Delete(currentId);
            }

            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Pictures.Include("Placement").Include("Genre").Include("Artist").ToList();
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите картину");
                return;
            }
            int? id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);//id выбранной картины
            Journal_picture journal = new Journal_picture(id);
            journal.ShowDialog();
            Context db = new Context();
            dataGridView1.DataSource = db.Pictures.Include("Placement").Include("Genre").Include("Artist").ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {

                dataGridView1.DataSource = db.Pictures.Include("Placement").Include("Genre").Include("Artist").Where(d => d.Name.Contains(textBox1.Text)).ToList();
                if (comboBox1.Visible == true)
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Placement.Equals(comboBox1.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                else if (comboBox2.Visible == true)
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Genre.Equals(comboBox2.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                else if (comboBox3.Visible == true)
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Artist.Equals(comboBox3.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                else
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text)).Include("Placement").Include("Genre").Include("Artist").ToList();
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            if(label1.Visible == true)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                using (var db = new Context())
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Visible == true)
            {
                using (Context db = new Context())
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                comboBox1.Visible = false;
            }
            else
            {
                using (Context db = new Context())
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Placement.Equals(comboBox1.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Visible == true)
            {
                using (Context db = new Context())
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                comboBox2.Visible = false;
            }
            else
            {
                using (Context db = new Context())
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Genre.Equals(comboBox2.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                comboBox2.Visible = true;
                comboBox1.Visible = false;
                comboBox3.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Visible == true)
            {
                using (Context db = new Context())
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                comboBox3.Visible = false;
            }
            else
            {
                using (Context db = new Context())
                {
                    dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Artist.Equals(comboBox3.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
                }
                comboBox3.Visible = true;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Placement.Equals(comboBox1.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Genre.Equals(comboBox2.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                dataGridView1.DataSource = db.Pictures.Where(d => d.Name.Contains(textBox1.Text) && d.Artist.Equals(comboBox3.SelectedItem)).Include("Placement").Include("Genre").Include("Artist").ToList();
            }
        }
    }
}
