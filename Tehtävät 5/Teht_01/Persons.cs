using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_01
{
    class Persons
    {

        public List<Person> lista = new List<Person>();

        public void AddPerson(Person person)
        {
            this.lista.Add(person);
        }
        public void GetPerson(int index)
        {
            Console.WriteLine(lista.ElementAt(index));
        }
        public void FindPerson(int RegisterNum)
        {
            foreach (Person person in lista)
            {
                if (lista.Equals(RegisterNum))
                {
                    Console.Write(person.ToString());
                }
            }
        }
        public void PrintData()
        {
            foreach (Person person in lista)
            {
                Console.WriteLine(person.ToString());
            }
        }  
    }
}
