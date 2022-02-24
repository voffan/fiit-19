using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMM
{
    public class ErrorComment
    {
        public int Id { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
        public int ErrorId { get; set; }
        public virtual Error Error { get; set; }
    }
}
