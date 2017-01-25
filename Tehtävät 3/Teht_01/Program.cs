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
            Kiuas hotstone = new Kiuas();
            hotstone.Malli = "Hot stone 2000";
            hotstone.Väri = "Punainen";
            hotstone.OnOff = true;
            hotstone.Lämpötila = 90;
            hotstone.Kosteus = 5;

            hotstone.Tulosta();
            Console.ReadLine();

            hotstone.Off();
            hotstone.Tulosta();
            Console.ReadLine();
        }
    }
}
