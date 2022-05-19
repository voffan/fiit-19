using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class MotherboardLogic
    {
        public static void Add(string name, string manufacturer)
        {
            Context context = new Context();
            Motherboard motherboard = new Motherboard();
            motherboard.Name = name;
            motherboard.Manufacturer = manufacturer;
            context.Motherboards.Add(motherboard);
            context.SaveChanges();
        }
        public static void Delete(object value)
        {
            Context context = new Context();
            var cpu = context.Motherboards.Find(value);
            context.Motherboards.Remove(cpu);
            context.SaveChanges();
        }

        public static void Change(string name, string manufacturer, object MBId)
        {
            using (var context = new Context())
            {
                Motherboard MB = context.Motherboards.FirstOrDefault(x => x.Id == (int)MBId);
                MB.Name = name;
                MB.Manufacturer = manufacturer;
                context.SaveChanges();
            }
        }
    }
}
