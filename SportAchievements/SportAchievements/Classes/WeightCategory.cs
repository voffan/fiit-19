using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAchievements.Classes
{
    public class WeightCategory
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public KindOfSport SportKind { get; set; }
    }
}
