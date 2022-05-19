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
    public partial class Mainmenu : Form
    {
        int cat;
        public Mainmenu()
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
                case 4: FilmName form3 = new FilmName(); form3.ShowDialog(); break;
                case 1: Order form4 = new Order(); form4.ShowDialog(); break;
                case 5: People form5 = new People(); form5.ShowDialog(); break;
                case 8: Disk form6 = new Disk(); form6.ShowDialog(); break;
                case 3: Form7 form7 = new Form7(); form7.ShowDialog(); break;
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
                    case 6: dataGridView1.DataSource = con.Clients.ToList(); break;
                    case 7: dataGridView1.DataSource = con.People.ToList(); break;
                    case 8: dataGridView1.DataSource = con.Films.ToList(); break;
                }
            }
        }

        private void фИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cat = 5;
            InitTable();
        }

        private void черныйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cat = 6;
            InitTable();
        }

        private void данныеКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cat = 7;
            InitTable();
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cat = 8;
            InitTable();
        }
    }
}
