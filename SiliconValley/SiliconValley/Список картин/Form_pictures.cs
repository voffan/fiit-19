using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiliconValley.Список_авторов;
using SiliconValley.Список_Жанров;
using SiliconValley.Список_отделов;
using SiliconValley.Список_выставок;

namespace SiliconValley.Список_картин
{
    public partial class Form_pictures : Form
    {
        public Button Button { get { return button1; } }
        public int? Index { get; set; }
        public Form_pictures(string labelText, string buttonText)
        {
            Index = -1;
            InitializeComponent();
            Text = labelText;
            button1.Text = buttonText;
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;

            using (var db = new Context())
            {
                comboBox1.DataSource = db.Placements.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";

                comboBox2.DataSource = db.Genres.ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";

                comboBox3.DataSource = db.Artists.ToList();
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Id";

            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = double.Parse(textBox2.Text);
            Placement placement = (Placement)comboBox1.SelectedItem;
            Genre genre = (Genre)comboBox2.SelectedItem;
            Artist artist = (Artist)comboBox3.SelectedItem;
            if (this.button1.Text == "Добавить") {
                PictureComponent.Add(textBox1.Text, price, dateTimePicker1.Value, placement.Id, genre.Id, artist.Id);
            }
            else if (this.button1.Text == "Изменить") 
            {
                if (Index < 0) {
                    MessageBox.Show("");
                    this.Close();
                }
                PictureComponent.Edit(Index, textBox1.Text, price, dateTimePicker1.Value, placement.Id, genre.Id, artist.Id);
            }
            this.Close();
        }

        private void Form_pictures_Load(object sender, EventArgs e)
        {
            if (Index > 0)
            {
                Picture p = PictureComponent.GetPictureByIndex(Index);
                textBox1.Text = p.Name;
                textBox2.Text = p.Price.ToString();
                dateTimePicker1.Value = p.Date;

                Placement placement = ListsComponent.GetObjById<Placement>(p.PlacementId);
                Genre genre = ListsComponent.GetObjById<Genre>(p.GenreId);
                Artist artist = ListsComponent.GetObjById<Artist>(p.ArtistId);
                
                comboBox1.Text = placement?.Name;
                comboBox2.Text = genre?.Name;
                comboBox3.Text = artist?.Name;
            }
        }

        // цена картины реагирует только на цифры, другие символы игнорирует
        // + возможен ввод одной запятой
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
