using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Logic
{
    public class GenreLogic
    {
        public static void Add(string name)
        {
            Genre genre = new Genre();
            genre.Name = name;
            ListsComponent.Add(genre);
        }
        public static void Edit(int id, string name)
        {
            Genre genre = ListsComponent.GetObjById<Genre>(id);
            genre.Name = name;
            ListsComponent.Edit(genre);
        }
        public static void Delete(int id)
        {
            Genre genre = ListsComponent.GetObjById<Genre>(id);
            ListsComponent.Delete(genre);
        }
    }
}
