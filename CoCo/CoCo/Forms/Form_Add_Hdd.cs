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
    public partial class Form_Add_Hdd : Form
    {
      
        public Form_Add_Hdd()
        {
            InitializeComponent();
        }
        private void AddHdd_Load(object sender, EventArgs e)
        {
        
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox1.Text.Length > 300)
                {
                    MessageBox.Show(
                    "Название слишком длинное",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else if (textBox3.Text.Length > 300)
                {
                    MessageBox.Show(
                    "Название слишком длинное",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else try
                    {
                        decimal volume = Convert.ToDecimal(textBox2.Text);
                        if (volume < 0 || volume > 2000)
                        {
                            MessageBox.Show(
                            "Не поддерживаемая частота",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            Hdd_Logic hdd_Logic = new Hdd_Logic();
                            try
                            {
                                hdd_Logic.Add(textBox1.Text, volume, textBox3.Text);
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
                    catch
                    {
                        MessageBox.Show(
                        "Неверный формат ввода частоты",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                Context context = new Context();    
                Hdd hdd = new Hdd();
                hdd.Name = textBox1.Text;
                hdd.Volume = Convert.ToDecimal(textBox2.Text);
                hdd.Manufacturer = textBox3.Text;
                context.Hdds.Add(hdd);
                context.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Не все заполнено!");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
