using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Journal
    {
        
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PictureId { get; set; }
        public Picture Picture { get; set; }

        
        public int FromID { get; set; }
        [ForeignKey("FromID")]
        public Placement From { get; set; }

        public int ToID { get; set; }
        [ForeignKey("ToID")]
        public Placement To { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
