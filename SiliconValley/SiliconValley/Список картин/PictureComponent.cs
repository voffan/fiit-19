using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Список_картин
{
    class PictureComponent
    {
        public static void Add(string name, double price, DateTime date, int? placement_id, int? genre_id, int artist_id)
        {
            using (var db = new Context())
            {
                var pic = new Picture { Name = name, Price = price, Date = date, PlacementId = placement_id, GenreId = genre_id, ArtistId = artist_id };
                db.Pictures.Add(pic);
                db.SaveChanges();
            }
        }
        public static void Edit(int? index, string name, double price, DateTime date, int? placement_id, int? genre_id, int? artist_id)
        {
            using (var db = new Context())
            {
                Picture p = GetPictureByIndex(index);
                if (p != null)
                {
                    p.Name = name;
                    p.Price = price;
                    p.Date = date;
                    p.PlacementId = placement_id;
                    p.GenreId = genre_id;
                    p.ArtistId = artist_id;
                    db.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
                else throw new Exception("");
            }
        }
        public static void Delete(int? index)
        {
            using (var db = new Context())
            {
                Picture p = GetPictureByIndex(index);
                if (p != null)
                {
                    db.Remove(p);
                    db.SaveChanges();
                }
                else throw new Exception("");
            }
        }

        public static Picture GetPictureByIndex(int? index)
        {
            Context c = new Context();
            Picture p = (from picture in c.Pictures
                        where picture.Id == index
                        select picture).FirstOrDefault();
            return p;
        }
    }

}
