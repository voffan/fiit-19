using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoCo.Classes
{
    public class Admin : Employee
    {
        [MaxLength(300)]
        public String Login { get; set; }
        [MaxLength(300)]
        public String Password { get; set; }
    }
}
