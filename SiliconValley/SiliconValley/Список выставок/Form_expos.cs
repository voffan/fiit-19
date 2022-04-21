﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiliconValley.Список_Жанров;

namespace SiliconValley.Список_выставок
{
    public partial class Form_expos : Form
    {
        int id;
        public Form_expos(string labelText, string buttonText)
        {
            InitializeComponent();

            Text = labelText;
            button1.Text = buttonText;
        }

        public Form_expos(string labelText, string buttonText, int id) : this(labelText, buttonText)
        {
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Добавить")
            {
                AddExpos();

                Close();
            }

            if (button1.Text == "Изменить")
            {
                ChangeExpo();

                Close();
            }
        }
        void AddExpos()
        {
            Expo expo = new Expo();
            expo.Name = textBox1.Text;

            ExposComponent.Add(expo);
        }

        void ChangeExpo()
        {
            Expo expo = ExposComponent.GetObjById<Expo>(id);
            expo.Name = textBox1.Text;

            ExposComponent.Edit(expo);
        }
        private void Form_expos_Load(object sender, EventArgs e)
        {

            if (button1.Text != "Изменить")
                return;

            Expo expo = ExposComponent.GetObjById<Expo>(id);

            textBox1.Text = expo.Name;
            dateTimePicker1.Value = expo.Start;
            dateTimePicker2.Value = expo.End;
        }
    }
}
