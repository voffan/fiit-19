using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity;
using System.Linq;
using CoCo.Classes;
using CoCo;

namespace TestEgor
{
    [TestClass]
    public class UnitTest1
    {
        private static int hddId;
        private static int cpuId;
        private static int motherboardId;
        private static int employeeId;

        private static int id;
        private static Status status;
        private static string invNumber;
        
        
        
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            hddId = 1;
            cpuId = 1;
            motherboardId = 1;
            employeeId = 1;

            id = 1;
            status = Status.working;
            invNumber = DateTime.Today.ToString("yyyyMMdd")
                    + "0" + Convert.ToString(id);
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context context = new Context();
            PC pC = context.PCs.Where(p => p.HddId == hddId && p.CpuId == cpuId && p.MotherboardId == motherboardId && p.EmployeeId == employeeId).FirstOrDefault();
            PCLogic.Delete(pC.Id);
        }

        [TestMethod]
        public void TestAdd()
        {
            Context context = new Context();
            PCLogic.Add(hddId, cpuId, motherboardId, employeeId);
            PC pC = context.PCs.Where(p => p.HddId == hddId && p.CpuId == cpuId && p.MotherboardId == motherboardId && p.EmployeeId == employeeId).FirstOrDefault();
            Assert.IsNotNull(pC);
        }

        [TestMethod]
        public void TestChange()
        {
            Context context = new Context();
            PCLogic.Add(1, 1, 1, 1);

            PC pC = context.PCs.Where(p => p.HddId == 1 && p.CpuId == 1 && p.MotherboardId == 1 && p.EmployeeId == 1 && p.Id == id && p.Status == status && p.InventoryNumber == invNumber).FirstOrDefault();
            PCLogic.PCChange(2, 2, 2, 2, 2, Status.repairing, "2");
            Assert.IsNotNull(pC);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context context = new Context();
            PCLogic.Add(3, 3, 3, 3);
            PC pC = context.PCs.Where(p => p.HddId == 3 && p.CpuId == 3 && p.MotherboardId == 3 && p.EmployeeId == 3).FirstOrDefault();
            PCLogic.Delete(pC.Id);
            pC = context.PCs.Where(p => p.HddId == 3 && p.CpuId == 3 && p.MotherboardId == 3 && p.EmployeeId == 3).FirstOrDefault();
            Assert.IsNull(pC);

        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestException()
        {
            PCLogic.Delete(222222);
        }

    }
}
