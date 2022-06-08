using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Logic
{
    public class DepartmentLogic
    {
        public static void Add(string name)
        {
            Department dep = new Department();
            dep.Name = name;
            ListsComponent.Add(dep);
        }
        public static void Edit(int id, string name)
        {
            Department dep = ListsComponent.GetObjById<Department>(id);
            dep.Name = name;
            ListsComponent.Edit(dep);
        }
        public static void Delete(int id)
        {
            Department dep = ListsComponent.GetObjById<Department>(id);
            ListsComponent.Delete(dep);
        }
    }
}
