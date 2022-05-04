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
            using (Context context = new Context())
            {
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
        }
        public static void Delete(object value)
        {
            using (Context context = new Context())
            {
                var pc = context.PCs.Find(value);
                context.PCs.Remove(pc);
                context.SaveChanges();
            }
                
        }

        internal static void ChangeStatus(int v, Status status)
        {
            using (Context context = new Context())
            {
                var pc = context.PCs.Find(v);
                pc.Status = status;
                context.SaveChanges();
            }
        }
    }
}
