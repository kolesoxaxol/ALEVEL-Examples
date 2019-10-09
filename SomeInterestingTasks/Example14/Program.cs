using System;
using System.Collections.Generic;
using System.Linq;

namespace Example14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            var x = list.GroupBy(i => { Console.Write(i); return i; });
            var y = list.ToLookup(i => { Console.Write(i); return i; });

            //Ответ: 123.Выполнение GroupBy отложено до обращения к результату. Вывод 123123 будет если дописать, например, строку var z = x.ToArray();
        }
    }
}
