using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int i, k;
            Console.Write("Anna rivien määrä > ");
            luku = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= luku; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
