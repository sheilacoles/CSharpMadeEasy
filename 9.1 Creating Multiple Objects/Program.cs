using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Creating_Multiple_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Objects";

            Dog fido = new Dog();
            fido.SetValues("Fido", 3, "Brown");
            string tagF = String.Format("{0} is a {1} year old {2} dog",
                fido.GetName(), fido.GetAge(), fido.GetColor());
            Console.WriteLine(tagF + fido.Bark());

            Dog lucy = new Dog();
            lucy.SetValues("Lucy", 2, "Grey");
            string tagL = String.Format("{0} is a {1} year old {2} dog",
                lucy.GetName(), lucy.GetAge(), lucy.GetColor());
            Console.WriteLine(tagL + lucy.Bark());

            Console.ReadKey();
        }
        public class Dog
        {
            private string name, color;
            private int age;

            public void SetValues(string name, int age, string color)
            {
                this.name = name;
                this.age = age;
                this.color = color;
            }
            public string GetName()
            {
                return name;
            }
            public int GetAge()
            {
                return age;
            }
            public string GetColor()
            {
                return color;
            }
            public string Bark()
            {
                return "\nWoof! Woof!\n";
            }
        }
    }
}
