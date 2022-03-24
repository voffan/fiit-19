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
            initTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployees adh = new AddEmployees();
            adh.MdiParent = this.MdiParent;
            adh.FormClosing += MdiChildClose;
            adh.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void initTable()
        {
            dataGridView1.DataSource = new Context().Employees.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер сотрудника";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Номер отдела";
            dataGridView1.Columns[3].HeaderText = "Название отдела";
        }
        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }
    }
}
