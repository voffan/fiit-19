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

namespace CoCo
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                /*
                Department d = (from Department dep in context.Departments
                               where dep.Id == 1
                               select dep).FirstOrDefault();

                Admin admin = new Classes.Admin();
                admin.FullName = "San";
                admin.Password = "qwerty";
                admin.Department = d;
                context.Admins.Add(admin);
                context.SaveChanges();*/
                Admin admin = (from Admin dep in context.Admins
                               where dep.Id == 2
                               select dep).FirstOrDefault();
            //           if (textBox)
            if (admin == null)
            {
                MessageBox.Show(
                    "Пользователь не найден!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (textBox1.Text == admin.Login && textBox2.Text == admin.Password)
            {
                Hide();
                new Form1().ShowDialog();
                Close();
            }
            else
                MessageBox.Show(
                    "Нвеврный логин или пароль",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((char)Keys.Enter))
            {
                LoginButton_Click(sender, e);
            }
        }

        
    }
}
