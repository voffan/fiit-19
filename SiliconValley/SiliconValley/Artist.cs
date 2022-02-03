using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Artist
    {
        private string name;
        private DateTime birthday;

        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
    }
}
