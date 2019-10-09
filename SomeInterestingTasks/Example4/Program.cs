using System;

namespace Example4
{
    // Что будет выведено на экран при выполнении приведенного ниже кода?
    //Ответ: 97 Типы операндов не совпадают и компилятор приводит переменные к общему совместимому типу Int32.
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            int b = 0;
            Console.WriteLine(true ? a : b);
        }
    }
}
