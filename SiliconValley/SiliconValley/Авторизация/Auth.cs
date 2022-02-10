using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Авторизация
{
    class Auth
    {
        Employee user;

        public Auth(string login,string password)
        {
            Check(login,password);
        }

        public void Check(string login,string password)//проверка на аворизации
        {
            int fl = 0;
            using (Context db = new Context())
            {
                var users = db.Employees.ToList();
                foreach (Employee u in users)
                {
                    if (u.Login==login && u.Password == password)
                    {
                        fl = 1;
                        this.user = u;
                        break;
                    }
                }

                if (fl == 1)
                {
                    MessageBox.Show("Вы успешно авторизовались");
                    return;
                }

                MessageBox.Show("Неверный логин или пароль");
            }
        }

    }
}
