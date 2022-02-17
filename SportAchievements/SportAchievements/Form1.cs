using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportAchievements
{
    public partial class Form1 : Form
    {
        public Context context = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new BindingSource(Classes.DescriptionAttributes<Classes.Gender>.RetrieveAttributes(), null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            /*if (comboBox1.SelectedValue is string)*/
            Classes.Gender st = (Classes.Gender)Enum.Parse(typeof(Classes.Gender), (string)comboBox1.SelectedValue);
        }
    }
}
