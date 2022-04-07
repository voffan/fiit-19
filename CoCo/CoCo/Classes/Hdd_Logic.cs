using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCo.Classes;

namespace CoCo.Classes
{
    class Hdd_Logic
    {
        public void Add(string name, decimal valume, string manufacturer)
        {
            Hdd hdd = new Hdd();
            Context context = new Context();
            hdd.Name = name;
            hdd.Volume = valume;
            hdd.Manufacturer = manufacturer;
            context.Hdds.Add(hdd);
            context.SaveChanges();
        }
    }
}
