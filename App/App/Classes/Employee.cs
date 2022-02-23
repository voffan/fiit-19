using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public enum Position_
    {
        [Description("Директор")]
        director = 0,
        [Description("Кассир")]
        cashier = 1,
        [Description("Стажер")]
        trainee = 2
    }

    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(50)] public string Name { get; set; }
        [MaxLength(100)] public string Address { get; set; }
        public string Passport { get; set; }
        public DateTime Birth { get; set; }
        public Position_ Position { get; set; }
    }
}
