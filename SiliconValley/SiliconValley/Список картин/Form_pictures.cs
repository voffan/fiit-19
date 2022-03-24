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
            // инициализировать комбобоксы списком жанров и списком художников
            // dateTime можно изменить, т.к. нам нужен только год написания картины
            using (var db = new Context())
            {
                comboBox1.DataSource = db.Departments.ToList();
                comboBox2.DataSource = db.Genres.ToList(); // взять только названия
                comboBox3.DataSource = db.Artists.ToList();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = double.Parse(textBox2.Text);
            Placement placement = new Placement();
            Genre genre = new Genre();
            Artist artist = new Artist();
            if (this.button1.Text == "Добавить")
            {
                PictureComponent.Add(textBox1.Text, price, dateTimePicker1.Value, placement, genre, artist);
            }
            else if (this.button1.Text == "Изменить")
            {
                if (Index < 0)
                {
                    MessageBox.Show("");
                    this.Close();
                }
                PictureComponent.Edit(Index, textBox1.Text, price, dateTimePicker1.Value, placement, genre, artist);
            }
            this.Close();
        }
    }
}
