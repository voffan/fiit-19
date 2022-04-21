using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Список_авторов
{
    public static class ArtistComponent
    {
        public static void Add(string name, DateTime birthday)
        {
            using (var db = new Context())
            {
                var art1 = new Artist { Name = name, Birthday = birthday };
                db.Artists.Add(art1);
                db.SaveChanges();
            }
        }
        public static void Edit(int index, string name, DateTime birthday)
        {
            using (var db = new Context())
            {
                Artist a = GetArtistByIndex(index);
                if (a != null)
                {
                    a.Name = name;
                    a.Birthday = birthday;
                    db.Entry(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
                else throw new Exception("");
            }
        }
        public static void Delete(int index)
        {
            using (var db = new Context())
            {
                Artist a = GetArtistByIndex(index);
                if (a != null)
                {
                    db.Remove(a);
                    db.SaveChanges();
                }
                else throw new Exception("");
            }
        }

        public static Artist GetArtistByIndex(int index)
        {
            Context c = new Context();
            Artist a = (from artist in c.Artists
                       where artist.Id == index
                       select artist).FirstOrDefault();
            return a;
        }
    }
}
