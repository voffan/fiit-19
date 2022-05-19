using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Classes;
using App.Logic;

namespace App
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Context c = new Context();
             Employee emp = new Employee();
             emp.Name = "";
             emp.Passport = "";
             emp.Birthday = Convert.ToDateTime("01.01.2000");
             emp.PhoneNumber = "123456";
             emp.Position = Position.cashier;
             emp.Login = "asd";
             emp.Password = "123";
             c.Employees.Add(emp);
             c.SaveChanges();*/
            try
            {
                Employee emp = EmployeeLogic.Authorize(textBox1.Text, textBox2.Text);
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Введите логин!");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите пароль!");
                    return;
                }
                if (emp==null)
                {
                    MessageBox.Show("Неверный пароль или логин!");
                    return;
                }
                Mainmenu form2 = new Mainmenu();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
