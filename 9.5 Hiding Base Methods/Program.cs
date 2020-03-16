using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5_Hiding_Base_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Base";
            Man henry = new Man();
            Hombre enrique = new Hombre();
            henry.Speak();
            henry.Speak("It's a beautiful evening");
            enrique.Speak("Hola...");
            ((Man)enrique).Speak("Es una tarde hermosa");
            Console.ReadKey();
        }
        public class Man
        {
            public void Speak() { Console.Write("Hello: "); }
            public void Speak(string message)
            {
                Console.WriteLine(message + "!\n");
            }
        }
        public class Hombre : Man
        {
            public new void Speak(string message)
            {
                base.Speak();
                Console.WriteLine(message);
            }
        }
    }
}
