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
        List<Department> departmentList;
        public Form_Add_Department()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 )
            {
                Context context = new Context();
                Department dprt = new Department();
                dprt.Name = textBox1.Text;
               
                context.Departments.Add(dprt);
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
