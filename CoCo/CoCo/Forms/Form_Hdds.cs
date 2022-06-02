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
    public partial class Form_Hdds : Form
    {
        public Form_Hdds()
        {
            InitializeComponent();
        }

        private void Form_Hdds_Load(object sender, EventArgs e)
        {
            initTable();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // new AddHdd().ShowDialog();
            AddHdd adh = new AddHdd
            {
                MdiParent = this.MdiParent
            };
            adh.FormClosing += MdiChildClose;
            adh.Show();
            //initTable();
        }



        private void initTable()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Hdds.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Объем";
            dataGridView1.Columns[3].HeaderText = "Производитель";
        }
        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete() == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    HddLogic.Delete((int)dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                initTable();
            }
        }
        private void textChange()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Hdds.Where(h =>
            h.Name.Contains(textBox1.Text) &&
            h.Manufacturer.Contains(textBox3.Text) &&
            h.Volume.ToString().Contains(textBox2.Text)).ToList();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            int HddId = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            Hdd hdd = new Hdd();
            ChangeHdd adh = new ChangeHdd(HddId, Convert.ToString(dataGridView1.SelectedCells[1].Value), Convert.ToString(dataGridView1.SelectedCells[2].Value), Convert.ToString(dataGridView1.SelectedCells[3].Value))
            {
                MdiParent = this.MdiParent
            };
            adh.FormClosing += MdiChildClose;
            adh.Show();
        }
    }
}
