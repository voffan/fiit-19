using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using CoCo.Classes;

namespace CoCo
{
    internal class Context
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<PC> PCs { get; set; }
        public DbSet<Peripheral> Peripherals { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<RepairStatus> RepairStatuses { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Hdd> Hdds { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
    }
}
