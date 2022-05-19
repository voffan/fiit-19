using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public virtual Device Device { get; set; }
        public RepairStatus Status { get; set; }
        public DateTime BegginingDate { get; set; }
        public DateTime? EndDate { get; set; }
        [MaxLength(300)]
        public string Cause { get; set; }
    }
}
