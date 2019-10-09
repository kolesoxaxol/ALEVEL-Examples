using System;
using System.Collections.Specialized;

namespace Example5
{
    class Program
    {   //А в этом случае, что будет на экране?
        //Ответ: Существует. Сначала работает оператор +, после этого сравнивается с null строка "Это test".
        static void Main(string[] args)
        {
            NameValueCollection col = new NameValueCollection();
            Console.WriteLine("Элемент test " + col["test"] != null ? "Существует!" : "Не существует!");
        }
    }
}
