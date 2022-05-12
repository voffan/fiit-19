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
        public KindOfSport()
        {
            Competitions = new List<Competition>();
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual List<Competition> Competitions { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
