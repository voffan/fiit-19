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
            cat = 1;
            InitTable();
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
            InitTable();
        }

        private void дискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cat = 3;
            InitTable();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cat = 2;
            InitTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cat)
            {
                case 4: Form3 form3 = new Form3(); form3.ShowDialog(); break;
                case 1: Form4 form4 = new Form4(); form4.ShowDialog(); break;
                case 5: Form5 form5 = new Form5(); form5.ShowDialog(); break;
            }
            InitTable();
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cat = 1;
            InitTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void InitTable()
        {
            using (Context con = new Context())
            {
                switch (cat)
                {
                    case 4: dataGridView1.DataSource = con.Genres.ToList(); break;
                    case 1: dataGridView1.DataSource = con.Orders.ToList(); break;
                    case 2: dataGridView1.DataSource = con.Clients.ToList();break;
                    case 3: dataGridView1.DataSource = con.Disks.ToList(); break;
                    case 5: dataGridView1.DataSource = con.Humen.ToList(); break;
                }
            }
        }

        private void фИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cat = 5;
            InitTable();
        }
    }
}
