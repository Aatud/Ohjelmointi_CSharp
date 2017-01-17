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
            int luku = 0;
            int summa;
            int i = 0;
            int a = 0;
            int[] kansio = new int[3];
            while (i < 3)
            {
                Console.Write("Anna kolme lukua >");
                luku = Convert.ToInt32(Console.ReadLine());
                kansio[a] = luku;
                i++;
                a++;
            }
            summa = kansio[0] + kansio[1] + kansio[2];
            int keskiarvo = summa / 3;






            //for (int b = 0; b < kansio.Length; b++)
            //{
            Console.WriteLine("Summa on ", summa);
            Console.WriteLine("Keskiarvo on ", keskiarvo);
            //}
            Console.ReadLine();
        }
    }
}
