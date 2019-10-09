using System;

namespace Example3
{
    //А почему следующий код выводит False?
    // Ответ: этот вопрос - ловушка для людей ожидающих подвоха. Описанное поведение можно воспроизвести опледелив класс Test следующим образом: public class Test { public bool Equals(Test t) { return false; } }. Общее правило, которое подчеркивает эта задача - не стоит переопределять поведение методов с одинаковыми названиями - это обязательно запутает пользователей кода.
    class Program
    {
        public class Test
        {
            public bool Equals(Test t) { return false; }
        }
        static void Main(string[] args)
        {
            Test t = new Test();
            Console.WriteLine(t.Equals(t));
        }
    }
}
