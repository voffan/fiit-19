using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportAchievements.Classes;

namespace SportAchievements.Components
{
    public static class SportsmanComp
    {
        public static Sportsman AddSportsman(string name, DateTime bdate, Gender gender, int wc_id)
        {
            using (Context c = new Context())
            {
                WeightCategory wc = (from weight in c.WeightCategories
                                  where weight.Id == wc_id
                                  select weight).FirstOrDefault();
                Sportsman sportsman = new Sportsman();
                sportsman.Name = name;
                sportsman.BirthDate = bdate;
                sportsman.Gender = gender;
                sportsman.Weight = wc;
                c.Sportsmen.Add(sportsman);
                c.SaveChanges();
                return sportsman;
            }
        }

        public static void DelSprtsmn(int Id)
        {

            Context c = new Context();
            Sportsman sportsman = c.Sportsmen.Where(p => p.Id == Id).FirstOrDefault();
            if (sportsman != null)
            {
                c.Sportsmen.Remove(sportsman);
                c.SaveChanges();
            }
        }

        public static Sportsman ChSprtsmn(string name, DateTime bdate, Gender gender, int wc_id, int Id)
        {
            Context c = new Context();
            Sportsman sportsman = c.Sportsmen.Where(p => p.Id == Id).FirstOrDefault();
            if (sportsman != null)
            {
                WeightCategory wc = (from weight in c.WeightCategories
                                     where weight.Id == wc_id
                                     select weight).FirstOrDefault();
                sportsman.Name = name;
                sportsman.BirthDate = bdate;
                sportsman.Gender = gender;
                sportsman.Weight = wc;
                c.Entry(sportsman).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
                return sportsman;
            }
            return sportsman;
        }
    }
}
