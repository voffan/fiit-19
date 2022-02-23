using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public enum AgeCategory_
    {
        [Description("0+")]
        a0 = 0,
        [Description("3+")]
        a3 = 1,
        [Description("6+")]
        a6 = 2,
        [Description("12+")]
        a12 = 3,
        [Description("16+")]
        a16 = 4,
        [Description("18+")]
        a18 = 5,
        [Description("21+")]
        a21 = 6
    }

    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public AgeCategory_ AgeCategory { get; set; }
        public List<Genre> Genre { get; set; }
        public List<Producer> Producer { get; set; }
        public List<Actor> Actor { get; set; }
        public List<Disk> Disk { get; set; }
    }
}