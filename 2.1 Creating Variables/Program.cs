using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Creating_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Variables";
            char letter;    letter = 'A';   //Declared then initialized.
            int number;     number = 100;   //Declared then initialized.
            float body = 98.6f;             //Declared and initialized.
            double pi = 3.14159;            //Declared and initialized.
            decimal sum = 1000.00m;         //Declared and initialized.
            bool flag = false;              //Declared and initialized.
            string text = "C# Is Fun";      //Declared and initialized.

            Console.WriteLine("char letter:\t" + letter);
            Console.WriteLine("int number:\t" + number);
            Console.WriteLine("float body:\t" + body);
            Console.WriteLine("double pi:\t" + pi);
            Console.WriteLine("decimal sum:\t" + sum);
            Console.WriteLine("bool flag:\t" + flag);
            Console.WriteLine("string text:\t" + text);
            Console.ReadKey();
        }
    }
}
