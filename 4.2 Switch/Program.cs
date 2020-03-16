using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Switch";
            Console.Write("Enter Number: ");

            int num = Convert.ToInt32(Console.ReadLine());
            string day;

            switch (num)
            {
                case 1: day = "Monday"; break;
                case 2: day = "Tuesday"; break;
                case 3: day = "Wednesday"; break;
                case 4: day = "Thursday"; break;
                case 5: day = "Friday"; break;
                default: day = "Weekend"; break;
            }

            Console.WriteLine("Day " + num + " : " + day);
            Console.ReadKey();            
        }
    }
}
