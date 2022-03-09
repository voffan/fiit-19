﻿using System;
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
        public int Index { get; set; }

        public Form_artist()
        {
            Index = -1;
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
                if (Index < 0) 
                {
                    MessageBox.Show("");
                    this.Close();
                }
                ArtistComponent.Edit(Index, textBox1.Text, dateTimePicker1.Value);
            }
            this.Close();
        }

        private void Form_artist_Load(object sender, EventArgs e)
        {
            if (Index > 0) 
            {
                Artist a = ArtistComponent.GetArtistByIndex(Index);
                textBox1.Text = a.Name;
                dateTimePicker1.Value = a.Birthday;
            }
        }
    }
}
