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
        /*public static Context context = new Context();*/
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*comboBox1.DataSource = new BindingSource(Classes.DescriptionAttributes<Classes.Sportsman>.RetrieveAttributes(), null);*/
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            /*if (comboBox1.SelectedValue is string)
                Classes.Sportsman st = (Classes.Sportsman)Enum.Parse(typeof(Classes.Sportsman), (string)comboBox1.SelectedValue);*/
        }
    }
}
