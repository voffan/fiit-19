using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using SiliconValley;
using SiliconValley.Logic;

namespace SVTests
{
    [TestClass]
    public class PictureTests
    {
        private static string name;
        private static double price;
        private static DateTime date;
        //private static int placementId;
        private static Placement dep;
        //private static int genreId;
        private static Genre g;
        //private static int artistId;
        private static Artist art;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Context c = new Context();

            DepartmentLogic.Add("test dep");
            dep = c.Departments.Where(d => d.Name == "test dep").FirstOrDefault();

            GenreLogic.Add("test genre");
            g = c.Genres.Where(gnr => gnr.Name == "test genre").FirstOrDefault();

            ArtistLogic.Add("test artist", DateTime.Parse("1900-01-01"));
            art = c.Artists.Where(a => a.Name == "test artist" && a.Birthday == DateTime.Parse("1900-01-01")).FirstOrDefault();

            name = "Test Picture";
            price = 50000.15;
            DateTime.TryParse("1998-07-08", out date);
        }
        [ClassCleanup]
        public static void ClassClean()
        {
            Context c = new Context();
            Picture pic = c.Pictures.Where(p => p.Name == name && p.Price == price && p.Date == date && p.PlacementId == dep.Id && p.GenreId == g.Id && p.ArtistId == art.Id).FirstOrDefault();
            PictureLogic.Delete(pic.Id);
            pic = c.Pictures.Where(a => a.Name == "EDITMETHOD" && a.Price == 888.88 && a.Date == DateTime.Parse("1940-01-01") && a.PlacementId == dep.Id && a.GenreId == g.Id && a.ArtistId == art.Id).FirstOrDefault();
            PictureLogic.Delete(pic.Id);
            DepartmentLogic.Delete(dep.Id);
            GenreLogic.Delete(g.Id);
            ArtistLogic.Delete(art.Id);
        }
        [TestMethod]
        public void AddMethod()
        {
            Context c = new Context();
            PictureLogic.Add(name, price, date, dep.Id, g.Id, art.Id);
            Picture pic = c.Pictures.Where(p => p.Name == name && p.Price == price && p.Date == date && p.PlacementId == dep.Id && p.GenreId == g.Id && p.ArtistId == art.Id).FirstOrDefault();
            Assert.IsNotNull(pic);
        }
        [TestMethod]
        public void EditMethod()
        {
            Context c = new Context();
            PictureLogic.Add("EDIT", 999.99, DateTime.Parse("1930-01-01"), dep.Id, g.Id, art.Id);
            Picture pic = c.Pictures.Where(a => a.Name == "EDIT" && a.Price == 999.99 && a.Date == DateTime.Parse("1930-01-01") && a.PlacementId == dep.Id && a.GenreId == g.Id && a.ArtistId == art.Id).FirstOrDefault();
            PictureLogic.Edit(pic.Id, "EDITMETHOD", 888.88, DateTime.Parse("1940-01-01"), dep.Id, g.Id, art.Id);
            pic = c.Pictures.Where(a => a.Name == "EDITMETHOD" && a.Price == 888.88 && a.Date == DateTime.Parse("1940-01-01") && a.PlacementId == dep.Id && a.GenreId == g.Id && a.ArtistId == art.Id).FirstOrDefault();
            Assert.IsNotNull(art);
        }
        [TestMethod]
        public void DeleteMethod()
        {
            Context c = new Context();
            PictureLogic.Add("DELETEMETHOD", 777.77, DateTime.Parse("1970-01-01"), dep.Id, g.Id, art.Id);
            Picture pic = c.Pictures.Where(a => a.Name == "DELETEMETHOD" && a.Price == 777.77 && a.Date == DateTime.Parse("1970-01-01") && a.PlacementId == dep.Id && a.GenreId == g.Id && a.ArtistId == art.Id).FirstOrDefault();
            PictureLogic.Delete(pic.Id);
            pic = c.Pictures.Where(a => a.Name == "DELETEMETHOD" && a.Price == 777.77 && a.Date == DateTime.Parse("1970-01-01") && a.PlacementId == dep.Id && a.GenreId == g.Id && a.ArtistId == art.Id).FirstOrDefault();
            Assert.IsNull(pic);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionMethod()
        {
            ArtistLogic.Delete(222222);
        }
    }
}
