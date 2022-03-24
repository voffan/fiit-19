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
    public partial class Form_Add_Per : Form
    {
        public Form_Add_Per()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
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
                else try
                    {
                        string empl_id = Convert.ToDecimal(textBox2.Text);
                        if (freq < 0 || freq > 30)
                        {
                            MessageBox.Show(
                            "Не поддерживаемая частота",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        else
                        {
                            Peripheral per = new Peripheral();
                            try
                            {
                                per.Add(textBox1.Text, empl_id, textBox2.Text);
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
        }
    }
}
