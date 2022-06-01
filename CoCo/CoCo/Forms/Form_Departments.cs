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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddDepartment addprt = new AddDepartment
            {
                MdiParent = this.MdiParent
            };
            addprt.FormClosing += MdiChildClose;
            addprt.Show();
        }

        private void MdiChildClose(object sender, FormClosingEventArgs e)
        {
            initTable();
        }

        private void initTable()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Departments.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int depId = (int)dataGridView1.SelectedCells[0].Value;
            Department dep = new Department();
            ChangeDepartment adh = new ChangeDepartment(depId, Convert.ToString(dataGridView1.SelectedCells[1].Value))
            {
                MdiParent = this.MdiParent
            };
            adh.FormClosing += MdiChildClose;
            adh.Show();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete() == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    DepartmentLogic.Delete((int)dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                initTable();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Departments.Where(h => h.Name.Contains(textBox1.Text)).ToList();
        }
    }
}
