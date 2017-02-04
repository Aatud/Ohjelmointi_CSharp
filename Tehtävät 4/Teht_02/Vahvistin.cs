using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_02
{
    class Vahvistin
    {
        private const int minVolume = 0;
        private const int maxVolume = 100;
        private int volume = 50;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < minVolume)
                {
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum : "+ minVolume);
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("Too much volume - Amplifier volume is set to maximum : "+ maxVolume);
                }
                else if (value < maxVolume || value > minVolume)
                {
                    volume = value;
                }
            }
        }
    }
}
