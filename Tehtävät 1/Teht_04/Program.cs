using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Anna ikä > ");
            age = int.Parse(Console.ReadLine());

            if (age < 18) Console.Write("Alaikäinen");
            else if (age >= 18 && age <= 65) Console.Write("Aikuinen");
            else if (age > 65) Console.Write("Seniori");
            Console.ReadLine();
        }
    }
}
