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
        [Description("в процессе")]
        inProgress,
        [Description("завершено")]
        done,
        [Description("потрачено")]
        failed
    }
    public class Repair
    {
        [Key]
        public int DeviceId { get; set; }
        public virtual Device Device { get; set; }
        public RepairStatus Status { get; set; }
        public DateTime BegginingDate { get; set; }
        public DateTime? EndDate { get; set; }
        [MaxLength(300)]
        public String Cause { get; set; }
    }
}
