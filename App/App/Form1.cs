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
    public partial class Form1 : Form
    {
        public Form1()
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
                if(emp == null)
                {
                    MessageBox.Show("Неправильный логин или пароль!!!");
                    return;
                }
                MessageBox.Show("Success");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
