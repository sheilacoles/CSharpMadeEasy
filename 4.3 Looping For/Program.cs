﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_Looping_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ForLoop";

            for(int i=1; i < 4; i++)
            {
                Console.WriteLine("Loop Interation: " + i);
                for(int j = 1; j < 4; j++)
                {
                    Console.WriteLine("\tInner Loop Iteration: " + j);
                }
            }
            Console.ReadKey();
        }
    }
}
