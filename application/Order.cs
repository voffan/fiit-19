using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    class Order
    {
        public int Id { get; set; }
        public int Passport { get; set; }
        public int Data { get; set; }
        public Pledge Pledge { get; set; }
    }
}
