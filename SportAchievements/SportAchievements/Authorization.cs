using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportAchievements
{
    public partial class Authorization : Form
    {
        string Position, Login, Password;
        Form1 form;
        public static Context con;

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Authorization()
        {
            InitializeComponent();
            con = new Context();
            txtPsw.UseSystemPasswordChar = true;
            txtPsw.PasswordChar = '•';
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (txtLgn.Text != "" && txtPsw.Text != "")
            {
                Classes.Employee empl = (from person in con.Employees
                                        where person.Login == txtLgn.Text
                                        select person).FirstOrDefault();
                if ((empl == null) || (empl.Pwd.CompareTo(txtPsw.Text) != 0))
                {
                    MessageBox.Show("Неправильный логин и/или пароль!");
                    return;
                }
                form = new Form1();
                form.Show();
            }
            else MessageBox.Show("Не все поля заполнены!");
        }
    }
}
