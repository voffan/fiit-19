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
        string name, manu;
        public ChangeMotherboard(int _mb, string _name, string _manu)
        {
            InitializeComponent();
            MBId = _mb;
            name = _name;
            manu = _manu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string manu = textBox2.Text;
            MotherboardLogic.Change(name, manu, MBId);
            Close();
        }

        private void ChangeMotherboard_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = manu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
