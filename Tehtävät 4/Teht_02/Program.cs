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
            Vahvistin vahvstin = new Vahvistin();
            bool result;

            do
            {
                
                Console.Write("Give a new volume value (0-100) > ");
                
                string line = Console.ReadLine();
                int volume;
                result = int.TryParse(line, out volume);
                if (result)
                {
                    if (volume < 100 && volume > 0)
                    {
                        vahvstin.Volume = volume;
                        Console.WriteLine("Amplifier volume is set to : " + vahvstin.Volume);
                    }
                    vahvstin.Volume = volume;                                        
                }                
            }
            while (result);
        }
    }
}
