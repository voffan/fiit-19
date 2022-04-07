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

        public void DepartmentChange()
        {

        }

        public void DepartmentDelete()
        {

        }
    }
}
