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
    public partial class ChangeCpu : Form
    {
        int cpuId;
        string name, freq, manu;
        public ChangeCpu(int _cpu, string _name, string _freq, string _manu)
        {
            InitializeComponent();
            cpuId = _cpu;
            name = _name;
            freq = _freq;
            manu = _manu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string manu= textBox3.Text;
            decimal freq = Convert.ToDecimal(textBox2.Text);
            CpuLogic.CpuChange(name, freq, manu, cpuId);
            Close();
        }

        private void ChangeCpu_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = freq;
            textBox3.Text = manu;
        }
    }
}
