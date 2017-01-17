using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 1;
            int a = 0;
            int num = 1;
            List<int> luvut = new List<int>();
            int sum = 0;

            Console.Write("Syötä lukuja. Lasken niiden summan.\n");
            while (luku != 0)
            {
                Console.Write("Anna " + num + ". luku > ");
                luku = Convert.ToInt32(Console.ReadLine());
                luvut.Add(luku);
                a++;
                num++;
            }
            sum = luvut.Sum();

            Console.Write("Lukujen summa on " + sum);
            Console.ReadLine();
        }
    }
}
