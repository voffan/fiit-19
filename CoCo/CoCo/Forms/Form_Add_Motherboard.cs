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
   
    public partial class Form_Add_Motherboard : Form
    {
        List<Motherboard> motherboardList;
        public Form_Add_Motherboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 )
            {
                Context context = new Context();
                Motherboard motherboard = new Motherboard();
                motherboard.Name = textBox1.Text;
               
                motherboard.Manufacturer = textBox2.Text;
                context.Motherboards.Add(motherboard);
                context.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Не все заполнено!");
            }
        }
    }
}
