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
            char[] Opiskelijat = new char[500];
            Opiskelija Masa = new Opiskelija();
            Masa.Nimi = "Masa";
            Masa.Ikä = 20;
            Masa.Sukupuoli = "Mies";
            Masa.OpTunnus = "B123";
            Masa.Kaljalla();
            string MasaT = Masa.Nimi;
            Opiskelijat = MasaT.ToCharArray();
            Console.Write(Opiskelijat[0]);
            Console.ReadLine();
        }
    }
}
