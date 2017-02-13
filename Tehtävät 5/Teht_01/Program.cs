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
            Persons henkilöt = new Persons();
            Person Matti = new Person();
            henkilöt.AddPerson(Matti.FirstName = "MAtti", Matti.LastName = "Kohonen");
        }
    }
}
