using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Список_отделов
{
    public partial class Form_department : Form
    {
        public Button Button { get { return button1; } }
        public int? Index { get; set; }
        public Form_department(string labelText, string buttonText)
        {
            Index = -1;
            InitializeComponent();
            Text = labelText;
            button1.Text = buttonText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (button1.Text == "Добавить")
                {
                    Department dep = new Department();
                    dep.Name = textBox1.Text;
                    ListsComponent.Add(dep);
                    Close();
                }
                if (button1.Text == "Изменить")
                {
                    Department dep = ListsComponent.GetObjById<Department>(Index);
                    dep.Name = textBox1.Text;
                    ListsComponent.Edit(dep);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поле, чтобы добавить отдел.");
            }
        }

        private void Form_department_Load(object sender, EventArgs e)
        {
            if (Index > 0)
            {
                Department d = ListsComponent.GetObjById<Department>(Index);
                textBox1.Text = d.Name;
            }
        }

        /*private void Form_expos_Load(object sender, EventArgs e)
        {

            if (button1.Text != "Изменить")
                return;
        }*/
    }
}
