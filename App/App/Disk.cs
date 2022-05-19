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
    public partial class Disk : Form
    {
        public Disk()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new BindingSource(DescriptionAttributes<AgeCategory>.RetrieveAttributes(), null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            using (Context c = new Context())
            {
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                listBox1.DataSource = c.Genres.ToList();
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "Id";

            }
        }
    }
}
