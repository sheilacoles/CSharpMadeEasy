using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Overloading_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Overload";
            double num;
            double area;

            Console.Write("Please Enter Dimension in Feet: ");
            num = Convert.ToDouble(Console.ReadLine());

            area = ComputeArea(num);
            Console.WriteLine("\nCircle:\t\tArea = " + area + " sq.ft.");

            area = ComputeArea(num, num);
            Console.WriteLine("Square:\t\tArea = " + area + " sq.ft.");

            area = ComputeArea(num, num, 'T');
            Console.WriteLine("Triangle:\tArea = " + area + " sq.ft.");
            Console.ReadKey();           
        }
        static double ComputeArea(double width)
        {
            double radius = width / 2;
            return ((radius * radius) * 3.141593);
        }
        static double ComputeArea(double width, double height)
        {
            return (width * height);
        }
        static double ComputeArea(double width, double height, char letter)
        {
            return ((width / 2) * height);
        }

    }
}
