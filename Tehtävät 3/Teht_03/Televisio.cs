using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_03
{
    class Televisio
    {
        //Ominaisuudet
        public string Malli { get; set; }
        public string Väri { get; set; }
        public bool OnOff { get; set; }
        public int Volume { get; set; }
        public bool Mute { get; set; }

        //Konstruktori
        public Televisio()
        {
            Malli = "Panasonic";
            Väri = "musta";
            OnOff = false;
            Volume = 0;
            Mute = false;
        }

        // Toiminnot
        public void On()
        {
            OnOff = true;
        }
        public void Off()
        {
            OnOff = false;
        }
        public void AddVolume()
        {
            Volume += 5;
        }
        public void LessVolume()
        {
            Volume -= 5;
        }
        public void MuteYes()
        {
            Mute = true;
        }
        public void MuteNo()
        {
            Mute = false;
        }
    }
}
