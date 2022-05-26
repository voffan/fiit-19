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
        string name, vol, manu;
        public ChangeHdd(int _hdd, string _name, string _vol, string _manu)
        {
            InitializeComponent();
            hddId = _hdd;
            name = _name;
            vol = _vol;
            manu = _manu;
        }

        private void ChangeHdd_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = vol;
            textBox3.Text = manu;
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

    }
}
