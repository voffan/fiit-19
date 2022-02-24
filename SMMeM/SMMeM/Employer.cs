using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    public class Employer
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Login { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(11)]
        public DateTime Birthday { get; set; }
        public Position Position { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
