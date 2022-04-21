using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class PeripheralLogic
    {
        public static void Delete(object value)
        {
            Context context = new Context();
            var cpu = context.Peripherals.Find(value);
            context.Peripherals.Remove(cpu);
            context.SaveChanges();
        }
    }
}
