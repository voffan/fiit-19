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
        public int points { get; set; }
        public KindOfSport sport { get; set; }
}
}
