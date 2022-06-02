using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CoCo.Classes;
using CoCo;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class RepairTest
    {
        private static string cause;
        private static int dId, hddId, cpuId, mbId, eId, depId;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            cause = "some cause";
            Context c = new Context();

            DepartmentLogic.DepartmentAdd("test dep");
            Department d = c.Departments.Where(dep => dep.Name == "test dep").FirstOrDefault();
            depId = d.Id;

            EmployeeLogic.EmployeeAdd("test empl", d.Id);
            Employee e = c.Employees.Where(dep => dep.FullName == "test empl").FirstOrDefault();
            eId = e.Id;

            HddLogic.Add("test hdd", 10, "test manu");
            Hdd hdd = c.Hdds.Where(dep => dep.Name == "test hdd").FirstOrDefault();
            hddId = hdd.Id;

            CpuLogic.Add("test cpu", 10, "test manu");
            Cpu cpu = c.Cpus.Where(dep => dep.Name == "test cpu").FirstOrDefault();
            cpuId = cpu.Id;

            MotherboardLogic.Add("test mb", "test manu");
            Motherboard mb = c.Motherboards.Where(dep => dep.Name == "test mb").FirstOrDefault();
            mbId = mb.Id;

            PCLogic.Add(hddId, cpuId, mbId, eId);
            PC pc = c.PCs.Where(thing => thing.HddId == hddId).FirstOrDefault();
            dId = pc.Id;
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Repair g = c.Repairs.Where(Repair => Repair.Cause == "mb test 2" && Repair.DeviceId == 20).FirstOrDefault();
            RepairLogic.Delete(g.Id);
            g = c.Repairs.Where(Repair => Repair.Cause == cause).FirstOrDefault();
            RepairLogic.Delete(g.Id);

            PC pc = c.PCs.Find(eId);
            PCLogic.Delete(pc.Id);

            Employee e = c.Employees.Find(eId);
            EmployeeLogic.Delete(e.Id);
            
            Department d = c.Departments.Find(depId);
            DepartmentLogic.Delete(d.Id);

            Hdd hdd = c.Hdds.Find(eId);
            HddLogic.Delete(hdd.Id);

            Cpu cpu = c.Cpus.Find(eId);
            CpuLogic.Delete(cpu.Id);

            Motherboard mb = c.Motherboards.Find(eId);
            MotherboardLogic.Delete(mb.Id);
        }
        [TestMethod]
        public void TestAdd()
        {
            Context c = new Context();
            RepairLogic.Add(dId, cause);
            Repair g = c.Repairs.Where(Repair => Repair.Cause == cause && Repair.DeviceId == dId).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestComplete()
        {
            Context c = new Context();
            RepairLogic.Add(dId, cause);
            Repair g = c.Repairs.Where(Repair => Repair.Cause == cause && Repair.DeviceId == dId).FirstOrDefault();
            RepairLogic.Complete(dId, RepairStatus.done);
            g = c.Repairs.Where(Repair => Repair.Cause == cause && /*Repair.DeviceId == dId && */Repair.Status == RepairStatus.done).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context c = new Context();
            RepairLogic.Add(dId, "mb test 3");
            Repair g = c.Repairs.Where(Repair => Repair.Cause == "mb test 3" && Repair.DeviceId == dId).FirstOrDefault();
            RepairLogic.Delete(g.Id);
            g = c.Repairs.Where(Repair => Repair.Cause == "mb test 3" && Repair.DeviceId == dId).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNull(g);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestException()
        {
            RepairLogic.Delete(222222);
        }
    }
}
