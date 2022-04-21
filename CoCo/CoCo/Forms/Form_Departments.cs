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
using CoCo.Classes;

namespace CoCo
{
    public partial class Form_Departments : Form
    {
        public Form_Departments()
        {
            InitializeComponent();
        }

        private void Form_Departments_Load(object sender, EventArgs e)
        {
            initTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddDepartments addprt = new AddDepartments();
            addprt.MdiParent = this.MdiParent;
            addprt.FormClosing += MdiChildClose;
            addprt.Show();
        }

        private void MdiChildClose(object sender, FormClosingEventArgs e)
        {
            initTable();
        }

        private void initTable()
        {
            dataGridView1.DataSource = new Context().Departments.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var depId = dataGridView1.SelectedCells[0].Value;
            Department dep = new Department();
            ChangeDepartment adh = new ChangeDepartment(depId);
            adh.MdiParent = this.MdiParent;
            adh.FormClosing += MdiChildClose;
            adh.Show();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Delete_Message.Message())
                DepartmentLogic.Delete(dataGridView1.SelectedCells[0].Value);
        }
    }
}
