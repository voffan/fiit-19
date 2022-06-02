using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CoCo.Classes;
using CoCo;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class HddTest
    {
        private static string name;
        private static string manu;
        private static decimal vol;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            name = "mb test 1";
            manu = "some manu";
            vol = 2;
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Hdd g = c.Hdds.Where(hdd => hdd.Name == "mb test 1" && hdd.Manufacturer == "some manu" && hdd.Volume == vol).FirstOrDefault();
            HddLogic.Delete(g.Id);
            g = c.Hdds.Where(hdd => hdd.Name == name && hdd.Manufacturer == manu).FirstOrDefault();
            HddLogic.Delete(g.Id);
        }
        [TestMethod]
        public void TestAdd()
        {
            Context c = new Context();
            HddLogic.Add(name, vol, manu);
            Hdd g = c.Hdds.Where(hdd => hdd.Name == name && hdd.Volume == vol && hdd.Manufacturer == manu).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestChange()
        {
            Context c = new Context();
            HddLogic.Add("mb test 2", 20, "some manu 2");
            Hdd g = c.Hdds.Where(hdd => hdd.Name == "mb test 2" && hdd.Volume == 20 && hdd.Manufacturer == "some manu 2").FirstOrDefault();
            HddLogic.Change("mb test 1", 2, "some manu", g.Id);
            g = c.Hdds.Where(hdd => hdd.Name == "mb test 1" && hdd.Volume == 2 && hdd.Manufacturer == "some manu").FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context c = new Context();
            HddLogic.Add("mb test 3", 10, "some manu 2");
            Hdd g = c.Hdds.Where(hdd => hdd.Name == "mb test 3" && hdd.Volume == 10 && hdd.Manufacturer == "some manu 2").FirstOrDefault();
            HddLogic.Delete(g.Id);
            g = c.Hdds.Where(hdd => hdd.Name == "mb test 3" && hdd.Volume == 10 && hdd.Manufacturer == "some manu 2").FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNull(g);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestException()
        {
            HddLogic.Delete(222222);
        }
    }
}
