using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_01
{
    class Kiuas
    {
        //Ominaisuudet
        public string Malli { get; set; }
        public string Väri { get; set; }
        public bool OnOff { get; set; }
        public int Lämpötila { get; set; }
        public int Kosteus { get; set; }

        //Toiminnot

        public void On()
        {
            OnOff = true;
        }
        public void Off()
        {
            OnOff = false;
        }
        public void Tulosta()
        {
            Console.WriteLine("Kiuas asetukset:");
            Console.WriteLine("- Malli : " + Malli);
            Console.WriteLine("- Väri : " + Väri);
            Console.WriteLine("- Päällä : " + OnOff);
            Console.WriteLine("- Lämpötila : " + Lämpötila);
            Console.WriteLine("- Kosteus : " + Kosteus);
        }
    }
}
