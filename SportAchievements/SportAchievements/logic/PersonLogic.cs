using System;
using SportAchievements.Classes;

namespace SportAchievements.Logic
{
    public class PersonLogic
    {
        public static void Add(string name, DateTime bdate)
        {
            using (Context c = new Context())
            {
                Person p = new Person() { Name = name, BirthDate = bdate };
                c.Persons.Add(p);
                c.SaveChanges();
            }
        }

        public static void Edit(int id, string name, DateTime bdate)
        {
            using (Context c = new Context())
            {
                Person p = c.Persons.Find(id);
                p.Name = name;
                p.BirthDate = bdate;
                c.Entry(p).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (Context c = new Context())
            {
                Person p = c.Persons.Find(id);
                c.Persons.Remove(p);
                c.SaveChanges();
            }
        }
    }
}
