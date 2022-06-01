﻿using System;
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
            using (Context context = new Context())
            {
                context.Repairs.Add(repair);
                context.SaveChanges();
            }
        }

        internal static void Delete(int id)
        {
            using (Context context = new Context())
            {
                var thing = context.Repairs.Find(id);
                context.Repairs.Remove(thing);
                context.SaveChanges();
            }
        }

        internal static void Complete(int id, int did, RepairStatus rs, Status ds)
        {
            using (Context context = new Context())
            {
                Repair thing = context.Repairs.Find(id);
                thing.EndDate = DateTime.Today;
                thing.Status = rs;
                DeviceLogic.ChangeStatus(did, ds);
                context.SaveChanges();
            }
        }
        internal static void CompleteFromDevice(int did, RepairStatus rs)
        {
            using (Context context = new Context())
            {
                Repair thing = (from r in context.Repairs
                                where r.DeviceId == did && r.Status == RepairStatus.inProgress
                                select r).FirstOrDefault();
                thing.EndDate = DateTime.Today;
                thing.Status = rs;
                context.SaveChanges();
            }
        }
    }
}
