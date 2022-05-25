using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class HddLogic
    {
        public static void Add(string name, decimal volume, string manufacturer)
        {
            Context context = new Context();
            Hdd hdd = new Hdd();
            hdd.Name = name;
            hdd.Volume = volume;
            hdd.Manufacturer = manufacturer;
            context.Hdds.Add(hdd);
            context.SaveChanges();
            context.Dispose();
        }
        public static void Delete(int value)
        {
            Context context = new Context();
            var hdd = context.Hdds.Find(value);
            context.Hdds.Remove(hdd);
            context.SaveChanges();
            context.Dispose();
        }
        public static void HddChange(string name, decimal volume, string manufacturer, int hddId)
        {
            using (var context = new Context())
            {
                Hdd hdd = context.Hdds.FirstOrDefault(x => x.Id == hddId);
                hdd.Name = name;
                hdd.Volume = volume;
                hdd.Manufacturer = manufacturer;
                context.SaveChanges();
            }
        }
    }
}
