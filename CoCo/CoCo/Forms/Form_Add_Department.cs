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
    public partial class Form_Add_Department : Form
    {
       
        public Form_Add_Department()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 300 )
            {
                MessageBox.Show(
                       "Название слишком длинное",
                       "Сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
               
            }
            else
            {
                Department dprt = new Department();
                dprt.Add(textBox1.Text);
                Close();
            }
        }

        private void Form_Add_Department_Load(object sender, EventArgs e)
        {

        }
    }
}
