using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    class Comment
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Text { get; set; }
        [MaxLength(500)]
    }
}
