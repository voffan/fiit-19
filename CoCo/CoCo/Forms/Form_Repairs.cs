using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoCo.Classes;
using CoCo.Forms;

namespace CoCo
{
    public partial class Form_Repairs : Form
    {
        public Form_Repairs()
        {
            InitializeComponent();
        }

        private void Form_Repairs_Load(object sender, EventArgs e)
        {
            initTable();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete() == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    RepairLogic.Delete((int)dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                initTable();
            }
        }
        private void initTable()
        {
            Context context = new Context();
            dataGridView1.DataSource = context.Repairs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = Messages.RepairComplete();
            if (dr != DialogResult.Cancel)
            {
                RepairStatus rs;
                Status ds;
                if (dr == DialogResult.Yes)
                {
                    rs = RepairStatus.done;
                    ds = Status.working;
                }
                else
                {
                    rs = RepairStatus.failed;
                    ds = Status.broken;
                }
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    RepairLogic.Complete((int)dataGridView1.SelectedRows[i].Cells["id"].Value, (int)dataGridView1.SelectedRows[i].Cells["deviceid"].Value, rs, ds);
                }
                initTable();
            }
        }
    }
}
