using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAchievements.Classes
{
    public class KindOfSport
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
