using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity;
using System.Linq;
using CoCo.Classes;
using CoCo;

namespace UnitTestProject1
{
    [TestClass]
    public class PerTest
    {
        private static string name;
        private static string manu;
        private static int emplId;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            name = "test1";
            manu = "test1";
            emplId = 1;
        }


        [ClassCleanup]
        public static void ClassClean()
        {
            Context context = new Context();
            Peripheral g = context.Peripherals.Where(per => per.Name == name && per.Manufacturer == manu && per.EmployeeId == emplId).FirstOrDefault();
            PeripheralLogic.Delete(g.Id);
            g = context.Peripherals.Where(per => per.Name == name && per.Manufacturer == manu && per.EmployeeId == emplId).FirstOrDefault();
            PeripheralLogic.Delete(g.Id);
        }


        [TestMethod]
        public void TestAdd()
        {
            Context context = new Context();
            PeripheralLogic.Add(name, manu, emplId);
            Peripheral g = context.Peripherals.Where(per => per.Name == name && per.Manufacturer == manu && per.EmployeeId == emplId).FirstOrDefault();
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestChange()
        {
            //Context context = new Context();
            //PeripheralLogic.Add("test2", "test2", 2);
            //Peripheral g = context.Peripherals.Where(per => per.Name == "test2" && per.Manufacturer == "test2" && per.EmployeeId == 2).FirstOrDefault();
            //PeripheralLogic.Change(per => per.Name == "test3" && per.Manufacturer == "test3" && per.EmployeeId == 3);
            //g = context.Peripherals.Where(per => per.Name == "test2" && per.Manufacturer == "test2" && per.EmployeeId == 2).FirstOrDefault();
            //Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context context = new Context();
            PeripheralLogic.Add("test3", "test3", 3);
            Peripheral g = context.Peripherals.Where(per => per.Name == "test3" && per.Manufacturer == "test3" && per.EmployeeId == 3).FirstOrDefault();
            PeripheralLogic.Delete(g.Id);
            g = context.Peripherals.Where(per => per.Name == "test3" && per.Manufacturer == "test3" && per.EmployeeId == 3).FirstOrDefault();
            Assert.IsNull(g);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestException()
        {
            PeripheralLogic.Delete(222222);
        }

    }
}
