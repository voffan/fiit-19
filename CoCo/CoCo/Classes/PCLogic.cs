using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    class PCLogic
    {
        public static void Add(int hddid ,int cpuid,int motherboardid,int employeeid)
        {
            Context context = new Context();
            PC pc = new PC
            {
                HddId = hddid,
                CpuId = cpuid,
                MotherboardId = motherboardid,
                EmployeeId = employeeid
            };
            context.PCs.Add(pc);
            context.SaveChanges();

        }
        public static void Delete(object value)
        {
            Context context = new Context();
            var cpu = context.PCs.Find(value);
            context.PCs.Remove(cpu);
            context.SaveChanges();
        }
    }
}
