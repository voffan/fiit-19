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
    public partial class AddPc : Form
    {
        public AddPc()
        {
            InitializeComponent();
        }

        private void AddPc_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                comboBox1.DataSource = (from h in c.Hdds select new { Id = h.Id, Name = h.Name + " " + h.Volume + "ГБ " + h.Manufacturer }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";

                comboBox2.DataSource = (from cp in c.Cpus select new { Id = cp.Id, Name = cp.Name + " " + cp.Frequency + "ГГц " + cp.Manufacturer }).ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";

                comboBox3.DataSource = (from m in c.Motherboards select new { Id = m.Id, Name = m.Name + " " + m.Manufacturer}).ToList();
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "Id";

                comboBox4.DataSource = (from em in c.Employees select new {Id = em.Id,  Name = em.FullName + " " + em.DepartmentId + " отдел"}).ToList();
                comboBox4.DisplayMember = "Name";
                comboBox4.ValueMember = "Id";
               // comboBox1.Items.Add((from em in c.Employees select new { Id = em.Id, Name = em.FullName + " " + em.DepartmentId + "отдел" }).ToList()[i).Name;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PCLogic.Add((int)comboBox1.SelectedValue, (int)comboBox2.SelectedValue, (int)comboBox3.SelectedValue, (int)comboBox4.SelectedValue);
            Close();
    
        }
    }
}
