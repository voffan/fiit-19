using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public class Disk
    {
        public int Id { get; set; }
        public virtual List<Film> Film { get; set; }
        public int Price { get; set; }
    }
}
