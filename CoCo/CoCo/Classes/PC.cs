using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class PC : Device
    {
        public int HddId { get; set; }
        public virtual Hdd Hdd { get; set; }
        public int CpuId { get; set; }
        public virtual Cpu Cpu { get; set; }
        public int MotherboardId { get; set; }
        public virtual Motherboard Motherboard { get; set; }
    }
}
