using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Assigning_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assign";
            int a;
            int b;

            Console.Write("Assign Values: ");
            Console.Write("\t a = " + (a = 8));
            Console.WriteLine("\t b = " + (b = 4));

            Console.Write("\nAdd & Assign: ");
            Console.WriteLine("\t\t a += b (8 += 4)\t a = " + (a += b));

            Console.Write("\nSubtract & Assign: ");
            Console.WriteLine("\t a -= b (12 -= 4)\t a = " + (a -= b));

            Console.Write("\nMultiply & Assign: ");
            Console.WriteLine("\t a *= b (8 *= 4)\t a = " + (a *= b));

            Console.Write("\nDivide & Assign: ");
            Console.WriteLine("\t a /= b (32 /= 4)\t a = " + (a /= b));

            Console.Write("\nModulus & Assign: ");
            Console.WriteLine("\t a %= b (8 %= 4)\t a = " + (a %= b));
            Console.ReadKey();                              
        }
    }
}
