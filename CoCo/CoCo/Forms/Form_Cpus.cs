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
    public partial class Form_Cpus : Form
    {
        public Form_Cpus()
        {
            InitializeComponent();
        }

        private void Form_Cpus_Load(object sender, EventArgs e)
        {
            initTable();
        }

        private void initTable()
        {
            dataGridView1.DataSource = new Context().Cpus.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Частота";
            dataGridView1.Columns[3].HeaderText = "Производитель";
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            // new AddHdd().ShowDialog();
            AddCpu adh = new AddCpu
            {
                MdiParent = this.MdiParent
            };
            adh.FormClosing += MdiChildClose;
            adh.Show();
            //initTable();
        }
        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete())
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    CpuLogic.Delete(dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                initTable();
            }
        }
    }
}
