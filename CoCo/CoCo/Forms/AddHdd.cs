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

namespace CoCo.Forms
{
    public partial class AddHdd : Form
    {
        List<Hdd> hddList;
        public AddHdd()
        {
            InitializeComponent();
        }

        private void AddHdd_Load(object sender, EventArgs e)
        {
            hddList = new List<Hdd>();
            dataGridView1.DataSource = hddList;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                Context context = new Context();    
                Hdd hdd = new Hdd();
                hdd.Name = textBox1.Text;
                hdd.Volume = Convert.ToDecimal(textBox2.Text);
                hdd.Manufacturer = textBox3.Text;
                context.Hdds.Add(hdd);
                context.SaveChanges();  
            }
            else
            {
                MessageBox.Show("Не все заполнено!");
            }
            
        }
    }
}
