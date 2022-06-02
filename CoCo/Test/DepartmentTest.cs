using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Data.Entity;
using CoCo;
using CoCo.Classes;

namespace Test
{
    [TestClass]
    public class DepartmentTest
    {
        private static int id;
        private static string name;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            id = 1;
            name = "Tractorrr";
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Department g = c.Departments.Where(gr => gr.Id == 66 && gr.Name == "Frame").FirstOrDefault();
            DepartmentLogic.Delete(g.Id);
            g = c.Departments.Where(gr => gr.Id == id && gr.Name == name).FirstOrDefault();
            DepartmentLogic.Delete(g.Id);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Context c = new Context();
            DepartmentLogic.DepartmentAdd(name);
            Department g = c.Departments.Where(gr => gr.Id == id && gr.Name == name).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Context c = new Context();
            DepartmentLogic.DepartmentAdd("ФИИТ");
            Department g = c.Departments.Where(gr => gr.Name == "ФИИТ").FirstOrDefault();
            DepartmentLogic.DepartmentChange("ИВТ-22", g.Id);
            g = c.Departments.Where(gr => gr.Name == "ИВТ-22").FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Context c = new Context();
            DepartmentLogic.DepartmentAdd("Габышев Василий Васильевич");
            Department g = c.Departments.Where(gr => gr.Name == "Габышев Василий Васильевич").FirstOrDefault();
            DepartmentLogic.Delete(g.Id);
            g = c.Departments.Where(gr => gr.Name == "Габышев Василий Васильевич").FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNull(g);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethod4()
        {
            DepartmentLogic.Delete(222222);
        }
    }
}