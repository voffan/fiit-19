using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class PC : Device
    {
        private Hdd hdd { get; set; }
        private Cpu cpu { get; set; }
        private Motherboard motherboard { get; set; }
        [ForeignKey("employee")]
        public Employee employee { get; set; }
    }
}
