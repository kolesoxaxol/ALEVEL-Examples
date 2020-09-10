using System;
using TemplateMethodSample.Food;

namespace TemplateMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotDog = new HotDog();
            var hamburger = new Hamburger();

            Console.WriteLine("\nHotDog:");
            hotDog.Prepare();
            Console.WriteLine("\nHamburger:");
            hamburger.Prepare();

            Console.ReadLine();
        }
    }
}
