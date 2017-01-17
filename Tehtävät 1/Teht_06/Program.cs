using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double bensanhinta = 1.595, kulutus, hinta;

            Console.Write("Anna matka > ");
            matka = int.Parse(Console.ReadLine());

            kulutus = ((double)matka / 100) * 7.02;
            hinta = kulutus * bensanhinta;

            Console.Write("Bensaa kuluu " + Math.Round(kulutus, 2) + " litraa, kustannus " + Math.Round(hinta, 2) + " euroa.");
            Console.ReadLine();
        }
    }
}
