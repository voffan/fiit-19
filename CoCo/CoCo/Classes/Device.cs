using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public enum Status
    {
        [Description("working")]
        working,
        [Description("repairing")]
        repairing,
        [Description("broken")]
        broken
    }
    public class Device
    {
        public int Id { get; set; }
        public int InventoryNumber { get; set; }
        public Status Status { get; set; }

    }
}
