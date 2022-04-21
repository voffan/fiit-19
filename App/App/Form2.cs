using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Classes;
using App.Logic;

namespace App
{
    public partial class Form2 : Form
    {
        int cat;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Context con = new Context();
            dataGridView1.DataSource = con.Orders.ToList();

        }

        private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cat = 4;
            Context con = new Context();
            dataGridView1.DataSource = con.Genres.ToList();
        }

        private void дискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context con = new Context();
            dataGridView1.DataSource = con.Disks.ToList();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context con = new Context();
            dataGridView1.DataSource = con.Clients.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cat)
            {
                case 4: Form3 form3 = new Form3(); form3.Show(); break;
                case 1: Form4 form4 = new Form4(); form4.Show(); break;
            }     
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cat = 1;
        }
    }
}
