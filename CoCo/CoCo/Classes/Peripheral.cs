using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoCo.Classes
{
    internal class Peripheral:Device
    {
        private string name { get; set; }
        private string manufacturer { get; set; }
        [ForeignKey("employee")]
        public Employee employee { get; set; }
    }
}
