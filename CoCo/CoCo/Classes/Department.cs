using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public String Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
