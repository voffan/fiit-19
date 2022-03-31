using System;
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
   
    public partial class Form_Add_Motherboard : Form
    {
       
        public Form_Add_Motherboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text.Length > 300)
                {
                    MessageBox.Show(
                    "Название слишком длинное",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else if (textBox2.Text.Length > 300)
                {
                    MessageBox.Show(
                    "Название слишком длинное",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                    {

                        Motherboard motherboard = new Motherboard();
                        try
                        {
                            motherboard.Add(textBox1.Text, textBox2.Text);
                            Close();
                        }
                        catch
                        {
                                MessageBox.Show(
                                "Ошибка сервера",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
               
              
               
            }
            else
            {
                  MessageBox.Show(
                 "Заполните все поля",
                  "Сообщение",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void Form_Add_Motherboard_Load(object sender, EventArgs e)
        {

        }
    }
}
