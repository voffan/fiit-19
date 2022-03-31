using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    static internal class HDDLogic
    {
        public static void Add(string name, decimal volume, string manu)
        {
            Hdd h = new Hdd();
            Context context = new Context();
            h.Name = name;
            h.Volume = volume;
            h.Manufacturer = manu;
            context.Hdds.Add(h);
            context.SaveChanges();
        }
        /*
        public static List<object> GetHdds()
        {
            using (var context = new Context())
            {
                var hddlist = (from h in context.Hdds select new { Id = h.Id, Name = h.Name + " " + h.Volume + "ГБ " + h.Manufacturer }).ToList();
                return hddlist;
            }
          
        }*/
    }
}
