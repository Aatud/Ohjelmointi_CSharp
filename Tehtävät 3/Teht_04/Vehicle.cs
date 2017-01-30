using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Vehicle
    {
        //ominaisuudet
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //toiminnot
        public void PrintData()
        {
            Console.WriteLine("Vehicle:");
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Speed : " + Speed);
            Console.WriteLine("- Tyres : " + Tyres);
        }
        public override string ToString()
        {    
            return "Vehicle: \n- Name: "+Name +"\n- Speed: "+ Speed +"\n- Tyres: "+ Tyres;
        }
    }
}
