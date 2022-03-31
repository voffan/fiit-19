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
        public static Sportsman AddSportsman(string name, DateTime bdate, Gender gender, WeightCategory weight)
        {
            using (Context c = new Context())
            {
                Sportsman sportsman = new Sportsman();
                sportsman.Name = name;
                sportsman.BirthDate = bdate;
                sportsman.Gender = gender;
                sportsman.Weight = weight;
                c.Sportsmen.Add(sportsman);
                c.SaveChanges();
                return sportsman;
            }
        }
    }
}
