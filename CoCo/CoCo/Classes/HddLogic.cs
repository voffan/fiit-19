using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class HddLogic
    {
        public static void Add(string name, decimal volume, string manufacturer)
        {
            using (var context = new Context())
            {
                Hdd hdd = new Hdd();
                hdd.Name = name;
                hdd.Volume = volume;
                hdd.Manufacturer = manufacturer;
                context.Hdds.Add(hdd);
                context.SaveChanges();
            }
        }
        public static void Delete(int value)
        {
            using (var context = new Context())
            {
                var hdd = context.Hdds.Find(value);
                context.Hdds.Remove(hdd);
                context.SaveChanges();
            }
        }
        public static void Change(string name, decimal volume, string manufacturer, int hddId)
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
