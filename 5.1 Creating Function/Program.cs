using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_Creating_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Method";
            BodyTempC();
            Console.WriteLine("Farenheit:\t " + BodyTempF() + "°F");
            Console.WriteLine("Kelvin:\t\t " + BodyTempK() + "K");
            Console.ReadKey();
        }
        static void BodyTempC()
        {
            Console.WriteLine("Body Temperature...");
            Console.WriteLine("Centigrade:\t37°C");
        }
        static double BodyTempF()
        {
            double temperature = 98.6;
            return temperature;
        }
        static int BodyTempK()
        {
            int temperature = 310;
            return temperature;
        }
    }
}
