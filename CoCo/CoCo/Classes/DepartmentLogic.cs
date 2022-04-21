using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class DepartmentLogic
    {
        public void DepartmentAdd(string name) 
        {
            Context context = new Context();
            Department dep = new Department();
            dep.Name = name;
            context.Departments.Add(dep);
            context.SaveChanges();
        }

        public static void DepartmentChange(string name, object depId)
        {
            using (var context = new Context())
            {
                Department department = context.Departments.FirstOrDefault(x => x.Id == (int)depId);
                department.Name = name;
                context.SaveChanges();
            }

        }

        public static void Delete(object value)
        {
            Context context = new Context();
            var dep = context.Departments.Find(value);
            context.Departments.Remove(dep);
            context.SaveChanges();
        }
    }
}
