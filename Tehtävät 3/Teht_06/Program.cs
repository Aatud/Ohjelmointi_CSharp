using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_06
{
    class Program
    {
        static void Main(string[] args)
        {
            CD bobdylan = new CD();
            bobdylan.Artist = "Bob Dylan";
            bobdylan.AlbumName = "Creating the Dream";
            bobdylan.Genre = "Jazz";
            bobdylan.ReleaseYear = 1945;
            bobdylan.Price = 15.00;

            Console.Write(bobdylan.ToString());
            Console.ReadLine();
        }
    }
}
