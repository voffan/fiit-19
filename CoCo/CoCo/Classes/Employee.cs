using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoCo.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public String FullName { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public override string ToString()
        {
            return FullName;
        }
    }
    
}
