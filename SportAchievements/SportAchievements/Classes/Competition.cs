using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportAchievements.Classes
{
    public class Competition
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime DateBeginning { get; set; } 
        public DateTime DateEnding { get; set; } 
        public KindOfSport Sport { get; set; }
        public CompType Type { get; set; }
        public virtual List<Employee> Employee { get; set; }
    }
}
