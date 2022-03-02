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
        [MaxLength(200)]
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
