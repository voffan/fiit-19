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
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete())
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    RepairLogic.Delete(dataGridView1.SelectedRows[i].Cells["deviceid"].Value);
                }
                initTable();
            }
        }
        private void initTable()
        {
            dataGridView1.DataSource = new Context().Repairs.ToList();
        }
    }
}
