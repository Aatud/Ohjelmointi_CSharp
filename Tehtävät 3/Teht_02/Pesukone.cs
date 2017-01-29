using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_02
{
    class Pesukone
    {
        //Ominaisuudet
        public string Malli { get; set; }
        public string Väri { get; set; }
        public bool OnOff { get; set; }
        public int Lämpötila { get; set; }
        public bool Linkous { get; set; }

        //konstruktorit
        public Pesukone()
        {
        }
        public Pesukone(string malli)
        {
            Malli = malli;
        }
        public Pesukone(string malli, string väri, int lämpötila)
        {
            Malli = malli;
            Väri = väri;
            Lämpötila = lämpötila;
        }

        //Toiminnot

        public void On()
        {
            OnOff = true;
        }
        public void Off()
        {
            OnOff = false;
        }
        public void LinkousOn()
        {
            Linkous = true;
        }
        public void LinkousOff()
        {
            Linkous = false;
        }
        
    }
}
