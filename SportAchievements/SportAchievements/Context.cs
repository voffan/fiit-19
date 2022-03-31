using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using SportAchievements.Classes;

namespace SportAchievements
{
    public class Context : DbContext
    {
        public Context() : base("MyString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Competition> Competitions { get; set; }
        public DbSet<CompType> CompTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Persons{ get; set; }
        public DbSet<KindOfSport> KindsOfSports{ get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Sportsman> Sportsmen { get; set; }
        public DbSet<WeightCategory> WeightCategories { get; set; }
    }
}
