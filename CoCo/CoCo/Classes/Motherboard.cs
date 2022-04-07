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
        public override string ToString()
        {
            return Name;
        }
    }

}
