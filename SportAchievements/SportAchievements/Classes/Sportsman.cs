using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SportAchievements.Classes
{
    public enum Gender
    {
        [Description("Мужской")]
        Man = 1,
        [Description("Женский")]
        Woman = 2
    }

    public class Sportsman : Person
    {
        public WeightCategory Weight { get; set; }

        /*public static class DescriptionAttributes<T>
        {
            public static Dictionary<string, string> RetrieveAttributes()
            {
                Dictionary<string, string> Attributes = new Dictionary<string, string>();

                foreach (var memberInfo in typeof(T).GetMembers())
                {
                    DescriptionAttribute[] list = memberInfo.GetCustomAttributes(typeof(DescriptionAttribute), true).Cast<DescriptionAttribute>().ToArray();
                    if (list.Length > 0)
                    {
                        Attributes[list[0].Description] = memberInfo.Name;
                    }
                }

                return Attributes;
            }
        }*/
    }
}
