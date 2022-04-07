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
    public partial class ChangeEmployees : Form
    {
        List<Employee> employeeList;
        public ChangeEmployees()
        {
            InitializeComponent();
        }

        private void ChangeEmployees_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
