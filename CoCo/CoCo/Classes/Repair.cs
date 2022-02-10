using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class Repair
    {
        private Device device { get; set; }
        private RepairStatus status { get; set; }
        private DateTime begginingDate { get; set; }
        private DateTime endDate { get; set; }
        private String cause { get; set; }
    }
}
