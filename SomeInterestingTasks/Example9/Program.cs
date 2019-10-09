using System;

namespace Example9
{
    class Program
    {
        // А что будет выведено в результате такого цикла?
        // Ответ: цикл бесконечный по определению - все значения int меньше или равны int.MaxValue.

        static void Main(string[] args)
        {
            int end = int.MaxValue;
            int begin = end - 100;
            int counter = 0;

            for (int i = begin; i <= end; i++)
                counter++;

            Console.WriteLine(counter);
            Console.WriteLine("Hello World!");
        }
    }
}
