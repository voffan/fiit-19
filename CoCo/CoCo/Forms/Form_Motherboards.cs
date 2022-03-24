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
        }


        private void initTable()
        {
            dataGridView1.DataSource = new Context().Motherboards.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Производитель";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form_Add_Hdd adh = new Form_Add_Hdd();
            //adh.MdiParent = this.MdiParent;
            //adh.FormClosing += MdiChildClose;
            //adh.Show();
            Form_Add_Motherboard mthb = new Form_Add_Motherboard();
            mthb.MdiParent = this.MdiParent;
            mthb.FormClosing += MdiChildClose;
            mthb.Show();
        }
        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }
    }
}
