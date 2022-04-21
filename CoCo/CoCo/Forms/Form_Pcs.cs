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
            /*dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "HDD";
            dataGridView1.Columns[2].HeaderText = "CPU";
            dataGridView1.Columns[3].HeaderText = "Мotherboard";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPc addPc = new AddPc();


            addPc.MdiParent = this.MdiParent;
            addPc.FormClosing += MdiChildClose;
            addPc.Show();
        }

        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Delete_Message.Message())
            {
                for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    PC_Logic.Delete(dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                
                initTable();
            }
                
        }
    }
}
