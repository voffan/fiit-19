using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dataGridView1.DataSource = new Context().Peripherals.ToList();
            /*dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Производитель";*/
        }
    }
}
