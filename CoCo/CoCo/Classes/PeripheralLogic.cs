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
            Peripheral pc = new Peripheral
            {
                Name = name,
                Manufacturer = manu,
                EmployeeId = employeeid
            };
            context.Peripherals.Add(pc);
            context.SaveChanges();

        }
        public static void Delete(object value)
        {
            Context context = new Context();
            var cpu = context.Peripherals.Find((int)value);
            context.Peripherals.Remove(cpu);
            context.SaveChanges();
        }

        public static void PeripheralChange(string name, string manu, int empl, int value)
        {
            using (var context = new Context())
            {
                //Peripheral per = (from Peripheral per1 in context.Peripherals where per1.Id == perId select per1).FirstOrDefault();    
                //Peripheral per = (Peripheral)context.Device.FirstOrDefault(x => x.Id == perId);
                var per = context.Peripherals.Find(value);

                //Peripheral per = context.Peripherals.FirstOrDefault(x => x.Id == perId);
                per.Name = name;
                per.Manufacturer = manu;
                per.Employee = context.Employees.Find(empl);


                context.SaveChanges();
            }

        }
    }
}
