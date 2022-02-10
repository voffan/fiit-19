using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    class Film
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int Year { get; set; }
        public String Actor { get; set; }
        public AgeCategory AgeCategory { get; set; }
}
}
