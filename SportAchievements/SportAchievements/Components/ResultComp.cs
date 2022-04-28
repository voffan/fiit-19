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
        public static Result AddResult()
        {
            using (Context c = new Context())
            { 
                Result result = new Result();
                c.Results.Add(result);
                c.SaveChanges();
                return result;
            }
        }
    }
}
