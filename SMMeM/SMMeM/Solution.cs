using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    public class Solution
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public string Code { get; set; }
        public int ErrorId { get; set; }
        public virtual Error Error { get; set; }
    }
}
