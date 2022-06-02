using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class CpuLogic
    {
        public static void Add(string name, decimal freq, string manu)
        {
            using (Context context = new Context())
            {
                Cpu cpu = new Cpu();
                cpu.Name = name;
                cpu.Frequency = freq;
                cpu.Manufacturer = manu;
                context.Cpus.Add(cpu);
                context.SaveChanges();
            }
        }
        public static void Delete(int value)
        {
            using (Context context = new Context())
            {
                Cpu cpu = context.Cpus.Find(value);
                context.Cpus.Remove(cpu);
                context.SaveChanges();
            }
        }

        public static void Change(string name, decimal freq, string manufacturer, int cpuId)
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
