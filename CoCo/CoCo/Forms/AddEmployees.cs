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
    public partial class AddEmployees : Form
    {
        List<Employee> employeeList;
        public AddEmployees()
        {
            InitializeComponent();
        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {
            employeeList = new List<Employee>();
            dataGridView1.DataSource = employeeList;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                Context context = new Context();
                Employee emp = new Employee();
                emp.FullName = textBox1.Text;
                emp.DepartmentId = Convert.ToInt32(textBox2.Text);
                context.Employees.Add(emp);
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
