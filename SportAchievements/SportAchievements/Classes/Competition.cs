using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAchievements.Classes
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBeginning { get; set; } 
        public DateTime DateEnding { get; set; } 
        public KindOfSport Sport { get; set; }
        public CompType Type { get; set; }
    }
}
