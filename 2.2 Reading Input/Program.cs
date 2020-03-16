using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Reading_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Input";
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "!");

            Console.Write("Please Enter A Number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Another Number: ");
            double sum = num + Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total = " + sum);

            Console.ReadKey();
        }
    }
}
