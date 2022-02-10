using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportAchievements.Classes
{
    public class Result
    {
        public int Id { get; set; }
        [Range(1, 3)]
        public int Place { get; set; }
        public int Points { get; set; }
        public KindOfSport Sport { get; set; }
        public int SportsmanId { get; set; }
        public int CompetitionId { get; set; }
        public virtual Sportsman Sportsman { get; set; }
        public virtual Competition Competition { get; set; }
    }
}
