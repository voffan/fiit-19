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
    public partial class ChangePer : Form
    {
        object emplId;
        public ChangePer(object _empl)
        {
            InitializeComponent();
            emplId = _empl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string manu = textBox2.Text;
            string empl = comboBox1.Text;
            PeripheralLogic.PeripheralChange(name, manu, emplId);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
