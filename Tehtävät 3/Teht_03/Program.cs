using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisio tv = new Televisio();

            Console.WriteLine("Televisio:");
            Console.WriteLine("- Malli : " + tv.Malli);
            Console.WriteLine("- Väri : " + tv.Väri);
            Console.WriteLine("- Päällä : " + tv.OnOff);
            Console.WriteLine("- Volume Level : " + tv.Volume);
            Console.WriteLine("- Mute : " + tv.Mute);
            Console.ReadLine();

            tv.Malli = "LG";
            tv.Väri = "Valkoinen";
            tv.On();
            tv.AddVolume();
            tv.AddVolume();
            tv.LessVolume();
            tv.MuteYes();

            Console.WriteLine("Televisio:");
            Console.WriteLine("- Malli : " + tv.Malli);
            Console.WriteLine("- Väri : " + tv.Väri);
            Console.WriteLine("- Päällä : " + tv.OnOff);
            Console.WriteLine("- Volume Level : " + tv.Volume);
            Console.WriteLine("- Mute : " + tv.Mute);
            Console.ReadLine();
        }
    }
}
