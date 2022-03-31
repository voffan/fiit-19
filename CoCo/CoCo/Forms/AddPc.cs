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

namespace CoCo.Forms
{
    public partial class AddPc : Form
    {
        List<PC> PCs;
        public AddPc()
        {
            InitializeComponent();
        }

        private void AddPc_Load(object sender, EventArgs e)
        {
            PCs = new List<PC>();
            // dataGridView1.DataSource = PCs;
            using (Context c = new Context())
            {
                comboBox1.DataSource = (from h in c.Hdds select new { Id = h.Id, Name = h.Name + " " + h.Volume + "ГБ " + h.Manufacturer }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
