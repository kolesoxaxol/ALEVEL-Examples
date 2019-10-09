using System;
using System.Threading;

namespace Example15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello ");
                return;
            }
            finally { Console.WriteLine("Goodbye "); }
            Console.WriteLine("world!");
            //Ответ: Hello Goodbye. Finally выполняется даже если выполнение прервано по return.

            try
            {
                Console.WriteLine("Hello ");
                Thread.CurrentThread.Abort();
            }
            finally { Console.WriteLine("Goodbye "); }
            Console.WriteLine("world!");
            //Ответ: Hello Goodbye. Abort выбрасывает исключение ThreadAbortException, которое обрабатывается finally, затем выполнение прерывается.


            try
            {
                Console.WriteLine("Hello ");
                System.Environment.Exit(0);
            }
            finally { Console.WriteLine("Goodbye "); }
            Console.WriteLine("world!");

            //Ответ: Hello.Выполнение программы прерывается в точке вызова System.Environment.Exit(0) и управление передается ОС. Слишком жестко наступаем песне на горло.
        }
    }
}
