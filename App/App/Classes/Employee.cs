using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public enum Position
    {
        [Description("Директор")]
        director = 0,
        [Description("Кассир")]
        cashier = 1,
        [Description("Стажер")]
        trainee = 2
    }

    public class Employee : Person
    {
        public Position Position { get; set; }
        [MaxLength(20)]
        public string Login { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
