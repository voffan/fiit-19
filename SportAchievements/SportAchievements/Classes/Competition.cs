using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SportAchievements.Classes
{
    public enum CompetionStatus
    {
        [Description("Закончилось")]
        Ended = 0,
        [Description("Началось")]
        Started = 1,
        [Description("Приостановлено")]
        Paused = 2
    }

    public class Competition
    {
        public Competition()
        {
            KindOfSports = new List<KindOfSport>();
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime DateBeginning { get; set; }
        public DateTime DateEnding { get; set; }
        public int CompTypeId { get; set; }
        public virtual CompType Type { get; set; }
        public virtual List<Employee> Employee { get; set; }
        public virtual List<KindOfSport> KindOfSports { get; set; }
    }
}
