using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using App.Classes;

namespace App
{
    class Context : DbContext
    {
        public Context() : base("ConnectStr") { }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Person> People { get; set; }
        public DbSet<Human> Humen { get; set; }
        public DbSet<FilmMaker> FilmMakers { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Film> Films { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
