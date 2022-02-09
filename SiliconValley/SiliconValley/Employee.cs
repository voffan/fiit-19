using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Employee
    {
        public int Id { get; set; }
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }

        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
    }
}
