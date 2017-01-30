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
            Opiskelija[] opiskelijat = new Opiskelija[5];
           
            opiskelijat[0] = new Opiskelija("Masa", 20, "mies", "D5643");
            opiskelijat[1] = new Opiskelija("Esa", 25, "mies", "D35436");
            opiskelijat[2] = new Opiskelija("Vesa", 23, "mies", "D5348");
            opiskelijat[3] = new Opiskelija("Mari", 22, "nainen", "D8783");
            opiskelijat[4] = new Opiskelija("Kari", 19, "mies", "D2172");
            int i = 0;
            while ( i < 5 )
            {
                opiskelijat[i].PrintData();
                i++;
            }
            opiskelijat[0].Nukkuu();
            opiskelijat[1].Nukkuu();
            opiskelijat[2].Syö();
            opiskelijat[3].Kaljalla();
            opiskelijat[4].Kaljalla();
            Console.ReadLine();
            for(int e = 0; e < 5; e++)
            {
                opiskelijat[e].PrintData();
            }
            Console.ReadLine();
        }
    }
}
