using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4_Refactoring_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Refactor";

            ComputeFactorials(1, 8);
            Console.ReadKey();
        }
        static int Factorial (int num)
        {
            /*int result;
            if (num == 1)
            {
                result = 1;
            }
            else
            {
                result = (Factorial(num - 1) * num);
            }
            return result;*/
            return(num==1)?1:(Factorial(num-1)*num); 
        }
        static void ComputeFactorials(int num, int max)
        {
            while (num <= max)
            {
                Console.Write("Factorial Of " + num + " : ");
                Console.WriteLine(Factorial(num));
                num++;
            }
        }   
    }
}
