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
            // Erittäin huono toteutus, mutta toimii!          
            int arvo;
            List<int> L0 = new List<int>();
            List<int> L1 = new List<int>();
            List<int> L2 = new List<int>();
            List<int> L3 = new List<int>();
            List<int> L4 = new List<int>();
            List<int> L5 = new List<int>();
            string lopetus = "";

            while (lopetus != "q")
            {
                Console.Write("Anna arvosana > ");
                lopetus = Console.ReadLine();
                int.TryParse(lopetus, out arvo);
                if (arvo == 0) L0.Add(arvo);
                if (arvo == 1) L1.Add(arvo);
                if (arvo == 2) L2.Add(arvo);
                if (arvo == 3) L3.Add(arvo);
                if (arvo == 4) L4.Add(arvo);
                if (arvo == 5) L5.Add(arvo);
                
            }
            int nol = L0.Count() - 1;
            int yks = L1.Count();
            int kaks = L2.Count();
            int kol = L3.Count();
            int nel = L4.Count();
            int viis = L5.Count();
            string merkki = "*";
            Console.WriteLine("Arvosanat:");
            Console.Write("0:");
            for (int q = 0; q < nol; q++) Console.Write(merkki);
            Console.Write("\n1:");
            for (int w = 0; w < yks; w++) Console.Write(merkki);
            Console.Write("\n2:");
            for (int e = 0; e < kaks; e++) Console.Write(merkki);
            Console.Write("\n3:");
            for (int r = 0; r < kol; r++) Console.Write(merkki);
            Console.Write("\n4:");
            for (int t = 0; t < nel; t++) Console.Write(merkki);
            Console.Write("\n5:");
            for (int y = 0; y < viis; y++) Console.Write(merkki);
            Console.ReadLine();
        }
    }
}
