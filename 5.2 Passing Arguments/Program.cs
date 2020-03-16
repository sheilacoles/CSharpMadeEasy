using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_Passing_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parameter";

            double weight;
            string num;

            num = GetWeight(out weight);
            Console.WriteLine(num + " lb = " + LbToKg(weight) + " kg");
            KgToLb(ref weight);
            Console.WriteLine(num + " kg = " + weight + " lb");
            Console.ReadKey();
        }
        static string GetWeight(out double weight)
        {
            weight = 10;
            return "Ten";
        }
        static double LbToKg(double pounds = 5)
        {
            return (pounds * 0.45359237);
        }
        static void KgToLb(ref double weight)
        {
            weight = (weight / 0.45359237);
        }
    }

}
