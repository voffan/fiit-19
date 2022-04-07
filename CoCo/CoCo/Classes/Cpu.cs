using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CoCo.Classes
{
    public class Cpu
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public String Name { get; set; }
        [Range(0, 30)]
        public decimal Frequency { get; set; }
        [MaxLength(300)]
        public String Manufacturer { get; set; }

        public void Add(string name, decimal freq, string manu)
        {
            Context context = new Context();
            Name = name;
            Frequency = freq;
            Manufacturer = manu;
            context.Cpus.Add(this);
            context.SaveChanges();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
