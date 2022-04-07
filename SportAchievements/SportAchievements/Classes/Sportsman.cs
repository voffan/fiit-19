using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SportAchievements.Classes
{
    public enum Gender
    {
        [Description("Мужской")]
        Man,
        [Description("Женский")]
        Woman
    }

    public class Sportsman : Person
    {
        public Gender Gender { get; set; }
        public int? WeightCategoryId { get; set; }
        public virtual WeightCategory Weight { get; set; }
    }
}
