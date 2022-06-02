using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity;
using System.Linq;
using SportAchievements;
using SportAchievements.Classes;
using SportAchievements.Logic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private static string name;
        private static DateTime bdate;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            name = "Новиков Артем Сергеевич";
            bdate = DateTime.Now;
        }

        [TestCleanup]
        public void TestClean()
        {

        }
        [TestMethod]
        public void TestMethod1()
        {
            Context c = new Context();
            PersonLogic.Add(name, bdate);
            Person p = c.Persons.Where(per => per.Name == name && per.BirthDate == bdate).FirstOrDefault();
            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (Context c = new Context())
            {
                PersonLogic.Add("Иванов Иван Иванович", bdate);
                Person p = c.Persons.Where(per => per.Name == "Иванов Иван Иванович" && per.BirthDate == bdate).FirstOrDefault();
                PersonLogic.Edit(p.Id, "Петров Петр Петрович", bdate);
                p = c.Persons.Where(per => per.Name == "Петров Петр Петрович" && per.BirthDate == bdate).FirstOrDefault();
                Assert.IsNotNull(p);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            using (Context c = new Context())
            {
                PersonLogic.Add("Николаев Николай Николаевич", bdate);
                Person p = c.Persons.Where(per => per.Name == "Николаев Николай Николаевич" && per.BirthDate == bdate).FirstOrDefault();
                PersonLogic.Delete(p.Id);
                p = c.Persons.Where(per => per.Name == "Николаев Николай Николаевич" && per.BirthDate == bdate).FirstOrDefault();
                Assert.IsNull(p);
            }
        }
    }
}