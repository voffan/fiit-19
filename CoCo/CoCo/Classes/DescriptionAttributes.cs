using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CoCo.Classes
{
    public class DescriptionAttributes<T>
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
    }
}
