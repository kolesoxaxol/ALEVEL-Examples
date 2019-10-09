using System;

namespace Example11
{
    //Какой же метод выберет компилятор?

    class Program
    {
        class A { public void Test(int n) { Console.WriteLine("A"); } }
        class B : A { public void Test(double n) { Console.WriteLine("B"); } }
        static void Main(string[] args)
        {
            B b = new B();
            b.Test(5);
        }
    }
}
