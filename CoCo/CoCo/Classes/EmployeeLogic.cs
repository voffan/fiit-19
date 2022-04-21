using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCo.Forms;
using System.Windows.Forms;

namespace CoCo.Classes
{
    internal class EmployeeLogic
    {
        public void EmployeeAdd(string Name, int Id)
        {
            Context context = new Context();
            Employee emp = new Employee();
            emp.FullName = Name;
            emp.DepartmentId = Id;
            context.Employees.Add(emp);
            context.SaveChanges();
        }

        public void EmployeeChange()
        {

        }

        public static void Delete(object value)
        {
            Context context = new Context();
            var cpu = context.Employees.Find(value);
            context.Employees.Remove(cpu);
            context.SaveChanges();
        }
    }
}
