using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using SiliconValley;
using SiliconValley.Logic;

namespace SVTests
{
    [TestClass]
    public class GenreTests
    {
        private static string name;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            name = "Still Life";
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Genre g = c.Genres.Where(gr => gr.Name == name).FirstOrDefault();
            GenreLogic.Delete(g.Id);
            g = c.Genres.Where(gnr => gnr.Name == "EDITMETHOD").FirstOrDefault();
            GenreLogic.Delete(g.Id);
        }
        [TestMethod]
        public void AddMethod()
        {
            Context c = new Context();
            GenreLogic.Add(name);
            Genre g = c.Genres.Where(gnr => gnr.Name == name).FirstOrDefault();
            Assert.IsNotNull(g);
        }
        [TestMethod]
        public void EditMethod()
        {
            Context c = new Context();
            GenreLogic.Add("EDIT");
            Genre g = c.Genres.Where(gnr => gnr.Name == "EDIT").FirstOrDefault();
            GenreLogic.Edit(g.Id, "EDITMETHOD");
            g = c.Genres.Where(gnr => gnr.Name == "EDITMETHOD").FirstOrDefault();
            Assert.IsNotNull(g);
        }
        [TestMethod]
        public void DeleteMethod()
        {
            Context c = new Context();
            GenreLogic.Add("DELETEMETHOD");
            Genre g = c.Genres.Where(gnr => gnr.Name == "DELETEMETHOD").FirstOrDefault();
            GenreLogic.Delete(g.Id);
            g = c.Genres.Where(gr => gr.Name == "DELETEMETHOD").FirstOrDefault();
            Assert.IsNull(g);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionMethod()
        {
            GenreLogic.Delete(222222);
        }
    }
}
