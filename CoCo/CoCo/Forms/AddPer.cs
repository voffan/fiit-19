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

        private void AddPer_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {

                comboBox1.DataSource = (from em in c.Employees select new { em.Id, Name = em.FullName + ", " + em.DepartmentId + " отдел" }).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }
    }
}
