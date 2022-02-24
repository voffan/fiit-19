using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM
{
    class Context:DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Journal> Comments{ get; set; }
        public DbSet<Picture> Search { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SMMDB;Trusted_Connection=True;");
        }
    }
}
