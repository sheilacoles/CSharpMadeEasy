using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_Appending_To_A_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AppendText";
            string path = "C:\\Users\\Sheila\\Desktop\\Others\\oscar.txt";
            string[] poem = new string[]
            {
                "\tIn Debtors' Yard the stones are hard",
                "\tAnd the dripping wall is high"
            };
            string attrib = "\r\n\tThe Ballad of Reading Gaol";
            attrib += "(Oscar Wilde 1898)";

            if (File.Exists(path))
            {
                File.AppendAllText(path, attrib);
                Console.WriteLine("Appended to File: " + path);
            }
            else
            {
                try
                {
                    File.WriteAllLines(path, poem);
                    Console.WriteLine("File Written: " + path);
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
