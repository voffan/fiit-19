using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMM
{
    public class Comment
    {
        public int Id { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
    }
}
