using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_CompileTime_Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool flag = true;
            //IConvertible convertible = flag;
            //char letter = convertible.ToChar(null);
            
            int[] nums = new int[10];
            for (int i = 1; i < 20; i++) { nums[i] = i; }

        }
    }
}
