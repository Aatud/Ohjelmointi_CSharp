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
            string sana;
            
            Console.Write("Anna sana jonka haluat testata > ");
            sana = Convert.ToString(Console.ReadLine());
            char[] anas = sana.ToCharArray();
            Array.Reverse(anas);
            string joku = new string(anas);
            if (sana == joku)
            {
                Console.WriteLine("Sana on palidromi");
            }
            else {Console.WriteLine("Sana ei ole palidromi");}
            Console.Write(joku+"\n" + sana);
            Console.ReadLine();
            
        }
    }
}
