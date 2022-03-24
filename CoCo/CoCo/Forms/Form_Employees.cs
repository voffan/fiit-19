using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoCo.Forms;

namespace CoCo
{
    public partial class Form_Employees : Form
    {
        public Form_Employees()
        {
            InitializeComponent();
        }

        private void Form_Employees_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Context().Employees.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер сотрудника";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Номер отдела";
            dataGridView1.Columns[3].HeaderText = "Название отдела";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddEmployees().ShowDialog();
        }
    }
}
