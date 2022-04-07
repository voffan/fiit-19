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
    public partial class AddDepartments : Form
    {
        List<Department> departmentList;
        public AddDepartments()
        {
            InitializeComponent();
        }

        private void AddDepartmets_Load(object sender, EventArgs e)
        {
            departmentList = new List<Department>();
            dataGridView1.DataSource = departmentList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                String dname = textBox1.Text;
                DepartmentLogic depL = new DepartmentLogic();
                depL.DepartmentAdd(dname);
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
