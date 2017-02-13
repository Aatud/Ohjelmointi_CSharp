using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_01
{
    class Persons
    {

        public List<Persons> persons;

        public Persons()
        {

        }

        public void AddPerson()
        {
            persons.Add(new Person{FirstName, LastName, Age, RegisterNum, Address, HairColor});
        }
        public void GetPerson()
        {

        }
        public void FindPerson()
        {

        }
        public void PrintData()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Age;
        }        
    }
}
