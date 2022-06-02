using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Data.Entity;
using CoCo;
using CoCo.Classes;

namespace Test
{
    [TestClass]
    public class EmployeeTest
    {
        private static int id;
        private static string empl_name;
        private static int dep_Id;
        private static string dep_Name;


        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            id = 3;
            empl_name = "Иванов Иван Иванович";
            dep_Id = 4;
            dep_Name = "Tractor";
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Employee g = c.Employees.Where(gr => gr.Id == 5 && gr.FullName == "Сорокин Иван Васильевич" && gr.DepartmentId == 7 && gr.Department.Name == "Frame").FirstOrDefault();
            EmployeeLogic.Delete(g.Id);
            g = c.Employees.Where(gr => gr.Id == id && gr.FullName == empl_name && gr.DepartmentId == dep_Id && gr.Department.Name == dep_Name).FirstOrDefault();
            EmployeeLogic.Delete(g.Id);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Context c = new Context();
            EmployeeLogic.EmployeeAdd(empl_name, dep_Id);
            Employee g = c.Employees.Where(gr => gr.FullName == empl_name && gr.DepartmentId == dep_Id).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Context c = new Context();
            EmployeeLogic.EmployeeAdd("John John", 2);
            Employee g = c.Employees.Where(gr => gr.FullName == "John John" && gr.DepartmentId == 2).FirstOrDefault();
            EmployeeLogic.EmployeeChange("Daniel", 4, g.Id);
            g = c.Employees.Where(gr => gr.FullName == "Daniel" && gr.DepartmentId == 4).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Context c = new Context();
            EmployeeLogic.EmployeeAdd("Габышев Василий Васильевич", 10);
            Employee g = c.Employees.Where(gr => gr.FullName == "Габышев Василий Васильевич" && gr.DepartmentId == 10).FirstOrDefault();
            EmployeeLogic.Delete(g.Id);
            g = c.Employees.Where(gr => gr.FullName == "Габышев Василий Васильевич" && gr.DepartmentId == 10).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNull(g);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethod4()
        {
            EmployeeLogic.Delete(222222);
        }
    }
}