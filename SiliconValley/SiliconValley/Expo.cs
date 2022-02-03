using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Expo : Placement
    {
        private string address;
        private DateTime start;
        private DateTime end;

        public string Address { get => address; set => address = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
    }
}
