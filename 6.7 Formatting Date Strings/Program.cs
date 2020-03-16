using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7_Formatting_Date_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DateFormat";
            DateTime now = DateTime.Now;
            Console.Write("Current Date And Time: " + now);

            Console.Write("\nDay Name: " + now.DayOfWeek);
            Console.Write("\nDate Only: " + now.ToShortDateString());
            Console.Write("\nTime Only: " + now.ToShortTimeString());

            now = now.AddYears(4);
            Console.Write("\n\nFuture Date: " + now);

            DateTime dt = new DateTime(2017, 7, 4, 8, 15, 30);
            Console.Write("\n\nSet Date And Time: {0:f}", dt);
            Console.Write("\nDay Name: {0:dddd}", dt);
            Console.Write("\nLong Date: {0:D}", dt);
            Console.Write("\nLong Time: {0:T}", dt);
            Console.ReadKey();
        }
    }
}
