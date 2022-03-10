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

        public static void DelEmpl(int Id)
        {

            Context c = new Context();
            Employee per = c.Employees.Where(p => p.Id == Id).FirstOrDefault();
            if (per != null)
            {
                c.Employees.Remove(per);
                c.SaveChanges();
            }
        }

        public static Employee ChEmpl(Context con, string lgn, string psw, string FIO, DateTime bdate, Position pos, int Id)
        {
            Context c = new Context();
            Employee per = c.Employees.Where(p => p.Id == Id).FirstOrDefault();
            if (per != null)
            {
                per.Name = FIO;
                per.Position = pos;
                per.Login = lgn;
                per.Pwd = psw;
                per.BirthDate = bdate;
                c.Entry(per).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
                return per;
            }
            return per;
        }
    }
}
