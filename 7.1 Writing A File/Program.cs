using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _7._1_Writing_A_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WriteText";

            string path = "C:\\Users\\Sheila\\Desktop\\Others\\poem.txt";
            string poem = "\r\n\tI never saw a man who looked";
            poem += "\r\n\tWith such a wistful eye";
            poem += "\r\n\tUpon that little tent of blue";
            poem += "\r\n\tWhich prisoners call the sky";

            if (File.Exists(path))
            {
                Console.WriteLine("File Already Exists: " + path);
            }
            else
            {
                try
                {
                    File.WriteAllText(path, poem);
                    Console.WriteLine("File Written: " + path);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
