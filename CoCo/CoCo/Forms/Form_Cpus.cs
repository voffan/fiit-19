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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            var CpuId = dataGridView1.SelectedCells[0].Value;
            Cpu cpu = new Cpu();
            ChangeCpu adh = new ChangeCpu(CpuId,Convert.ToString(dataGridView1.SelectedCells[1].Value), Convert.ToString(dataGridView1.SelectedCells[2].Value), Convert.ToString(dataGridView1.SelectedCells[3].Value))
            {
                MdiParent = this.MdiParent
            };
            adh.FormClosing += MdiChildClose;
            adh.Show();
        
        }


        private void textChange()
        {
            using (Context context = new Context())
            {
                dataGridView1.DataSource = context.Cpus.Where(h =>
                h.Name.Contains(textBox1.Text) &&
                h.Manufacturer.Contains(textBox3.Text) &&
                h.Frequency.ToString().Contains(textBox2.Text)).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }
    }

}
