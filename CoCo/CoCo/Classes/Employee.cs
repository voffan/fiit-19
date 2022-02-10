using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoCo.Classes
{
    internal class Employee
    {
        private string fullName { get; set; }
        [ForeignKey("department")]
        public Department department { get; set; }
    }
}
