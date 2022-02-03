using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Picture
    {
        private string name;
        private double price;
        private DateTime date;
        private Placement placement;
        private Genre genre;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public DateTime Date { get => date; set => date = value; }
        internal Placement Placement { get => placement; set => placement = value; }
        internal Genre Genre { get => genre; set => genre = value; }
    }
}
