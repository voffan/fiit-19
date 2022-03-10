using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using CoCo.Classes;

namespace CoCo
{
    public class Context : DbContext
    {
        public Context() : base("MyString") { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<PC> PCs { get; set; }
        public DbSet<Peripheral> Peripherals { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Hdd> Hdds { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
    }
}
