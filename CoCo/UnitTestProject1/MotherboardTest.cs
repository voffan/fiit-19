using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CoCo.Classes;
using CoCo;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class MotherboardTest
    {
        private static string name;
        private static string manu;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            name = "mb test 1";
            manu = "some manu";
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Motherboard g = c.Motherboards.Where(gr => gr.Name == "mb test 1" && gr.Manufacturer == "some manu").FirstOrDefault();
            MotherboardLogic.Delete(g.Id);
            g = c.Motherboards.Where(gr => gr.Name == name && gr.Manufacturer == manu).FirstOrDefault();
            MotherboardLogic.Delete(g.Id);
        }
        [TestMethod]
        public void TestAdd()
        {
            Context c = new Context();
            MotherboardLogic.Add(name, manu);
            Motherboard g = c.Motherboards.Where(gr => gr.Name == name && gr.Manufacturer == manu).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestChange()
        {
            Context c = new Context();
            MotherboardLogic.Add("mb test 2", "some manu 2");
            Motherboard g = c.Motherboards.Where(gr => gr.Name == "mb test 2" && gr.Manufacturer == "some manu 2").FirstOrDefault();
            MotherboardLogic.Change("mb test 1", "some manu", g.Id);
            g = c.Motherboards.Where(gr => gr.Name == "mb test 1" && gr.Manufacturer == "some manu").FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context c = new Context();
            MotherboardLogic.Add("mb test 3", "some manu 2");
            Motherboard g = c.Motherboards.Where(gr => gr.Name == "mb test 3" && gr.Manufacturer == "some manu 2").FirstOrDefault();
            MotherboardLogic.Delete(g.Id);
            g = c.Motherboards.Where(gr => gr.Name == "mb test 3" && gr.Manufacturer == "some manu 2").FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNull(g);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestException()
        {
            MotherboardLogic.Delete(222222);
        }
    }
}
