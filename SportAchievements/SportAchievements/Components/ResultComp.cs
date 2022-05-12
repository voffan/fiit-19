using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportAchievements.Links;
using SportAchievements.Classes;

namespace SportAchievements.Components
{
    class ResultComp
    {
        public static Result AddResult(int Place, int Point,
            int sportsmanId, int competitionId, int kindOfSportId, int weightId)
        {
            using (Context c = new Context())
            { 
                Result result = new Result();
                result.Place = Place;
                result.Points = Point;
                result.SportsmanId = sportsmanId;
                result.CompetitionId = competitionId;
                result.KindOfSportId = kindOfSportId;
                result.WeightCategoryId = weightId;
                c.Results.Add(result);
                c.SaveChanges();
                return result;
            }
        }

        public static Result EditResult(int Id, string kind, string weight,
            int Place, int Points)
        {
            Result res;
            using (Context c = new Context())
            {
                res = c.Results.Where(r => r.Id == Id).FirstOrDefault();
                if (res != null)
                {

                }
            }
            return res;
        }
    }
}
