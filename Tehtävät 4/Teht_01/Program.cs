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
            Elevator elevator = new Elevator();
            bool result;

            do
            {
                Console.WriteLine("Elevator is now at floor: " + elevator.Floor);
                Console.Write("Give a new floor number (1-5) > ");
                string line = Console.ReadLine();
                int floor;
                result = int.TryParse(line, out floor);
                if (result)
                {
                    elevator.Floor = floor;
                }
            }
            while (result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
