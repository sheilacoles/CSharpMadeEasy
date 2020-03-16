using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_Assessing_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Logic";
            bool yes = true, no = false;

            Console.Write("AND Logic:");
            Console.WriteLine("\t(yes && yes) : " + (yes && yes));
            Console.WriteLine("\t\t(yes && no) : " + (yes && no));
            Console.WriteLine("\t\t(no && no) : " + (no && no));

            Console.Write("\nOR Logic:");
            Console.WriteLine("\t(yes || yes) : " + (yes || yes));
            Console.WriteLine("\t\t(yes || no) : " + (yes || no));
            Console.WriteLine("\t\t(no || no) : " + (no || no));

            Console.Write("\nNOT Logic:");
            Console.Write("\tyes = " + yes);
            Console.WriteLine("\t!yes = " + !yes);
            Console.Write("\t\tno = " + no);
            Console.Write("\t!no = " + !no);

            Console.ReadKey();
        }
    }
}
