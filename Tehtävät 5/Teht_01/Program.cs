using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons persons = new Persons();
            Person Matti = new Person("Matti", "Kohonen", 100, 1000, "Katu", "vaalea");
            persons.AddPerson(Matti);
            persons.GetPerson(0);
            persons.FindPerson(1000);
            persons.PrintData();
        }
    }
}
