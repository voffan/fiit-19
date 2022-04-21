using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    internal class RepairLogic
    {
        public static void Add(int id, string cause)
        {
            Repair repair = new Repair
            {
                Status = 0,
                DeviceId = id,
                Cause = cause,
                BegginingDate = DateTime.Today
            };
            Context context = new Context();
            context.Repairs.Add(repair);
            context.SaveChanges();
        }
    }
}
