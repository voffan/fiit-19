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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form_Add_Department addprt = new Form_Add_Department();
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
    }
}
