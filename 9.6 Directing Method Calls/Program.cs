using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6_Directing_Method_Calls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Override";

            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();
            Describe(joey);
            Describe(lola);
            Console.ReadKey();
        }
        static void Describe(Bird obj)
        {
            obj.Talk();
            obj.Fly();
        }
        public class Bird
        {
            public virtual void Talk()
            {
                Console.WriteLine("A Bird Talks...");
            }
            public virtual void Fly()
            {
                Console.WriteLine("A Bird Flies...\n");
            }
        }
        public class Pigeon : Bird
        {
            public override void Talk()
            {
                Console.WriteLine("Pigeon Says: Coo! Coo!");
            }
            public override void Fly()
            {
                Console.WriteLine("Pigeon Flies Away...");
                base.Fly();
            }
        }
        public class Chicken : Bird
        {
            public override void Talk()
            {
                Console.WriteLine("Chicken Says: Cluck! Cluck!");
            }
            public override void Fly()
            {
                Console.WriteLine("I'm A Chicken - I Can't Fly");
                base.Fly();
            }
        }
    }
}
