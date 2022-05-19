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
        object cpuId;
        public ChangeCpu(object _cpu)
        {
            InitializeComponent();
            cpuId = _cpu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string manu= textBox3.Text;
            decimal freq = Convert.ToDecimal(textBox2.Text);
            CpuLogic.CpuChange(name, freq, manu, cpuId);
            Close();
        }
    }
}
