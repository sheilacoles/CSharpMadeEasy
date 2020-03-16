using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6_Setting_Precedence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Precedence";
            int sum;

            sum = 1 + 4 * 3;
            Console.WriteLine("Default Order:\t" + sum);

            sum = (1 + 4) * 3;
            Console.WriteLine("Forced Order:\t" + sum);

            sum = 7 - 4 + 2;
            Console.WriteLine("\nDefault Direction:\t" + sum);

            sum = 7 - (4 + 2);
            Console.WriteLine("Forced Direction:\t" + sum);
            Console.ReadKey();

        }
    }
}
