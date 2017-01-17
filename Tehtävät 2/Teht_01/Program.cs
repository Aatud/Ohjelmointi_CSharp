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
            int koko;
            List<int> pisteet = new List<int>();
            int i = 0;
            Console.WriteLine("Viiden tuomarin pisteet.");

            while (i < 5)
            {
                Console.Write("Anna pisteet > ");
                koko = Convert.ToInt32(Console.ReadLine());
                i++;
                pisteet.Add(koko);
            }
            int max = pisteet.Max();
            int min = pisteet.Min();
            int sum = pisteet.Sum();
            sum -= (min + max);
            Console.WriteLine("Pisteet ovat : {0}", sum);
            Console.ReadLine();
        }
    }
}
