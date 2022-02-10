using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public enum RepairStatus
    {
        [Description("inProgress")]
        inProgress,
        [Description("done")]
        done,
        [Description("failed")]
        failed
    }
    public class Repair
    {
        public int DeviceId { get; set; }
        public virtual Device Device { get; set; }
        public RepairStatus Status { get; set; }
        public DateTime BegginingDate { get; set; }
        public DateTime? EndDate { get; set; }
        [MaxLength(300)]
        public String Cause { get; set; }
    }
}
