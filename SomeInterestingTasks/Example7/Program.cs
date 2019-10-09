using System;

namespace Example7
{
    public class A { public static int x = B.y + 1; }
    public class B { public static int y = A.x + 1; }
    class Program
    {
        // Циклическая инициализация полей? Интересненько, а в результате что будет на консоли выведено?
        // Ответ: A.x = 2 B.y = 1. Тут все просто: вызывается конструктор A, затем конструктор B, но т.к.не определено значение A.x, то для используется 0 в конструкторе B.
        static void Main(string[] args)
        {
            Console.WriteLine("A.x = " + A.x);
            Console.WriteLine("B.y = " + B.y);
       
        }
    }
}
