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
    public partial class AddEmployee : Form
    {
    
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                string Name = textBox1.Text;
                int Id = Convert.ToInt32(textBox2.Text);
                EmployeeLogic empL = new EmployeeLogic();
                empL.EmployeeAdd(Name, Id);
                Close();
            }
            else
            {
                MessageBox.Show("Не все заполнено!");
            }
        }
    }
}
