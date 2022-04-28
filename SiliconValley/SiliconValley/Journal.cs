using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    public class Journal:IId
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PictureId { get; set; }
        public virtual Picture Picture { get; set; }
        public int FromID { get; set; }
        [ForeignKey("FromID")]
        public virtual Placement From { get; set; }
        public int ToID { get; set; }
        [ForeignKey("ToID")]
        public virtual Placement To { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
