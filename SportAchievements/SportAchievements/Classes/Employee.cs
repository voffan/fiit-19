using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportAchievements.Classes
{
    public class Employee : Person
    {
        [MaxLength(50)]
        public string Position { get; set; }
        
        public virtual List<Competition> Competitions { get; set; }
    }
}
