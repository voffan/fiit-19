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
using CoCo.Classes;

namespace CoCo
{
    public partial class Form_Employees : Form
    {
        public Form_Employees()
        {
            InitializeComponent();
        }

        private void Form_Employees_Load(object sender, EventArgs e)
        {
            initTable();
        }

        private void initTable()
        {
            dataGridView1.DataSource = new Context().Employees.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер сотрудника";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Номер отдела";
            dataGridView1.Columns[3].HeaderText = "Название отдела";
        }
        private void MdiChildClose(Object sender, FormClosingEventArgs e)
        {
            initTable();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            AddEmployee adh = new AddEmployee
            {
                MdiParent = this.MdiParent
            };
            adh.FormClosing += MdiChildClose;
            adh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int emplId = (int)dataGridView1.SelectedCells[0].Value;
            Employee emp = new Employee();
            ChangeEmployee adh = new ChangeEmployee(emplId)
            {
                MdiParent = this.MdiParent
            };
            adh.FormClosing += MdiChildClose;
            adh.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Messages.ConfirmDelete())
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    EmployeeLogic.Delete((int)dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                initTable();
            }
        }
        private void textChange()
        {
            using (Context context = new Context())
            {
                dataGridView1.DataSource = context.Employees.Where(h =>
                h.FullName.Contains(textBox1.Text) &&
                h.DepartmentId.ToString().Contains(textBox2.Text)).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textChange();
        }


    }
}
