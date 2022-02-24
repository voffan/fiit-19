using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Login { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public Position Position { get; set; }
        public int EmployerId { get; set; }
        public virtual Employer Employer { get; set; }
        public virtual List<Error> Errors { get; set; }
        public virtual List<Solution> Solutions { get; set; }

    }
}
