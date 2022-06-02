using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class PCLogic
    {
        
        public static void Add(int hddid ,int cpuid,int motherboardid,int employeeid)
        {
            using (Context context = new Context())
            {
                DateTime ThisDay = DateTime.Today;

                PC pc = new PC
                {
                    HddId = hddid,
                    CpuId = cpuid,
                    MotherboardId = motherboardid,
                    EmployeeId = employeeid,
                };
                context.PCs.Add(pc);
                context.SaveChanges();
                pc.InventoryNumber = InvNumber(pc.Id);
                context.SaveChanges();
            }
        }

        public static PC Get(int pcId)
        {
            using (Context context = new Context())
            {
                PC pc = context.PCs.Find(pcId);
                return pc;
            }
        }

        public static void Delete(int value)
        {
            using (Context context = new Context())
            {
                var pc = context.PCs.Find(value);
                context.PCs.Remove(pc);
                context.SaveChanges();
            }
                
        }

        public static void ChangeStatus(int v, Status status)
        {
            using (Context context = new Context())
            {
                var pc = context.PCs.Find(v);
                pc.Status = status;
                context.SaveChanges();
            }
        }

        public static void PCChange(int hdd, int cpu, int motherboard, int empl,int value, Status status, string invn)
        {
            using(Context context = new Context())
            {
                var pc = context.PCs.Find(value);
                pc.Hdd = context.Hdds.Find(hdd);
                pc.Cpu = context.Cpus.Find(cpu);
                pc.Motherboard = context.Motherboards.Find(motherboard);
                pc.Employee = context.Employees.Find(empl);
                pc.Status = status;
                pc.InventoryNumber = invn;
                context.SaveChanges();
            }
        }
        public static string InvNumber(int id)
        {
            string invNumber = DateTime.Today.ToString("yyyyMMdd")
                    + "0" + Convert.ToString(id);
            return invNumber;
        }
    }
}
