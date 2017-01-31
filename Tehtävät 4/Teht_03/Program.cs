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
            Employee employee = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 2500;
            Console.WriteLine(employee.ToString());


            Boss boss = new Boss();
            boss.Name = "Bob Bosi";
            boss.Profession = "Boss";
            boss.Salary = 4500;
            boss.Car = "Lada";
            boss.Bonus = 4000;
            Console.WriteLine(boss.ToString());


        }
    }
}
