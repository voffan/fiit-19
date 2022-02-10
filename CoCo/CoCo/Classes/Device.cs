using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    abstract class Device
    {
        private int inventoryNumber { get; set; }
        private Status status { get; set; }
    }
}
