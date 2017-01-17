using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulu = new int[5];
            string[] sanat = new string[] { "yksi ", "kaksi", "kolme", "neljä", "viisi" };
            int luku;
            int a = 0;
            int q = 4;
            Console.Write("Anna viisi lukua!\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Luku " + sanat[a] + " > ");
                luku = Convert.ToInt32(Console.ReadLine());
                taulu[a] = luku;
                a++;
                if (i == 4)
                {
                    for (int d = 0; d < 5; d++)
                    {
                        Console.Write(taulu[q]);
                        q--;
                        if (d < 4) Console.Write(",");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
