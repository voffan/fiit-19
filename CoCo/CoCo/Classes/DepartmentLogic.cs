using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class DepartmentLogic
    {
        public static void DepartmentAdd(string name) 
        {
            using (Context context = new Context())
            {
                Department dep = new Department
                {
                    Name = name
                };
                context.Departments.Add(dep);
                context.SaveChanges();
            }
        }

        public static void DepartmentChange(string name, int depId)
        {
            using (Context context = new Context())
            {
                Department department = context.Departments.FirstOrDefault(x => x.Id == (int)depId);
                department.Name = name;
                context.SaveChanges();
            }

        }

        public static void Delete(int value)
        {
            using (Context context = new Context())
            {
                var dep = context.Departments.Find(value);
                context.Departments.Remove(dep);
                context.SaveChanges();
            }
        }
    }
}
