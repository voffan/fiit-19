using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    public class Error
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
