using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int a = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                int parillinen = lista[a] % 2;
                if (parillinen == 0) Console.Write(lista[a] + " ");
                a++;
            }
            Console.ReadLine();
        }
    }
}
