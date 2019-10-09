using System;

namespace TaslExamples
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(GetSomeResult(10000));
        //}


        //static long GetSomeResult(long someValue)
        //{
        //    long value1 = 10 * 1000 * 10000 * someValue;
        // тут компилятор считает что все параметры это инты и он не смотрит на конкретное значение а смотрит на то что умножается 4 инта
        // здесь все литералы имеют тип int, их произведение, соответственно, тоже, а overflow в констатных выражениях всегда проверяется на этапе компиляции.
        //    long value2 = 10 * 1000 * 10000 * 10000; 

        //    return value2 / value1;
        //}
    }
}
