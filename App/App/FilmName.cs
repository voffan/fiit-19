using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Classes;

namespace App
{
    public partial class FilmName : Form
    {
        public FilmName()
        {
            InitializeComponent();
            textBox1.Select();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context c=new Context())
            {
                Genre g = new Genre();
                g.Name = textBox1.Text;
                c.Genres.Add(g);
                c.SaveChanges();
            }
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
