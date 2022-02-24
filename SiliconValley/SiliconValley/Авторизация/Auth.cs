using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconValley.Авторизация
{
    static class Auth
    {
        public static Employee User { get; set; }

        public static void Check(string login,string password)//проверка на авторизации
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
                        User = u;
                        break;
                    }
                }

                if (fl == 0)
                {
                    throw new Exception("Неверный логин или пароль!");
                }
            }
        }

    }
}
