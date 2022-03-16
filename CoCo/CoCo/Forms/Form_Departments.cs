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
    public partial class Form_Departments : Form
    {
        public Form_Departments()
        {
            InitializeComponent();
        }

        private void Form_Departments_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Context().Departments.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
        }
    }
}
