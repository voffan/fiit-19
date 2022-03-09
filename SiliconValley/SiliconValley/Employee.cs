using SiliconValley.Список_Жанров;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    public class Employee:IId
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Login { get; set; }
        [MaxLength(255)]
        public string Password { get; set; }
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public Position Position { get; set; }
        public Education Education { get; set; }
    }
}
