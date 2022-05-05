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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox1.Select();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                Human h = new Human();
                h.Name = textBox1.Text;
                c.Humen.Add(h);
                c.SaveChanges();
            }
            Close();
        }
    }
}
