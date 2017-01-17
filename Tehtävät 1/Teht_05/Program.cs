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
            int sekunnit, tunnit, minuutit, sec;
            Console.Write("Anna sekunnit > ");
            sekunnit = int.Parse(Console.ReadLine());

            minuutit = sekunnit / 60 % 60;
            tunnit = sekunnit / 60 / 60;
            sec = sekunnit % 60;

            Console.Write(tunnit + "H ");
            Console.Write(minuutit + "min ");
            Console.Write(sec + "sec");
            Console.ReadLine();
        }
    }
}
