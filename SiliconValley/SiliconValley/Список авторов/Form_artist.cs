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
    public partial class Form_artist : Form
    {
        public Button Button { get { return button1; } }

        public Form_artist()
        {
            // конструктор поменять, добавить во вход инт айди
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Добавить")
            {
                ArtistComponent.Add(textBox1.Text, dateTimePicker1.Value);
            }
            else if (this.button1.Text == "Изменить")
            {
                ArtistComponent.Edit(/* айди */);
            }
            this.Close();
        }
    }
}
