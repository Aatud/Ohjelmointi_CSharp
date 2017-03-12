using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_03
{
    class Lotto
    {
        Random rand;
        //public List<int> numerot { get; set; }
        public Lotto()
        {
            rand = new Random();
        }
        public List<int> Gen()
        {
            int arvottunumero = 0;
            List<int> numerot = new List<int>();
            for (int i=0; i < 7; i++)
            {
                arvottunumero = rand.Next(1, 39);
                if (numerot.Contains(arvottunumero))
                {
                    i--;
                }
                else numerot.Add(arvottunumero);                
            }
            return numerot;
        }
    }
}
