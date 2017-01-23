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
            sana = Console.ReadLine();
            string anas = "";
            int q = sana.Length - 1;
            for (int i = 0; i < sana.Length; i++)
            {
                //anas = sana[q].Join.ToString();
                anas = String.Join("", sana[q]);
                Console.Write(sana[q]);
                q--;
            }
            if (sana == anas)
            {
                Console.WriteLine("Sana on palidromi");
            }
            else {Console.WriteLine("Sana ei ole palidromi");}
            Console.Write(anas+"\n" + sana);
            Console.ReadLine();
            
        }
    }
}
