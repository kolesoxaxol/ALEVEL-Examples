using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Какое значение присвоено x, если приведенный ниже код выводит False ?


            float x = 0.42F;
            Console.Write(x == x);

            // ответ  float.NaN;
            Console.ReadLine();
        }
    }
}
