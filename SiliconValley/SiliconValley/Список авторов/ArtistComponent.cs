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
        public static void Edit(/* int id */)
        {
            // нужен код на sql
        }
    }
}
