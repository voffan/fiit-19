using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class Client
    {
        public int Id { get; set; }
        [MaxLength(50)] public string Name { get; set; }
        [MaxLength(100)] public string Address { get; set; }
        public string Passport { get; set; }
        public DateTime Birth { get; set; }
        public bool BlackList { get; set; }
    }
}
