using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Classes;

namespace App.Logic
{
    public static class EmployeeLogic
    {
        public static Employee Authorize(string login, string pwd)
        {
            Context c = new Context();
            Employee emp = (from Employee e in c.Employees
                            where e.Login == login && e.Password == pwd
                            select e).FirstOrDefault();
            return emp;
        }
    }
}
