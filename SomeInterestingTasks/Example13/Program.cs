using System;
using System.Collections.Generic;
using System.Linq;

namespace Example13
{
    // Что будут выведено на экран в результате выполнения кода приведенного ниже?
    // Ответ: 12345. Делегат, переданный методу FindAll вызывается для каждого элемента. Вопрос на внимательность, поскольку делегат используется как фильтрующая функция, применяемая к каждому элементу.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            var x = list.GroupBy(i => { Console.Write(i); return i; });
            var y = list.ToLookup(i => { Console.Write(i); return i; });
        }
    }
}
