using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Branching_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "IfElse";

            Console.Write("Please Enter A Number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thanks. Now Enter A Letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            if (num >= 6)
            {
                Console.WriteLine("\nNumber Exceeds 5");
                if(letter == 'C')
                {
                    Console.WriteLine("Letter is 'C'");
                }
            }
            else
            {
                Console.WriteLine("\nNumber is 5 or Less");
            }
            Console.ReadKey();
        }
    }
}
