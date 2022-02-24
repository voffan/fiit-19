using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    public class Error: Comment
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(255)]
        public int SolutionID { get; set; }
        public int CommentId { get; set; }
        public virtual Comment Comments { get; set; }
        public virtual List<Solution> Solutions { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
