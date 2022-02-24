using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class FilmMaker : Human
    {
        public virtual List<Film> Films { get; set; }
    }
}
