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
        private static int hddId;
        //private static string hddName;
        //private static decimal hddVolume;
        //private static string hddManu;


        private static int cpuId;
        //private static string cpuName;
        //private static decimal cpuFreq;
        //private static string cpuManu;

        private static int mbId;
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

            CpuLogic.Add("test cpu", 10, "test manu");
            Cpu cpu = c.Cpus.Where(dep => dep.Name == "test cpu").FirstOrDefault();
            cpuId = cpu.Id;

            MotherboardLogic.Add("test mb", "test manu");
            Motherboard mb = c.Motherboards.Where(dep => dep.Name == "test mb").FirstOrDefault();
            mbId = mb.Id;

        }


        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            PC g = c.PCs.Where(p => p.HddId == hddId).FirstOrDefault();
            PCLogic.Delete(g.Id);

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
            PCLogic.Add(hddId, cpuId, mbId, eId);
            PC g = c.PCs.Where(p => p.HddId == hddId && p.CpuId == cpuId && p.MotherboardId == mbId && p.EmployeeId == eId).FirstOrDefault();
            PCLogic.Delete(g.Id);
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