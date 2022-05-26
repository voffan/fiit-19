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
    public partial class Form_Pcs : Form
    {
        public Form_Pcs()
        {
            InitializeComponent();
        }

        private void Form_Pcs_Load(object sender, EventArgs e)
        {
           initTable();
        }

        private void initTable()
        {
            dataGridView1.DataSource = new Context().PCs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPc addPc = new AddPc
            {
                MdiParent = this.MdiParent
            };
            addPc.FormClosing += MdiChildClose;
            addPc.Show();
        }

        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete() == DialogResult.OK)
            {
                for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    PCLogic.Delete((int)dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                initTable();
            }
                
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


        private void textChange()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.PCs.Where(h => 
            h.Hdd.Name.Contains(textBox1.Text) && 
            h.Cpu.Name.Contains(textBox2.Text) && 
            h.Motherboard.Name.Contains(textBox3.Text)&&
            h.Employee.FullName.Contains(textBox4.Text)
            ).ToList();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void button_Write_Off_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                PCLogic.ChangeStatus((int)dataGridView1.SelectedRows[i].Cells["id"].Value, Status.writtenoff);
            }
            initTable();
        }
    }
}
