﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoCo.Classes;

namespace CoCo
{
    public partial class Form_Repairs : Form
    {
        public Form_Repairs()
        {
            InitializeComponent();
        }

        private void Form_Repairs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Context().Repairs.ToList();
        }
    }
}
