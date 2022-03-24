﻿using System;
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
    public partial class Form_Hdds : Form
    {
        public Form_Hdds()
        {
            InitializeComponent();
        }



        private void Form_Hdds_Load(object sender, EventArgs e)
        {
            initTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
           // new AddHdd().ShowDialog();
           Form_Add_Hdd  adh = new Form_Add_Hdd();
            adh.MdiParent = this.MdiParent;
            adh.FormClosing += MdiChildClose;
            adh.Show();
            //initTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void initTable()
        {
            dataGridView1.DataSource = new Context().Hdds.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Объем";
            dataGridView1.Columns[3].HeaderText = "Производитель";
        }
        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }
    }
}
