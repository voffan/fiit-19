using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoCo.Classes
{
    public class Peripheral:Device
    {
        [MaxLength(300)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Manufacturer { get; set; }
    }
}
