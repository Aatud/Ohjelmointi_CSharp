using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            car.Name = "Matzda";
            car.Speed = 60;
            car.Tyres = 3;

            car.PrintData();
            Console.ReadLine();

            car.AsString();
            Console.ReadLine();
        }
    }
}
