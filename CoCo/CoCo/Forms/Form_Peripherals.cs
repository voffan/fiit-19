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
    public partial class Form_Peripherals : Form
    {
        public Form_Peripherals()
        {
            InitializeComponent();
        }

        private void Form_Peripherals_Load(object sender, EventArgs e)
        {
            initTable();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
        }

        private void initTable()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Peripherals.ToList();
            /*dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Производитель";*/
        }
        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPer adh = new AddPer
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
                    PeripheralLogic.Delete((int)dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                initTable();
            }
        }

        private void textChange()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Peripherals.Where(h =>
            h.Name.Contains(textBox1.Text) &&
            h.Manufacturer.Contains(textBox2.Text) &&
            h.Employee.FullName.Contains(textBox3.Text)).ToList();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int perId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            Peripheral per = new Peripheral();
            ChangePer adh = new ChangePer(perId)
            {
                MdiParent = this.MdiParent
            };
            adh.FormClosing += MdiChildClose;
            adh.Show();
        }

        private void button_Write_Off_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                PeripheralLogic.ChangeStatus((int)dataGridView1.SelectedRows[i].Cells["id"].Value, Status.writtenoff);
            }
            initTable();
        }

        private void repair_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                ids.Add((int)dataGridView1.SelectedRows[i].Cells["id"].Value);
            }
            AddRepair addRepair = new AddRepair(ids)
            {
                MdiParent = this.MdiParent
            };
            addRepair.FormClosing += MdiChildClose;
            addRepair.Show();
        }
    }
}
