using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Journal
    {
        private Picture picture;
        private Placement from;
        private Placement to;
        private DateTime date;
        private Employee employee;

        public DateTime Date { get => date; set => date = value; }
        internal Picture Picture { get => picture; set => picture = value; }
        internal Placement From { get => from; set => from = value; }
        internal Placement To { get => to; set => to = value; }
        internal Employee Employee { get => employee; set => employee = value; }
    }
}
