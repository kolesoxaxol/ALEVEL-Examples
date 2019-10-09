using System;

namespace Example10
{
    class Program
    {
        //А что будет выведено в результате такого цикла?
        // Ответ: бесконечный цикл. Для таких больших значений float нет разницы между begin + 1 и begin + 10. Вообще, использовать не целые счетчики циклов - моветон и дорога в ад.
        static void Main(string[] args)
        {
            float begin = 1000000000;
            int counter = 0;

            for (float i = begin; i < (begin + 10); i++)
                counter++;

            Console.WriteLine(counter);
     
        }
    }
}
