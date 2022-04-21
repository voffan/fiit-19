using CoCo.Classes;
using System;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class AddPer : Form
    {
        public AddPer()
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
                    "Название производителя слишком длинное",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else try
                    {
                        int empl_id = Convert.ToInt32(textBox2.Text);
                        try
                        {
                            PeripheralLogic.Add(textBox1.Text, textBox2.Text, empl_id);
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
