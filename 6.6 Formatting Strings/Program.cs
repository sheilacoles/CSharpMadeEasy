﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6_Formatting_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Format";

            double sum = 2500;
            Console.WriteLine("Currency String: " + sum.ToString("C"));
            Console.Write(String.Format("\nGeneral:\t {0:G}", sum));
            Console.Write(String.Format("\nFixed Point:\t {0:F}", sum));
            Console.Write(String.Format("\nNumber:\t {0:N}", sum));
            Console.Write(String.Format("\nCurrency:\t {0:C}", sum));

            sum /= 1000;
            Console.Write(String.Format("\nPercentage:\t {0:P}", sum));
            Console.Write(String.Format("\nZero Padded:\t {0:00.0000}\n", sum));

            string data = "Mike,McGrath,Author";
            string[] items = data.Split(',');
            foreach(string item in items)
            {
                Console.Write(String.Format("\n* {0}", item));
            }
            Console.ReadKey();
        }
    }
}
