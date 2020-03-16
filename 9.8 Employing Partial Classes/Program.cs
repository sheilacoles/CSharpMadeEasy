using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8_Employing_Partial_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parts";
            Sailboat boat = new Sailboat("Laser", "Classic");
            boat.Describe();
            Console.ReadKey();
        }
    }
    public partial class Sailboat
    {
        public void Describe()
        {
            Console.WriteLine("Sailboat: {0} {1}", make, model);
        }
    }
}
