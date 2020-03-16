using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7_Providing_Capability_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Capability";
            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();
            Caller call = new Caller();
            call.Describe(joey);
            call.Describe(lola);
            Console.ReadKey();
        }
        public abstract class Bird
        {
            public abstract void Talk();
            public abstract void Fly();
        }
        public sealed class Pigeon : Bird
        {
            public override void Talk()
            {
                Console.WriteLine("Pigeon Says: Coo! Coo!");
            }
            public override void Fly()
            {
                Console.WriteLine("A Pigeon Flies Away...");
            }
        }
        public sealed class Chicken : Bird
        {
            public override void Talk()
            {
                Console.WriteLine("Chicken Says: Cluck! Cluck!");
            }
            public override void Fly()
            {
                Console.WriteLine("I'm A Chicken - I Can't Fly");
            }
        }
        public sealed class Caller
        {
            public void Describe(Bird obj)
            {
                obj.Talk();
                obj.Fly();
            }
        }


    }
}
