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
        }
    }
}
