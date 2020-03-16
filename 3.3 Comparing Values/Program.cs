using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Comparing_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Comparison";
            int nil = 0, num = 0, max = 1;
            char cap = 'A', low = 'a';

            Console.Write("Equality:");
            Console.Write("\t(0 == 0) : " + (nil == num));
            Console.WriteLine("\n\t\t(A == a) : " + (cap == low));

            Console.Write("\nInequality:");
            Console.WriteLine("\t(0 != 1) : " + (nil != max));

            Console.Write("\nGreater:");
            Console.WriteLine("\t(0 > 1) : " + (nil > max));

            Console.Write("Less:");
            Console.WriteLine("\t\t(0 < 1) : " + (nil < max));

            Console.Write("\nGreater/Equal:");
            Console.WriteLine("\t(0 >= 0) : " + (nil >= num));

            Console.Write("Less/Equal:");
            Console.WriteLine("\t(1 <= 0) : " + (max <= nil));

            Console.ReadKey();



        }
    }
}
