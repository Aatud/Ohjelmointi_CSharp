using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;
            int i = 0;
            int a = 0;
            int num = 1;
            int[] luvut = new int[3];
            int suurin = 0;

            Console.Write("Syötä kolme lukua. Kerron mikä niistä on suurin.\n");
            while (i < 3)
            {
                Console.Write("Anna " + num + ". luku > ");
                luku = Convert.ToInt32(Console.ReadLine());
                luvut[a] = luku;
                i++;
                a++;
                num++;
            }
            if (luvut[0] > luvut[1])
            {
                if (luvut[0] > luvut[2]) suurin = luvut[0];
            }
            if (luvut[1] > luvut[2])
            {
                if (luvut[1] > luvut[0]) suurin = luvut[1];
            }
            if (luvut[2] > luvut[1])
            {
                if (luvut[2] > luvut[0]) suurin = luvut[2];
            }

            Console.Write("Numeroista suurin on " + suurin);
            Console.ReadLine();
        }
    }
}
