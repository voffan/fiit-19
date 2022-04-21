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

namespace SiliconValley.Список_картин
{
    public partial class Form_pictures : Form
    {
        public Button Button { get { return button1; } }
        public int Index { get; set; }
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
                for (int i = 0; i < db.Placements.Count(); i++) {
                    comboBox1.Items.Add(db.Placements.ToList()[i].Name);
                }
                for (int i = 0; i < db.Genres.Count(); i++) {
                    comboBox2.Items.Add(db.Genres.ToList()[i].Name);
                }
                for (int i = 0; i < db.Artists.Count(); i++) {
                    comboBox3.Items.Add(db.Artists.ToList()[i].Name);
                }
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = double.Parse(textBox2.Text);
            Placement placement = new Placement();
            Genre genre = ListsComponent.GetGenreByName(comboBox2.Text);
            Artist artist = ArtistComponent.GetArtistByName(comboBox3.Text);
            if (this.button1.Text == "Добавить") {
                PictureComponent.Add(textBox1.Text, price, dateTimePicker1.Value, placement, genre, artist);
            }
            else if (this.button1.Text == "Изменить") {
                if (Index < 0) {
                    MessageBox.Show("");
                    this.Close();
                }
                PictureComponent.Edit(Index, textBox1.Text, price, dateTimePicker1.Value, placement, genre, artist);
            }
            this.Close();
        }
    }
}
