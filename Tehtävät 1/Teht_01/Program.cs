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
            int luku;
            Console.Write("anna luku > ");
            luku = int.Parse(Console.ReadLine());
            //tommonen helppo if else ehto säätö
            if (luku == 1) Console.WriteLine("Annoit luvun yksi");
            else if (luku == 2) Console.WriteLine("annoit luvun kaksi");
            else if (luku == 3) Console.WriteLine("annoit luvun kolme");
            else Console.WriteLine("joku muu luku");
            Console.ReadLine();
        }
    }
}
