using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna pisteet :");
            int piste;
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out piste);
            if (result)
            {
                switch (piste)
                {
                    case 0:
                    case 1: Console.WriteLine("Arvosana on 0"); break;
                    case 2:
                    case 3: Console.WriteLine("Arvosana on 1"); break;
                    case 4:
                    case 5: Console.WriteLine("Arvosana on 2"); break;
                    case 6:
                    case 7: Console.WriteLine("Arvosana on 3"); break;
                    case 8:
                    case 9: Console.WriteLine("Arvosana on 4"); break;
                    case 10:
                    case 11: Console.WriteLine("Arvosana on 5"); break;

                }


            }

            Console.ReadLine();
        }
    }
}
