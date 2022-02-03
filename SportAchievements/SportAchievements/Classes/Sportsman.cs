using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAchievements.Classes
{
    public class Sportsman
    {
        public int Id { get; set; }
        [MaxLength(1)] //???
        public char Gender { get; set; }
        public WeightCategory Weight { get; set; }
    }
}
