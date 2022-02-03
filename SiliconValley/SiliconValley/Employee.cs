using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    class Employee
    {
        private Position position;
        private string phoneNumber;
        private Education education;
        private DateTime birthday;

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        internal Position Position { get => position; set => position = value; }
        internal Education Education { get => education; set => education = value; }
    }
}
