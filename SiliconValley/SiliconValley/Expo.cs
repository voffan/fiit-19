using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    public class Expo : Placement,IId
    {
        [MaxLength(100)]
        public string Address { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
