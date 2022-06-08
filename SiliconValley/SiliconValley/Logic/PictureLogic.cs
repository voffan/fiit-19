using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Logic
{
    public class PictureLogic
    {
        public static void Add(string name, double price, DateTime date, int placementId, int genreId, int artistId)
        {
            Picture pic = new Picture();
            pic.Name = name;
            pic.Price = price;
            pic.Date = date;
            pic.PlacementId = placementId;
            pic.GenreId = genreId;
            pic.ArtistId = artistId;
            ListsComponent.Add(pic);
        }
        public static void Edit(int id, string name, double price, DateTime date, int placementId, int genreId, int artistId)
        {
            Picture pic = ListsComponent.GetObjById<Picture>(id);
            pic.Name = name;
            pic.Price = price;
            pic.Date = date;
            pic.PlacementId = placementId;
            pic.GenreId = genreId;
            pic.ArtistId = artistId;
            ListsComponent.Edit(pic);
        }
        public static void Delete(int id)
        {
            Picture pic = ListsComponent.GetObjById<Picture>(id);
            ListsComponent.Delete(pic);
        }
    }
}
