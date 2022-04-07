using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class CpuLogic
    {
        public static void Add(string name, decimal freq, string manu)
        {
            Context context = new Context();
            Cpu cpu = new Cpu();
            cpu.Name = name;
            cpu.Frequency = freq;
            cpu.Manufacturer = manu;
            context.Cpus.Add(cpu);
            context.SaveChanges();
        }
    }
}
