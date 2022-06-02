using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CoCo.Classes;
using CoCo;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class CpuTest
    {
        private static string name;
        private static string manu;
        private static decimal freq;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            name = "mb test 1";
            manu = "some manu";
            freq = 2;
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Cpu g = c.Cpus.Where(cpu => cpu.Name == "mb test 1" && cpu.Manufacturer == "some manu" && cpu.Frequency == freq).FirstOrDefault();
            CpuLogic.Delete(g.Id);
            g = c.Cpus.Where(cpu => cpu.Name == name && cpu.Manufacturer == manu && cpu.Frequency == freq).FirstOrDefault();
            CpuLogic.Delete(g.Id);
            g = c.Cpus.Where(cpu => cpu.Name == "mb test 3" && cpu.Manufacturer == "some manu 2" && cpu.Frequency == freq).FirstOrDefault();
            CpuLogic.Delete(g.Id);
        }
        [TestMethod]
        public void TestAdd()
        {
            Context c = new Context();
            CpuLogic.Add(name, freq, manu);
            Cpu g = c.Cpus.Where(cpu => cpu.Name == name && cpu.Frequency == freq && cpu.Manufacturer == manu).FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestChange()
        {
            Context c = new Context();
            CpuLogic.Add("mb test 2", 20, "some manu 2");
            Cpu g = c.Cpus.Where(cpu => cpu.Name == "mb test 2" && cpu.Frequency == 20 && cpu.Manufacturer == "some manu 2").FirstOrDefault();
            CpuLogic.Change("mb test 1", 2, "some manu", g.Id);
            g = c.Cpus.Where(cpu => cpu.Name == "mb test 1" && cpu.Frequency == 2 && cpu.Manufacturer == "some manu").FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNotNull(g);
        }

        [TestMethod]
        public void TestDelete()
        {
            Context c = new Context();
            CpuLogic.Add("mb test 4", 10, "some manu 2");
            Cpu g = c.Cpus.Where(cpu => cpu.Name == "mb test 4" && cpu.Frequency == 10 && cpu.Manufacturer == "some manu 2").FirstOrDefault();
            CpuLogic.Delete(g.Id);
            Cpu go = c.Cpus.Where(cpu => cpu.Name == "mb test 4" && cpu.Frequency == 10 && cpu.Manufacturer == "some manu 2").FirstOrDefault();
            //Assert.AreNotSame(null, g);
            Assert.IsNull(go);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestException()
        {
            CpuLogic.Delete(222222);
        }
    }
}
