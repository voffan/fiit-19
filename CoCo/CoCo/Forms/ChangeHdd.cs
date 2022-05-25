using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoCo.Classes;

namespace CoCo.Forms
{
    public partial class ChangeHdd : Form
    {
        int hddId;

        public ChangeHdd(int _hdd)
        {
            InitializeComponent();
            hddId = _hdd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string manu= textBox3.Text;
            decimal vol = Convert.ToDecimal(textBox2.Text);
            HddLogic.HddChange(name, vol, manu, hddId);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
