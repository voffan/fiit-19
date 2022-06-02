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
        private static string hddName;
        private static decimal hddVolume;
        private static string hddManu;


        private static int cpuId;
        private static string cpuName;
        private static decimal cpuFreq;
        private static string cpuManu;

        private static int motherboardId;
        private static string motherboardName;
        private static string motherboardManu;

        private static int employeeId;
        private static string employeeName;
        private static int employeeDepartmentId;



        private static int id;
        private static Status status;
        private static string invNumber;



        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            hddId = 1;
            hddName = "test";
            hddVolume = 500;
            hddManu = "test";

            cpuId = 1;
            cpuName = "test";
            cpuFreq = 3;
            
            motherboardId = 1;
            motherboardName = "test";
            motherboardManu = "test";

            employeeId = 1;
            employeeDepartmentId = 1;
            employeeName = "test";

            id = 1;
            status = Status.working;
            invNumber = DateTime.Today.ToString("yyyyMMdd")
                    + "0" + Convert.ToString(id); 
        }


        [ClassCleanup]
        public static void ClassClean()
        {
            Context context = new Context();
            PC g = context.PCs.Where(p => p.HddId == hddId && p.Hdd.Name == hddName && p.Hdd.Volume == hddVolume && p.Hdd.Manufacturer == hddManu &&
                                     p.CpuId == cpuId && p.Cpu.Name == cpuName && p.Cpu.Frequency == cpuFreq && p.Cpu.Manufacturer == cpuManu &&
                                     p.MotherboardId == motherboardId && p.Motherboard.Name == motherboardName && p.Motherboard.Manufacturer == motherboardManu &&
                                     p.EmployeeId == employeeId && p.Employee.FullName == employeeName && p.Employee.DepartmentId == employeeDepartmentId).FirstOrDefault();
            PCLogic.Delete(g.Id);
        }


        [TestMethod]
        public void TestAdd()
        {
            Context context = new Context();
            PCLogic.Add(hddId, cpuId, motherboardId, employeeId);
            PC g = context.PCs.Where(p => p.HddId == hddId && p.Hdd.Name == hddName && p.Hdd.Volume == hddVolume && p.Hdd.Manufacturer == hddManu &&
                                     p.CpuId == cpuId && p.Cpu.Name == cpuName && p.Cpu.Frequency == cpuFreq && p.Cpu.Manufacturer == cpuManu &&
                                     p.MotherboardId == motherboardId && p.Motherboard.Name == motherboardName && p.Motherboard.Manufacturer == motherboardManu &&
                                     p.EmployeeId == employeeId && p.Employee.FullName == employeeName && p.Employee.DepartmentId == employeeDepartmentId).FirstOrDefault();
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestChange()
        {
            Context context = new Context();
            PCLogic.Add(1, 1, 1, 1);

            PC g = context.PCs.Where(p => p.HddId == 1 && p.CpuId == 1 && p.MotherboardId == 1 && p.EmployeeId == 1 && p.Id == id && p.Status == status && p.InventoryNumber == invNumber).FirstOrDefault();
            PCLogic.PCChange(2, 2, 2, 2, 2, Status.repairing, "2");
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context context = new Context();
            PCLogic.Add(3, 3, 3, 3);
            PC g = context.PCs.Where(p => p.HddId == 3 && p.CpuId == 3 && p.MotherboardId == 3 && p.EmployeeId == 3).FirstOrDefault();
            PCLogic.Delete(g.Id);
            g = context.PCs.Where(p => p.HddId == 3 && p.CpuId == 3 && p.MotherboardId == 3 && p.EmployeeId == 3).FirstOrDefault();
            Assert.IsNull(g);

        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestException()
        {
            PCLogic.Delete(222222);
        }

    }
}