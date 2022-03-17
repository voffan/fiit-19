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
            dataGridView1.DataSource = new Context().PCs.ToList();
            /*dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "HDD";
            dataGridView1.Columns[2].HeaderText = "CPU";
            dataGridView1.Columns[3].HeaderText = "Motherboard";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context context = new Context();    
            PC pC = new PC();   

        }
    }
}
