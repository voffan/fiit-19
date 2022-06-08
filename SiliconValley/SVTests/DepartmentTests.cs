using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using SiliconValley;
using SiliconValley.Logic;

namespace SVTests
{
    [TestClass]
    public class DepartmentTests
    {
        private static string name;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            name = "Department test";
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Department dep = c.Departments.Where(d => d.Name == name).FirstOrDefault();
            DepartmentLogic.Delete(dep.Id);
            dep = c.Departments.Where(d => d.Name == "EDITMETHOD").FirstOrDefault();
            DepartmentLogic.Delete(dep.Id);
        }
        [TestMethod]
        public void AddMethod()
        {
            Context c = new Context();
            DepartmentLogic.Add(name);
            Department dep = c.Departments.Where(d => d.Name == name).FirstOrDefault();
            Assert.IsNotNull(dep);
        }
        [TestMethod]
        public void EditMethod()
        {
            Context c = new Context();
            DepartmentLogic.Add("EDIT");
            Department dep = c.Departments.Where(d => d.Name == "EDIT").FirstOrDefault();
            DepartmentLogic.Edit(dep.Id, "EDITMETHOD");
            dep = c.Departments.Where(d => d.Name == "EDITMETHOD").FirstOrDefault();
            Assert.IsNotNull(dep);
        }
        [TestMethod]
        public void DeleteMethod()
        {
            Context c = new Context();
            DepartmentLogic.Add("DELETEMETHOD");
            Department dep = c.Departments.Where(d => d.Name == "DELETEMETHOD").FirstOrDefault();
            DepartmentLogic.Delete(dep.Id);
            dep = c.Departments.Where(d => d.Name == "DELETEMETHOD").FirstOrDefault();
            Assert.IsNull(dep);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionMethod()
        {
            DepartmentLogic.Delete(222222);
        }
    }
}
