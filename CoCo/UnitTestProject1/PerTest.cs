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
        private static int eId, depId;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            name = "test1";
            manu = "test1";
            Context c = new Context();

            DepartmentLogic.DepartmentAdd("test dep");
            Department d = c.Departments.Where(dep => dep.Name == "test dep").FirstOrDefault();
            depId = d.Id;

            EmployeeLogic.EmployeeAdd("test empl", d.Id);
            Employee e = c.Employees.Where(dep => dep.FullName == "test empl").FirstOrDefault();
            eId = e.Id;
        }


        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Peripheral g = c.Peripherals.Where(per => per.Name == name && per.Manufacturer == manu && per.EmployeeId == eId).FirstOrDefault();
            PeripheralLogic.Delete(g.Id);
            g = c.Peripherals.Where(per => per.Name == name && per.Manufacturer == manu && per.EmployeeId == eId).FirstOrDefault();
            PeripheralLogic.Delete(g.Id);
            g = c.Peripherals.Where(per => per.Name == "test3" && per.Manufacturer == "test3" && per.EmployeeId == eId).FirstOrDefault();
            PeripheralLogic.Delete(g.Id);
            Employee e = c.Employees.Find(eId);
            EmployeeLogic.Delete(e.Id);

            Department d = c.Departments.Find(depId);
            DepartmentLogic.Delete(d.Id);
        }


        [TestMethod]
        public void TestAdd()
        {
            Context context = new Context();
            PeripheralLogic.Add(name, manu, eId);
            Peripheral g = context.Peripherals.Where(per => per.Name == name && per.Manufacturer == manu && per.EmployeeId == eId).FirstOrDefault();
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestChange()
        {
            Context context = new Context();
            PeripheralLogic.Add("test2", "test2", eId);
            Peripheral g = context.Peripherals.Where(per => per.Name == "test2" && per.Manufacturer == "test2" && per.EmployeeId == eId).FirstOrDefault();
            PeripheralLogic.Change("test3", "test3", eId, g.Id, Status.broken, "2");
            g = context.Peripherals.Where(per => per.Name == "test3" && per.Manufacturer == "test3" && per.EmployeeId == eId).FirstOrDefault();
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context context = new Context();
            PeripheralLogic.Add("test4", "test4", eId);
            Peripheral g = context.Peripherals.Where(per => per.Name == "test4" && per.Manufacturer == "test4" && per.EmployeeId == eId).FirstOrDefault();
            PeripheralLogic.Delete(g.Id);
            g = context.Peripherals.Where(per => per.Name == "test4" && per.Manufacturer == "test4" && per.EmployeeId == eId).FirstOrDefault();
            Assert.IsNull(g);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestException()
        {
            PeripheralLogic.Delete(222222);
        }

    }
}
