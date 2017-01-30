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

    }
}
