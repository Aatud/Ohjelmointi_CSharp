using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulu1 = new int[] { 10, 20, 30, 40, 50 };
            int[] taulu2 = new int[] { 5, 15, 25, 35, 45 };
            int[] taulu_y = new int[taulu1.Length + taulu2.Length];

            Array.Copy(taulu1, taulu_y, taulu1.Length);
            Array.Copy(taulu2, 0, taulu_y, taulu1.Length, taulu2.Length);
            Array.Sort(taulu_y);
            Console.Write("Luvut yhdistetyssä taulukossa : ");
            for ( int i = 0; i < taulu_y.Length; i++)
            {
                Console.Write(taulu_y[i]);
                if (i != taulu_y.Length - 1) Console.Write(",");
            }
            Console.ReadLine();
        }
    }
}
