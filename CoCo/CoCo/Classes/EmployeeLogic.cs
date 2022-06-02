using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCo.Forms;
using System.Windows.Forms;

namespace CoCo.Classes
{
    public class EmployeeLogic
    {
        public static void EmployeeAdd(string Name, int Id)
        {
            using (Context context = new Context())
            {
                Employee emp = new Employee
                {
                    FullName = Name,
                    DepartmentId = Id
                };
                context.Employees.Add(emp);
                context.SaveChanges();
            }
        }

        public static void EmployeeChange(string Name, int Id, int emplId)
        {

            using (Context context = new Context())
            {
                Employee employee = context.Employees.FirstOrDefault(x => x.Id == emplId);
                employee.FullName = Name;
                employee.DepartmentId = Id;
                context.SaveChanges();
            }
        }

        public static void Delete(int value)
        {
            using (Context context = new Context())
            {
                var cpu = context.Employees.Find(value);
                context.Employees.Remove(cpu);
                context.SaveChanges();
            }
        }
    }
}
