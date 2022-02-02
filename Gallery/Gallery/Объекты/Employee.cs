using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Объекты
{
    class Employee
    {
        int id;

        string lastName;
        string firstName;
        string fatherName;

        int age;

        string phoneNumber;

        string education;

        DateTime birthDay;

        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public int Age { get => age; set => age = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Education { get => education; set => education = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
    }
}
