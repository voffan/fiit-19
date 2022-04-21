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
   
    public partial class AddMotherboard : Form
    {
        List<Motherboard> motherboardList;
        public AddMotherboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 )
            {
                MotherboardLogic.Add(textBox1.Text, textBox2.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Не все заполнено!");
            }
        }
    }
}
