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
    public partial class Form_Add_Hdd : Form
    {
      
        public Form_Add_Hdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                HddLogic.Add(textBox1.Text, Convert.ToDecimal(textBox2.Text), textBox3.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Не все заполнено!");
            }
            
        }
    }
}
