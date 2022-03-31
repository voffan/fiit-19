using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class Motherboard
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public String Name { get; set; }
        [MaxLength(300)]
        public String Manufacturer { get; set; }
        public void Add(string name,  string manu)
        {
            Context context = new Context();
            Name = name;
            Manufacturer = manu;
            context.Motherboards.Add(this);
            context.SaveChanges();
        }

    }
}
