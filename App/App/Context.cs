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

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Disk> Disk { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Producer> Producer { get; set; }
    }
}
