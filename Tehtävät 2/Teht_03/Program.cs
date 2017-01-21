using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Luku;
            int i, k, a, w;
            int e = 0;
            Console.Write("Anna rivien määrä > ");
            Luku = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= Luku; i++)
            {
                for (a = 1; a < Luku-i+1; a++)
                {
                    Console.Write(" ");
                }            
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            while (e < 2)
            {
                for (w = 1; w < Luku; w++)
                {
                    Console.Write(" ");
                    
                }
                Console.WriteLine("*");
                e++;
            }
            
            Console.ReadLine();
        }
    }
}
