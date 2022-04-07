using SiliconValley.Авторизация;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;

            if (login == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (pass == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            try
            {
                Auth.Check(login, pass);
                MessageBox.Show("Вы успешно авторизовались!");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                //return; 
            }
            
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            Close();
        }
    }
}
