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

            Console.WriteLine("Kiuas asetukset:");
            Console.WriteLine("- Malli : " + hotstone.Malli);
            Console.WriteLine("- Väri : " + hotstone.Väri);
            Console.WriteLine("- Päällä : " + hotstone.OnOff);
            Console.WriteLine("- Lämpötila : " + hotstone.Lämpötila);
            Console.WriteLine("- Kosteus : " + hotstone.Kosteus);
            Console.ReadLine();

            //sammuttaa kiukaan
            hotstone.Off();

            Console.WriteLine("Kiuas asetukset:");
            Console.WriteLine("- Malli : " + hotstone.Malli);
            Console.WriteLine("- Väri : " + hotstone.Väri);
            Console.WriteLine("- Päällä : " + hotstone.OnOff);
            Console.WriteLine("- Lämpötila : " + hotstone.Lämpötila);
            Console.WriteLine("- Kosteus : " + hotstone.Kosteus);
            Console.ReadLine();            
        }
    }
}
