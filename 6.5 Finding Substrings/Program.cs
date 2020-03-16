using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5_Finding_Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Substring";
            string text = "My dog is a cute dog";
            Console.WriteLine(text + "\tLength: " + text.Length);

            Console.Write("\nPlease Enter A Substring To Seek: ");
            string sub = Console.ReadLine();

            char[] arr = new char[sub.Length];
            sub.CopyTo(0, arr, 0, sub.Length);

            int pos = text.IndexOf(sub);
            Report(pos, sub);
            pos = text.LastIndexOf(sub);
            Report(pos, sub);

            pos = text.IndexOfAny(arr);
            Report(pos, text.Substring(pos, 1));
            pos = text.LastIndexOfAny(arr);
            Report(pos, text.Substring(pos, 1));

            Console.ReadKey();
        }
        static void Report(int pos, string sub)
        {
            if (pos != -1)
            {
                Console.WriteLine("'" + sub + "' Found At " + pos);
            }
            else { Console.WriteLine("'" + sub + "' Not Found!"); }
        }
    }
}
