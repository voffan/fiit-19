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
        public static Competition AddCompetition(Context con, string name, DateTime start, DateTime end, int typeid, string type)
        {
            Competition empl1 = (from person in con.Competitions
                              where person.Name == name
                              select person).FirstOrDefault();


                Competition empl = new Competition();
                CompType empl2 = new CompType();
                empl.Name = name;
                empl.DateBeginning = start;
                empl.DateEnding = end;
                empl.CompTypeId = typeid;
                empl2.Name = type;
                
                con.SaveChanges();
                return empl;
            
        }

        
    }
}
