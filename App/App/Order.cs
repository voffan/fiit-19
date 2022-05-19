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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Pledge));
            label4.Visible = false;
            textBox3.Visible = false;
            using (Context c = new Context())
            {
                comboBox2.DataSource = c.Clients.ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text.Length > 0 && (Pledge)Enum.Parse(typeof(Pledge), comboBox1.Text) == Pledge.other)
            {
                label4.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                Classes.Order g = new Classes.Order();
                g.Client = (Client)comboBox2.SelectedItem;
                c.Orders.Add(g);
                c.SaveChanges();
            }
            Close();
        }
    }
}
