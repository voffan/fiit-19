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
    public partial class Form_Add_Cpu : Form
    {
        public Form_Add_Cpu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Cpu cpu = new Cpu();
                cpu.Name = textBox1.Text;
                cpu.Frequency = Convert.ToInt32(textBox2.Text);
                cpu.Manufacturer = textBox3.Text;

            }
        }
    }
}
