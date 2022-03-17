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
            Form form = new Form_Pcs();
            form.MdiParent = this;
            form.Show();
            

        }

        private void периферияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Peripherals();
            form.MdiParent = this;
            form.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Employees();
            form.MdiParent = this;
            form.Show();
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Departments();
            form.MdiParent = this;
            form.Show();
        }

        private void матПлатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Motherboards();
            form.MdiParent = this;
            form.Show();
        }

        private void жДискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Hdds();
            form.MdiParent = this;
            form.Show();
        }

        private void процессорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Cpus();
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
