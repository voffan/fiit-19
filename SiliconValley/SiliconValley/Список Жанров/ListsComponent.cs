using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley.Список_Жанров
{
    class ListsComponent
    {
        public static void Add<T>(T obj) where T : class
        {
            using (var db = new Context())
            {
                db.Set<T>().Add(obj);
                db.SaveChanges();
            }
        }

        public static void Edit<T>(T obj) where T:class
        {
            using (var db = new Context())
            {
                T a = obj;
                if (a != null)
                {
                    db.Entry(a).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else throw new Exception("");
            }
        }

        public static void Delete<T>(T obj) where T : class
        {
            using (var db = new Context())
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }




        public static T GetObjById<T>(int index) where T : class
        {
            Context c = new Context();
            T a = (from obj in c.Set<T>()
                        where ((IId)obj).Id == index
                        select obj).FirstOrDefault();
            return a;
        }

    }
}
