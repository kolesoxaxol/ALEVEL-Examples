using System;

namespace Example12
{
    class Program
    {
        //А в этом случае?
        //Ответ: Int[]. Компилятор при определении вызова не использует текущее значение, а выбирает наиболее «специфический» конструктор. Нужно явно указать указать тип, если есть желание вызвать конструктор object: new Test((object)null);
        public class Test
        {
            public Test(object obj) { Console.WriteLine("object"); }
            public Test(int[] obj) { Console.WriteLine("int[]"); }
        }
        static void Main(string[] args)
        {
            Test t = new Test(null);
        }
    }
}
