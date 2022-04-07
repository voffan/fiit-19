using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportAchievements.Classes;
using System.Windows.Forms;

namespace SportAchievements.Components
{
    public static class CompetitionComp
    {
        //Context con, string name, DateTime start, DateTime end, int typeid, string type
        public static Competition AddCompetition(string name, DateTime start, DateTime end, int typeid, List<KindOfSport> kind)
        {
            using (Context c = new Context()) 
            { 
                Competition cmp = new Competition();
                CompType cmpType = (from CompType ct in c.CompTypes
                                    where ct.Id == typeid
                                    select ct).FirstOrDefault();
                cmp.Name = name;
                cmp.DateBeginning = start;
                cmp.DateEnding = end;
                cmp.CompTypeId = typeid;
                cmp.KindOfSports.AddRange(kind);
                c.Competitions.Add(cmp);
                c.SaveChanges();
                return cmp;
           
            }
        }

        
    }
}
