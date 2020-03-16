using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7._3_Reading_Text_and_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ReadText";

            string path = "C:\\Users\\Sheila\\Desktop\\Others\\word.txt";
            if (File.Exists(path))
            {
                try
                {
                    string text = File.ReadAllText(path);
                    Console.WriteLine("File Read: " + path + "\n");
                    Console.WriteLine(text + "\n");

                    string[] lines = File.ReadAllLines(path);
                    int num = 1;
                    foreach(string line in lines)
                    {
                        Console.WriteLine(num + " : " + line);
                        num++;
                    }
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                Console.WriteLine("File Not Found: " + path);
            }
            Console.ReadKey();

        }
    }
}
