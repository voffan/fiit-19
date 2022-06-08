using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using SiliconValley;
using SiliconValley.Logic;

namespace SVTests
{
    [TestClass]
    public class ArtistTests
    {
        private static string name;
        private static DateTime birthday;
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            name = "Test Artist";
            DateTime.TryParse("1998-07-08", out birthday);
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Artist art = c.Artists.Where(a => a.Name == name && a.Birthday == birthday).FirstOrDefault();
            ArtistLogic.Delete(art.Id);
            art = c.Artists.Where(a => a.Name == "EDITMETHOD" && a.Birthday == DateTime.Parse("1940-01-01")).FirstOrDefault();
            ArtistLogic.Delete(art.Id);
        }
        [TestMethod]
        public void AddMethod()
        {
            Context c = new Context();
            ArtistLogic.Add(name, birthday);
            Artist art = c.Artists.Where(a => a.Name == name && a.Birthday == birthday).FirstOrDefault();
            Assert.IsNotNull(art);
        }
        [TestMethod]
        public void EditMethod()
        {
            Context c = new Context();
            ArtistLogic.Add("EDIT", DateTime.Parse("1965-01-01"));
            Artist art = c.Artists.Where(a => a.Name == "EDIT" && a.Birthday == DateTime.Parse("1965-01-01")).FirstOrDefault();
            ArtistLogic.Edit(art.Id, "EDITMETHOD", DateTime.Parse("1940-01-01"));
            art = c.Artists.Where(a => a.Name == "EDITMETHOD" && a.Birthday == DateTime.Parse("1940-01-01")).FirstOrDefault();
            Assert.IsNotNull(art);
        }
        [TestMethod]
        public void DeleteMethod()
        {
            Context c = new Context();
            ArtistLogic.Add("DELETEMETHOD", DateTime.Parse("1940-01-01"));
            Artist art = c.Artists.Where(a => a.Name == "DELETEMETHOD" && a.Birthday == DateTime.Parse("1940-01-01")).FirstOrDefault();
            ArtistLogic.Delete(art.Id);
            art = c.Artists.Where(a => a.Name == "DELETEMETHOD" && a.Birthday == DateTime.Parse("1940-01-01")).FirstOrDefault();
            Assert.IsNull(art);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionMethod()
        {
            ArtistLogic.Delete(222222);
        }
    }
}
