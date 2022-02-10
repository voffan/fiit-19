using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class Hdd
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public String Name { get; set; }
        [Range(0, 5000)]
        public decimal Volume { get; set; }
        [MaxLength(300)]
        public String Manufacturer { get; set; }
    }
}
