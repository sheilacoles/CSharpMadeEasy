using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_Inheriting_Class_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inheritance";

            Rectangle rect = new Rectangle();
            Triangle cone = new Triangle();

            rect.SetValues(4, 5);
            cone.SetValues(4, 5);

            Console.WriteLine("Rectangle Area: " + rect.area());
            Console.WriteLine("Triangle Area: " + cone.area());
            Console.ReadKey();

        }
        public class Polygon
        {
            protected int width, height;
            public void SetValues(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }
        public class Rectangle : Polygon
        {
            public int area() { return (width * height); }
        }
        public class Triangle : Polygon
        {
            public int area() { return ((width * height) / 2); }
        }
    }
}
