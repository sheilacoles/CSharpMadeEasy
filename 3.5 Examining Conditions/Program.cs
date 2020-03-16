using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5_Examining_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Condition";
            int a = 8, b = 3;

            string verb = (a != 1) ? "are" : "is";
            Console.WriteLine("There " + verb + " " + a);

            string parity = (a % 2 != 0) ? "Odd" : "Even";
            Console.WriteLine("\n" + a + " is " + parity);

            parity = (b % 2 != 0) ? "Odd" : "Even";
            Console.WriteLine(b + " is " + parity);

            int max = (a > b) ? a : b;
            Console.WriteLine("\nMaximum is " + max);
            Console.ReadKey();
        }
    }
}
