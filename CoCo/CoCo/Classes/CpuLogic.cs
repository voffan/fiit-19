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
        public static void Delete(int value)
        {
            Context context = new Context();
            var cpu = context.Hdds.Find(value);
            context.Hdds.Remove(cpu);
            context.SaveChanges();
        }

        public static void CpuChange(string name, decimal freq, string manufacturer, int cpuId)
        {
            using (var context = new Context())
            {
                Cpu cpu = context.Cpus.FirstOrDefault(x => x.Id == (int)cpuId);
                cpu.Name = name;
                cpu.Frequency = freq;
                cpu.Manufacturer = manufacturer;
                context.SaveChanges();
            }
        }
    }
}
