using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Data.Entity;
using CoCo;
using CoCo.Classes;

namespace UnitTestProject1
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
            Employee g = c.Employees.Where(empl => empl.Id == 5 && empl.FullName == "Сорокин Иван Васильевич" && empl.DepartmentId == 7 && empl.Department.Name == "Frame").FirstOrDefault();
            EmployeeLogic.Delete(g.Id);
            g = c.Employees.Where(gr => gr.Id == id && gr.FullName == empl_name && gr.DepartmentId == dep_Id && gr.Department.Name == dep_Name).FirstOrDefault();
            EmployeeLogic.Delete(g.Id);
        }
        [TestMethod]
        public void TestAdd()
        {
            Context c = new Context();
            EmployeeLogic.EmployeeAdd(empl_name, dep_Id);
            Employee g = c.Employees.Where(empl => empl.FullName == empl_name && empl.DepartmentId == dep_Id).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestChange()
        {
            Context c = new Context();
            EmployeeLogic.EmployeeAdd("John John", 2);
            Employee g = c.Employees.Where(empl => empl.FullName == "John John" && empl.DepartmentId == 2).FirstOrDefault();
            EmployeeLogic.EmployeeChange("Daniel", 4, g.Id);
            g = c.Employees.Where(gr => gr.FullName == "Daniel" && gr.DepartmentId == 4).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context c = new Context();
            EmployeeLogic.EmployeeAdd("Габышев Василий Васильевич", 10);
            Employee g = c.Employees.Where(empl => empl.FullName == "Габышев Василий Васильевич" && empl.DepartmentId == 10).FirstOrDefault();
            EmployeeLogic.Delete(g.Id);
            g = c.Employees.Where(gr => gr.FullName == "Габышев Василий Васильевич" && gr.DepartmentId == 10).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNull(g);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestException()
        {
            EmployeeLogic.Delete(222222);
        }
    }
}