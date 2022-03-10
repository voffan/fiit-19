using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportAchievements.Classes;
using System.Windows.Forms;

namespace SportAchievements.Components
{
    public static class EmployeeComp
    {
        public static Employee AddEmployee(Context con, string lgn, string psw, string FIO, DateTime bdate, Position pos)
        {
            Employee empl1 = (from person in con.Employees
                where person.Login == lgn
                select person).FirstOrDefault();

            if (empl1 == null)
            {
                Employee empl = new Employee();
                empl.Name = FIO;
                empl.Position = pos;
                empl.Login = lgn;
                empl.Pwd = psw;
                empl.BirthDate = bdate;
                con.Persons.Add(empl);
                con.SaveChanges();
                return empl;
            }
            throw new Exception("Пользователь с заданным логином уже существует!");
        }
    }
}
