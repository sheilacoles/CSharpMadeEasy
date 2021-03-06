﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7._4_Streaming_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WriteStream";
            string path = "C:\\Users\\Sheila\\Desktop\\Others\\robert.txt";
            string[] poem = new string[]
            {
                "\tThis truth finds honest Tam o'Shanter",
                "\tAs he from Ayr one night did canter",
                "\tOld Ayr, which never a town surpasses",
                "\tFor honest men and bonnie lasses."
            };
            string attrib = "\r\n\tTam O'Shanter(Rober Burns 1790)";
            try
            {
                using(StreamWriter writer = new StreamWriter(path))
                {
                    foreach(string line in poem)
                    {
                        writer.WriteLine(line);
                    }
                }
                using (StreamWriter writer=new StreamWriter(path, true))
                {
                    writer.WriteLine(attrib);
                    Console.WriteLine("File Written: " + path);
                }
            }
            catch (Exception error)
            { Console.WriteLine(error.Message); }
            Console.ReadKey();
        }
    }
}
