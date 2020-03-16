using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_Initializing_Class_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Constructor";

            Cat tigger = new Cat();
            string tagT = String.Format("{0} is a {1} year old {2} cat",
                tigger.GetName(), tigger.GetAge(), tigger.GetColor());
            Console.WriteLine(tagT + tigger.Cry());

            Cat smokey = new Cat();
            smokey.SetName("Smokey");
            smokey.SetAge(2);
            smokey.SetColor("Grey");

            string tagS = String.Format("{0} is a {1} year old {2} cat",
                smokey.GetName(), smokey.GetAge(), smokey.GetColor());
            Console.WriteLine(tagS + smokey.Cry());
            Console.ReadKey();

        }
        public class Cat
        {
            private string name, color;
            private int age;

            public Cat()
            {
                name = "Tigger";
                age = 3;
                color = "Brown";
            }
            public void SetName(string name) { this.name = name; }
            public void SetAge(int age) { this.age = age; }
            public void SetColor(string color) { this.color = color; }

            public string GetName() { return name; }
            public int GetAge() { return age; }
            public string GetColor() { return color; }

            public string Cry() { return "\nMeow! Meow!\n"; }
        }
    }
}
