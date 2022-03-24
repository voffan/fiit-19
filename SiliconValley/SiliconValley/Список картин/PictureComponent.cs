using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Список_картин
{
    class PictureComponent
    {
        public static void Add(string name, double price, DateTime date, Placement placement, Genre genre, Artist artist)
        {
            using (var db = new Context())
            {
                var pic = new Picture { Name = name, Price = price, Date = date, Placement = placement, Genre = genre, Artist = artist };
                db.Pictures.Add(pic);
                db.SaveChanges();
            }
        }
        public static void Edit(int index, string name, double price, DateTime date, Placement placement, Genre genre, Artist artist)
        {
            using (var db = new Context())
            {
                Picture p = GetPictureByIndex(index);
                if (p != null)
                {
                    p.Name = name;
                    p.Price = price;
                    p.Date = date;
                    p.Placement = placement;
                    p.Genre = genre;
                    p.Artist = artist;
                    db.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
                else throw new Exception("");
            }
        }
        public static void Delete(int index)
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

        public static Picture GetPictureByIndex(int index)
        {
            Context c = new Context();
            Picture p = (from picture in c.Pictures
                        where picture.Id == index
                        select picture).FirstOrDefault();
            return p;
        }
    }

}
