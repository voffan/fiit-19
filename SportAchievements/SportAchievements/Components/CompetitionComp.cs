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
                List<KindOfSport> kinds = new List<KindOfSport>();
                foreach(var ks in kind)
                {
                    KindOfSport k = c.KindsOfSports.Find(ks.Id);
                    if (k != null) kinds.Add(k);
                }
                Competition cmp = new Competition();
                CompType cmpType = (from CompType ct in c.CompTypes
                                    where ct.Id == typeid
                                    select ct).FirstOrDefault();
                cmp.Name = name;
                cmp.DateBeginning = start;
                cmp.DateEnding = end;
                cmp.CompTypeId = typeid;                
                c.Competitions.Add(cmp);
                cmp.KindOfSports.AddRange(kinds);
                c.SaveChanges();
                
                return cmp;
           
            }
        }

        public static void DelCom(int Id)
        {

            Context c = new Context();
            Competition per = c.Competitions.Where(p => p.Id == Id).FirstOrDefault();
            if (per != null)
            {
                c.Competitions.Remove(per);
                c.SaveChanges();
            }
        }

        public static Competition ChCom(string name, DateTime start, DateTime end, int typeid, List<KindOfSport> kind, int Id)
        {
            Context c = new Context();
            Competition per = c.Competitions.Where(p => p.Id == Id).FirstOrDefault();
            if (per != null)
            {
                per.Name = name;
                per.DateBeginning = start;
                per.DateEnding = end;
                per.CompTypeId = typeid;
                per.KindOfSports.AddRange(kind);

                c.Entry(per).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
                return per;
            }
            return per;
        }

    }
}
