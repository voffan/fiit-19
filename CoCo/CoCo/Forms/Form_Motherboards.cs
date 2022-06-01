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
    public partial class Form_Motherboards : Form
    {
        public static Context context = new Context();
        public Form_Motherboards()
        {
            InitializeComponent();
        }

        private void Motherboards_Load(object sender, EventArgs e)
        {
            initTable();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
        }

        private void initTable()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Motherboards.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Производитель";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMotherboard mthb = new AddMotherboard
            {
                MdiParent = this.MdiParent
            };
            mthb.FormClosing += MdiChildClose;
            mthb.Show();
        }
        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete() == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    MotherboardLogic.Delete(dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                initTable();
            }
        }

        private void textChange()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Motherboards.Where(h => h.Name.Contains(textBox1.Text) && h.Manufacturer.Contains(textBox2.Text)).ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int MBId = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            Motherboard mb = new Motherboard();
            ChangeMotherboard mot = new ChangeMotherboard(MBId, Convert.ToString(dataGridView1.SelectedCells[1].Value), Convert.ToString(dataGridView1.SelectedCells[2].Value))
            {
                MdiParent = this.MdiParent
            };
            mot.FormClosing += MdiChildClose;
            mot.Show();
        }
    }
}
