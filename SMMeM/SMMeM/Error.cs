using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    public class Error
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Code { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Solution> Solutions { get; set; }
    }
}
