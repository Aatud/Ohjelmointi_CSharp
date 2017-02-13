using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_01
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int RegisterNum { get; set; }
        public string Address { get; set; }
        public string HairColor { get; set; }

        public Person()
        {

        }

        public Person(string firstname, string lastname, int age, int registernum, string address, string haircolor)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            RegisterNum = registernum;
            Address = address;
            HairColor = haircolor;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Age + " " + RegisterNum + " " + Address + " " + HairColor;
        }
    }
}
