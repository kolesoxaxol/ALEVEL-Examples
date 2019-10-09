using System;

namespace Example_6
{
    class Program
    {

        //Что следует ожидать на экране?
        //Ответ: ABC 198. Конкатенация для символов не определена, поэтому будут получены числовые значения, затем просуммированы.
        static void Main(string[] args)
        {
            Console.WriteLine("A" + "B" + "C");
            Console.WriteLine('A' + 'B' + 'C');
            Console.ReadLine();
        }
    }
}
