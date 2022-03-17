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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void компьютерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Child_Form(new Form_Pcs());
        }

        private void периферияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Child_Form(new Form_Peripherals());
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Child_Form(new Form_Employees());
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Child_Form(new Form_Departments());
        }

        private void матПлатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Child_Form(new Form_Motherboards());
        }

        private void жДискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Child_Form(new Form_Hdds());
        }

        private void процессорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Child_Form(new Form_Cpus());
        }

        private void ремонтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Child_Form(new Form_Repairs());
        }
        private void Show_Child_Form(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context context = new Context();
        }
    }
}
