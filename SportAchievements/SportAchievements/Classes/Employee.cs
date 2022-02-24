using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SportAchievements.Classes
{
    public enum Position
    {
        [Description("Судья")]
        Judge,
        [Description("Сотрудник")]
        Manager,
        [Description("Администратор")]
        Admin
    }

    public class Employee : Person
    {
        [MaxLength(50)]
        public string Login { get; set; }
        [MaxLength(50)]
        public string Pwd { get; set; }
        public Position Position { get; set; }
        
        public virtual List<Competition> Competitions { get; set; }
    }
}
