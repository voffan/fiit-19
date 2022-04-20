using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportAchievements.Classes;
using System.Windows.Forms;

namespace SportAchievements
{
    public static class KindofsportComp
    {
        public static KindOfSport AddKindOfSport(string name)
        {
            using (Context c = new Context())
            {
                KindOfSport k = new KindOfSport();
                
                
                k.Name = name;
                
                c.KindsOfSports.Add(k);
                c.SaveChanges();
                return k;
                
            }
        }
        public static void DelKind(int Id)
        {

            Context c = new Context();
            KindOfSport per = c.KindsOfSports.Where(p => p.Id == Id).FirstOrDefault();
            if (per != null)
            {
                c.KindsOfSports.Remove(per);
                c.SaveChanges();
            }
        }

        public static KindOfSport ChKind(string name,int Id)
        {
            Context c = new Context();
            KindOfSport per = c.KindsOfSports.Where(p => p.Id == Id).FirstOrDefault();
            if (per != null)
            {
                per.Name = name;
                c.Entry(per).State = System.Data.Entity.EntityState.Modified;
                c.SaveChanges();
                return per;
            }
            return per;
        }
    }
}
