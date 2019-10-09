using System;

namespace Example8
{
    //Инкремент, инкремент, а что же будет?
    //Ответ: 0. Подлый вопрос, поскольку тут внимание отвлекает ++. Но, на деле, оператор ++ возвращает значение переменной до инкрементации, поэтому j сохраняет исходное значение. (код, по сути, аналогичен z = j; j = j + 1; j = z ).
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;

            for (int i = 0; i < 10; i++)
            {
                j = j++;
            }

            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
