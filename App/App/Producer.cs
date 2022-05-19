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
    public partial class Producer : Form
    {
        public Producer()
        {
            InitializeComponent();
        }

        private void Producer_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                listBox1.DataSource = c.Humen.ToList();
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "Id";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                Classes.FilmMaker g = new Classes.FilmMaker();
                g.Human = (Human)listBox1.SelectedItem;
                c.FilmMakers.Add(g);
                c.SaveChanges();
            }
            Close();
        }
    }
}
