using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5_Iterating_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ForEach";

            string[] websites = new string[5] { "Google", "Youtube", "Facebook","Baidu", "Yahoo!" };
            Console.WriteLine("Popular Websites: ");

            int rank = 1;
            foreach(string site in websites)
            {
                Console.WriteLine("Position: " + rank + "\t" + site);
                rank++;
            }

            Dictionary<string, string> BookList = new Dictionary<string, string>();
            BookList.Add("Stuart Yarnold", "Arduino");
            BookList.Add("Nick Vandome", "Windows 10");
            BookList.Add("Mike McGrath", "Java");

            Console.WriteLine("\nPopular Books: ");
            foreach(KeyValuePair<string, string> book in BookList)
            {
                Console.WriteLine("Author: " + book.Key + "\tTitle: " + book.Value + " in easy steps");
            }

            Console.ReadKey();
        }
    }
}
