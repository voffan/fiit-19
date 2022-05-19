using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    class PCLogic
    {
        public static int today = 0;
        public DateTime LastDay;
        public DateTime ThisDay = DateTime.Today;
        public static void Add(int hddid ,int cpuid,int motherboardid,int employeeid)
        {
            using (Context context = new Context())
            {
                whattoday();
                string inventorynumber = Convert.ToString(ThisDay.Year) + Convert.ToString(ThisDay.Month) + Convert.ToString(ThisDay.Day)
                    + "0" + ;
           
                PC pc = new PC
                {
                    HddId = hddid,
                    CpuId = cpuid,
                    MotherboardId = motherboardid,
                    EmployeeId = employeeid,
                    InventoryNumber = inventorynumber
                };
                context.PCs.Add(pc);
                context.SaveChanges();
            }
        }

        private static void whattoday()
        {
            lastday = 
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

        //static void Search()
        //{
        //    Context context = new Context();
        //    dataGridView1.DataSource = context.PCs.Where(h =>
        //   h.Hdd.Name.Contains(textBox1.Text) &&
        //   h.Cpu.Name.Contains(textBox2.Text) &&
        //   h.Motherboard.Name.Contains(textBox3.Text) &&
        //   h.Employee.FullName.Contains(textBox4.Text)
        //   ).ToList();
        //}
    }
}
