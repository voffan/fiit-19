﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportAchievements.Components;

namespace SportAchievements
{
    public partial class LinkEmployee : Form
    {
        public LinkEmployee()
        {
            InitializeComponent();
        }

        private void LinkEmployee_Load(object sender, EventArgs e)
        {
            bibor.Items.AddRange(new string[] { "Логин", "Пароль", "Должность", "Имя", "Дата рождения" });
            InitTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee Employee = new AddEmployee();
            Employee.ShowDialog();
            InitTable();
        }

        private void InitTable()
        {
            Context c = new Context();
            dataGridView1.DataSource = c.Employees.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Имя";
            dataGridView1.Columns[5].HeaderText = "Дата рождения";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = -1;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                }
                else if (dataGridView1.SelectedCells.Count > 0)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[3].Value);
                }
                else
                {
                    MessageBox.Show("Выберите строку или ячейку!");
                    return;
                }
                EmployeeComp.DelEmpl(id);
                InitTable();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            }
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[3].Value);
            }
            else
            {
                MessageBox.Show("Выберите строку или ячейку!");
                return;
            }

            EmployeeBtns.EditEmpl Employee = new EmployeeBtns.EditEmpl(id);
            Employee.ShowDialog();
            InitTable();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {

                string asd = bibor.Text;
                switch (asd)
                {
                    case "Логин":
                        if (searchTextBox.Text.Length > 0)
                        {

                            dataGridView1.DataSource = c.Employees.Where(o => o.Login.ToString().Contains(searchTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView1.DataSource = c.Employees.ToList();
                        }
                        break;
                    case "Пароль":
                        if (searchTextBox.Text.Length > 0)
                        {

                            dataGridView1.DataSource = c.Employees.Where(o => o.Pwd.ToString().Contains(searchTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView1.DataSource = c.Employees.ToList();
                        }
                        break;
                    case "Должность":
                        if (searchTextBox.Text.Length > 0)
                        {

                            dataGridView1.DataSource = c.Employees.Where(o => o.Position.ToString().Contains(searchTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView1.DataSource = c.Employees.ToList();
                        }
                        break;
                    case "Имя":
                        if (searchTextBox.Text.Length > 0)
                        {

                            dataGridView1.DataSource = c.Employees.Where(o => o.Name.ToString().Contains(searchTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView1.DataSource = c.Employees.ToList();
                        }
                        break;
                    case "Дата рождения":
                        if (searchTextBox.Text.Length > 0)
                        {

                            dataGridView1.DataSource = c.Employees.Where(o => o.BirthDate.ToString().Contains(searchTextBox.Text)).ToList();
                        }
                        else
                        {
                            dataGridView1.DataSource = c.Employees.ToList();
                        }
                        break;
                }
            }
        }
    }
}
