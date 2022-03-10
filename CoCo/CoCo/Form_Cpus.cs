﻿using System;
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
    public partial class Form_Cpus : Form
    {
        public Form_Cpus()
        {
            InitializeComponent();
        }

        private void Form_Cpus_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Context().Cpus.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Частота";
            dataGridView1.Columns[3].HeaderText = "Производитель";
        }
    }
}
