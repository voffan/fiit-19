using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAchievements.Classes
{
    public class Sportsman : Person
    {
        /*public enum Gender : int 
        { 
            [StringValue("Мужской")]
            Man = 1,
            [StringValue("Женский")]
            Woman = 2
        } //enum*/

        public WeightCategory Weight { get; set; }
    }
}
