using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_06
{
    class CD
    {
        //Ominaisuudet
        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public double Price { get; set; }
        
        
        //Toiminnallisuudet
        public void PrintData()
        {
            Console.WriteLine("CD: ");
            Console.WriteLine("- Artist: " + Artist);
            Console.WriteLine("- Album: " + AlbumName);
            Console.WriteLine("- Genre: " + Genre);
            Console.WriteLine("- Release year: " + ReleaseYear);
            Console.WriteLine("- Price: " + Price);
        }

        public override string ToString()
        {
            return ("CD:\n- Artist: " + Artist + "\n- Album: " + AlbumName + "\n- Genre: " + Genre + "\n- Release year: " + ReleaseYear + "\n- Price: " + Price).ToString();
        }
    }
}
