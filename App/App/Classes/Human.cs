using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class Human : Person
    {
        [MaxLength(100)] public string Address { get; set; }
        [MaxLength(11)] public string Passport { get; set; }
        public DateTime Birthday { get; set; }
    }
}
