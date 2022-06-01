using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCo.Classes;


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
            context.Dispose();
        }

        internal static void Delete(int id)
        {
            Context context = new Context();
            var thing = context.Repairs.Find(id);
            context.Repairs.Remove(thing);
            context.SaveChanges();
            context.Dispose();
        }

        internal static void Complete(int id, int did, RepairStatus rs, Status ds)
        {
            Context context = new Context();
            Repair thing = context.Repairs.Find(id);
            thing.EndDate = DateTime.Today;
            thing.Status = rs;
            DeviceLogic.ChangeStatus(did, ds);
            context.SaveChanges();
            context.Dispose();
        }
    }
}
