using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Db
{
    class Context:DbContext
    {
        public Context() : base() { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expo> Expos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Placement> Placements { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
