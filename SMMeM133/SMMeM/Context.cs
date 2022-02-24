using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace SMM
{
    public class Context: DbContext
    {
        public Context() : base("MyString") { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<ErrorComment> ErrorComments { get; set; }
        public DbSet<SolutionComment> SolutionComments{ get; set; }

         //public DbSet<Picture> Search { get; set; }

        
    }
}
