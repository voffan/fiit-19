using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    public class Solution: Comment
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(255)]
        public int ErrorId { get; set; }
        public virtual Error Error { get; set; }
        public int CommentId { get; set; }
        public virtual Comment Comments { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
