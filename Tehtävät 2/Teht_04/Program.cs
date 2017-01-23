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
            int arvm = 0;
            int arvaus = 101;
            Random rnd = new Random();
            int vastaus = rnd.Next(0, 100);
            Console.WriteLine("Arvaa luku väliltä 0-100");
            

            while (arvaus != vastaus)
            {
                Console.Write("Anna arvaus > ");
                arvaus = int.Parse(Console.ReadLine());
                if (arvaus < vastaus) Console.WriteLine("Luku on suurempi.");
                if (arvaus > vastaus) Console.WriteLine("Luku on pienempi.");
                arvm++;
            }
            Console.WriteLine("Hienoa, arvasit luvun oikein {0}. kerralla.", arvm);


            Console.WriteLine(vastaus);
            Console.ReadLine();
        }
    }
}
