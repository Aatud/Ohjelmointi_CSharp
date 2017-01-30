using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_05
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public int Ikä { get; set; }
        public string Sukupuoli { get; set; }
        public string OpTunnus { get; set; }
        public string Tila { get; set; }

        public Opiskelija(string nimi, int ikä, string sukupuoli, string opiskelijatunnus)
        {
            Nimi = nimi;
            Ikä = ikä;
            Sukupuoli = sukupuoli;
            OpTunnus = opiskelijatunnus;
            Tila = "Ei tietoa.";
        }

        public void Kasvaa()
        {
            Ikä += 1;
        }
        public void Nukkuu()
        {
            Tila = "Nukkumassa";
        }
        public void Kaljalla()
        {
            Tila = "Kaljalla";
        }
        public void Syö()
        {
            Tila = "Syömässä";
        }

        public void PrintData()
        {
            Console.WriteLine("Opiskeljia:");
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Ikä: " + Ikä);
            Console.WriteLine("Sukupuoli: " + Sukupuoli);
            Console.WriteLine("Opiskelijatunnus: " + OpTunnus);
            Console.WriteLine("Tila: " + Tila);
            Console.WriteLine();
        }
    }
}
