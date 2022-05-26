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
    public partial class Form_genres : Form
    {
        int? id;
        public Form_genres(string labelText,string buttonText)
        {
            InitializeComponent();
            Text = labelText;
            button1.Text = buttonText;
        }

        public Form_genres(string labelText, string buttonText, int? id):this(labelText, buttonText)
        {
            this.id = id;
        }
        private void Form_genres_Load(object sender, EventArgs e)
        {
            if (button1.Text != "Изменить")
                return;
            Genre genre = ListsComponent.GetObjById<Genre>(id);
            textBox1.Text = genre.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (button1.Text == "Добавить")
                {
                    AddGenres();
                    Close();
                }

                if (button1.Text == "Изменить")
                {
                    ChangeGenre();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поле, чтобы добавить жанр.");
            }
        }


        void AddGenres()
        {
            Genre genre = new Genre();
            genre.Name = textBox1.Text;
            ListsComponent.Add(genre);
        }


        void ChangeGenre()
        {
            Genre genre = ListsComponent.GetObjById<Genre>(id);
            genre.Name = textBox1.Text;
            ListsComponent.Edit(genre);
        }

    }
}
