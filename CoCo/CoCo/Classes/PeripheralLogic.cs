using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class PeripheralLogic
    {
        public static void Add(string name, string manu, int employeeid)
        {
            Context context = new Context();
            Peripheral pc = new Peripheral();
            pc.Name = name;
            pc.Manufacturer = manu;
            pc.EmployeeId = employeeid;
            context.Peripherals.Add(pc);
            context.SaveChanges();

        }
        public static void Delete(object value)
        {
            Context context = new Context();
            var cpu = context.Peripherals.Find(value);
            context.Peripherals.Remove(cpu);
            context.SaveChanges();
        }
    }
}
