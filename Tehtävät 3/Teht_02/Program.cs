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
            Pesukone rosenlew = new Pesukone();
            rosenlew.Malli = "Rosenlew";
            rosenlew.Väri = "Valkoinen";
            rosenlew.OnOff = true;
            rosenlew.Lämpötila = 90;

            Console.WriteLine("Pesukone:");
            Console.WriteLine("- Malli : " + rosenlew.Malli);
            Console.WriteLine("- Väri : " + rosenlew.Väri);
            Console.WriteLine("- Päällä : " + rosenlew.OnOff);
            Console.WriteLine("- Lämpötila : " + rosenlew.Lämpötila);
            Console.WriteLine("- Linkous : " + rosenlew.Linkous);
            Console.ReadLine();

            //sammuttaa kiukaan
            rosenlew.Off();
            Console.WriteLine("Pesukone:");
            Console.WriteLine("- Malli : " + rosenlew.Malli);
            Console.WriteLine("- Väri : " + rosenlew.Väri);
            Console.WriteLine("- Päällä : " + rosenlew.OnOff);
            Console.WriteLine("- Lämpötila : " + rosenlew.Lämpötila);
            Console.WriteLine("- Linkous : " + rosenlew.Linkous);
            Console.ReadLine();

            Pesukone electrolux = new Pesukone("Electrolux");
            Console.WriteLine("Pesukone:");
            Console.WriteLine("- Malli : " + electrolux.Malli);
            Console.WriteLine("- Väri : " + electrolux.Väri);
            Console.WriteLine("- Päällä : " + electrolux.OnOff);
            Console.WriteLine("- Lämpötila : " + electrolux.Lämpötila);
            Console.WriteLine("- Linkous : " + electrolux.Linkous);
            Console.ReadLine();

            Pesukone bosch = new Pesukone("bosch", "Musta", 40);
            Console.WriteLine("Pesukone:");
            Console.WriteLine("- Malli : " + bosch.Malli);
            Console.WriteLine("- Väri : " + bosch.Väri);
            Console.WriteLine("- Päällä : " + bosch.OnOff);
            Console.WriteLine("- Lämpötila : " + bosch.Lämpötila);
            Console.WriteLine("- Linkous : " + bosch.Linkous);
            Console.ReadLine();
        }
    }
}
