using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity;
using System.Linq;
using CoCo.Classes;
using CoCo;

namespace UnitTestProject1
{
    [TestClass]
    public class PcTest
    {
        private static int hddId, hddId2;
        //private static string hddName;
        //private static decimal hddVolume;
        //private static string hddManu;


        private static int cpuId;
        //private static string cpuName;
        //private static decimal cpuFreq;
        //private static string cpuManu;

        private static int mbId, mbId2;
        //private static string motherboardName;
        //private static string motherboardManu;

        private static int eId;
        //private static string employeeName;
        //private static int employeeDepartmentId;

        private static int depId;
       

        private static int id;
        private static Status status;
        private static string invNumber;



        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {

            status = Status.working;
            invNumber = DateTime.Today.ToString("yyyyMMdd")
                    + "0" + Convert.ToString(id); 

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

            HddLogic.Add("test hdd2", 10, "test manu");
            Hdd hdd2 = c.Hdds.Where(dep => dep.Name == "test hdd2").FirstOrDefault();
            hddId2 = hdd2.Id;

            CpuLogic.Add("test cpu", 10, "test manu");
            Cpu cpu = c.Cpus.Where(dep => dep.Name == "test cpu").FirstOrDefault();
            cpuId = cpu.Id;

            MotherboardLogic.Add("test mb", "test manu");
            Motherboard mb = c.Motherboards.Where(dep => dep.Name == "test mb").FirstOrDefault();
            mbId = mb.Id;
            MotherboardLogic.Add("test mb2", "test manu");
            Motherboard mb2 = c.Motherboards.Where(dep => dep.Name == "test mb").FirstOrDefault();
            mbId2 = mb2.Id;

        }


        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            PC g = c.PCs.Where(p => p.HddId == hddId).FirstOrDefault();
            PCLogic.Delete(g.Id);

            g = c.PCs.Where(p => p.HddId == hddId).FirstOrDefault();
            PCLogic.Delete(g.Id);

            Employee e = c.Employees.Find(eId);
            EmployeeLogic.Delete(e.Id);

            Department d = c.Departments.Find(depId);
            DepartmentLogic.Delete(d.Id);

            Hdd hdd = c.Hdds.Find(hddId);
            HddLogic.Delete(hdd.Id);

            Hdd hdd2 = c.Hdds.Find(hddId2);
            HddLogic.Delete(hdd2.Id);

            Cpu cpu = c.Cpus.Find(cpuId);
            CpuLogic.Delete(cpu.Id);

            Motherboard mb = c.Motherboards.Find(mbId);
            MotherboardLogic.Delete(mb.Id);

            Motherboard mb2 = c.Motherboards.Find(mbId2);
            MotherboardLogic.Delete(mb2.Id);
        }


        [TestMethod]
        public void TestAdd()
        {
            Context context = new Context();
            PCLogic.Add(hddId, cpuId, mbId, eId);
            PC g = context.PCs.Where(p => p.HddId == hddId && p.CpuId == cpuId && p.MotherboardId == mbId && p.EmployeeId == eId).FirstOrDefault();
            Assert.IsNotNull(g);

        }

        [TestMethod]
        public void TestChange()
        {
            Context context = new Context();
            PCLogic.Add(hddId, cpuId, mbId, eId);

            PC g = context.PCs.Where(p => p.HddId == hddId && p.CpuId == cpuId && p.MotherboardId == mbId && p.EmployeeId == eId).FirstOrDefault();
            PCLogic.PCChange(hddId, cpuId, mbId, eId, g.Id, Status.repairing, "2");
            g = context.PCs.Where(p => p.HddId == hddId && p.CpuId == cpuId && p.MotherboardId == mbId && p.EmployeeId == eId && p.Status == Status.repairing && p.InventoryNumber == "2").FirstOrDefault();

            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context c = new Context();
            PCLogic.Add(hddId2, cpuId, mbId2, eId);
            PC g = c.PCs.Where(p => p.HddId == hddId2 && p.CpuId == cpuId && p.MotherboardId == mbId2 && p.EmployeeId == eId).FirstOrDefault();
            PCLogic.Delete(g.Id);
            g = c.PCs.Where(p => p.HddId == hddId2 && p.CpuId == cpuId && p.MotherboardId == mbId2 && p.EmployeeId == eId).FirstOrDefault();
            Assert.IsNull(g);

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestException()
        {
            PCLogic.Delete(222222);
        }

    }
}