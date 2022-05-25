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
    public partial class ChangeMotherboard : Form
    {
        int MBId;
        public ChangeMotherboard(int _mb)
        {
            InitializeComponent();
            MBId = _mb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string manu = textBox2.Text;
            MotherboardLogic.Change(name, manu, MBId);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
