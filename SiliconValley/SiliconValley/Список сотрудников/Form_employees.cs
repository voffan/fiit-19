﻿using SiliconValley.Список_Жанров;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_сотрудников
{
    public partial class Form_employees : Form
    {
        int id;
        public Form_employees(string title,string buttonText)
        {
            InitializeComponent();
            Text = title;
            button1.Text = buttonText;
        }

        public Form_employees(string title, string buttonText,int id):this(title, buttonText)
        {
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_employees_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Добавить")
            {
                AddEmployee();
                Close();
            }

            if (button1.Text == "Изменить")
            {
                ChangeEmployee();
                Close();
            }
        }

        void InitForm()
        {
            //init ComboBox
            /*Array posItems = Enum.GetValues(pos.GetType());
            Array eduItems = Enum.GetValues(edu.GetType());*/

            comboBox1.DataSource = new BindingSource(DescriptionAttributes<Position>.RetrieveAttributes(), null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";

            comboBox2.DataSource = new BindingSource(DescriptionAttributes<Education>.RetrieveAttributes(), null);
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";

            if (button1.Text == "Изменить")
            {

                Employee employee = ListsComponent.GetObjById<Employee>(id);

                textBox1.Text = employee.Login;
                textBox2.Text = employee.Password;
                textBox3.Text = employee.PhoneNumber;
                dateTimePicker1.Value = employee.Birthday;
                comboBox1.SelectedItem = employee.Position;
                comboBox2.SelectedItem = employee.Education;
            }
        }


        void AddEmployee()
        {
            Employee employee = new Employee();

            employee.Login = textBox1.Text;
            employee.Password = textBox2.Text;
            employee.PhoneNumber = textBox3.Text;

            employee.Birthday = dateTimePicker1.Value;

            employee.Position = (Position)Enum.Parse(typeof(Position), (string)comboBox1.SelectedValue);
            employee.Education = (Education)Enum.Parse(typeof(Education), (string)comboBox2.SelectedValue);

            ListsComponent.Add(employee);
        }

        void ChangeEmployee()
        {
            Employee employee = ListsComponent.GetObjById<Employee>(id);

            employee.Login = textBox1.Text;
            employee.Password = textBox2.Text;
            employee.PhoneNumber = textBox3.Text;

            employee.Birthday = dateTimePicker1.Value;

            employee.Position = (Position)Enum.Parse(typeof(Position), (string)comboBox1.SelectedValue);
            employee.Education = (Education)Enum.Parse(typeof(Education), (string)comboBox2.SelectedValue);

            ListsComponent.Edit(employee);
        }
    }
}
