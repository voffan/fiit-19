using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Expo : Placement
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
