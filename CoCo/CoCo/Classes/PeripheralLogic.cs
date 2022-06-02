using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class PeripheralLogic
    {
        public static void Add(string name, string manu, int employeeid)
        {
            using (var context = new Context())
            {
                Peripheral pc = new Peripheral
                {
                    Name = name,
                    Manufacturer = manu,
                    EmployeeId = employeeid
                };
                context.Peripherals.Add(pc);
                context.SaveChanges();
                pc.InventoryNumber = DateTime.Today.ToString("yyyyMMdd")
                        + "1" + Convert.ToString(pc.Id);
                context.SaveChanges();
            }
        }
        public static void Delete(int value)
        {
            using (var context = new Context())
            {
                var cpu = context.Peripherals.Find(value);
                context.Peripherals.Remove(cpu);
                context.SaveChanges();
            }
        }

        public static void Change(string name, string manu, int empl, int value, Status status, string invn)
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
                per.Status = status;
                per.InventoryNumber = invn;
                context.SaveChanges();
            }

        }

        public static string InvNumber(int perId)
        {
            string invNumber = DateTime.Today.ToString("yyyyMMdd")
                    + "1" + Convert.ToString(perId);
            return invNumber;
        }

        public static void ChangeStatus(int value, Status status)
        {
            using (Context context = new Context())
            {
                var pc = context.Peripherals.Find(value);
                pc.Status = status;
                context.SaveChanges();
            }
        }
        public static Peripheral Get(int pcId)
        {
            using (Context context = new Context())
            {
                Peripheral pc = context.Peripherals.Find(pcId);
                return pc;
            }
        }
    }
}
