using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Logic
{
    public class ArtistLogic
    {
        public static void Add(string name, DateTime birthday)
        {
            Artist art = new Artist();
            art.Name = name;
            art.Birthday = birthday;
            ListsComponent.Add(art);
        }
        public static void Edit(int id, string name, DateTime birthday)
        {
            Artist art = ListsComponent.GetObjById<Artist>(id);
            art.Name = name;
            art.Birthday = birthday;
            ListsComponent.Edit(art);
        }
        public static void Delete(int id)
        {
            Artist art = ListsComponent.GetObjById<Artist>(id);
            ListsComponent.Delete(art);
        }
    }
}
