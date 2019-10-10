using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            // aнонимные методы могут использовать внешнии переменные и возвращать значения , но должны соответсвовать делегату
            int z = 5;
            Operation operation = delegate (int x, int y)
            {
                return x + y + z;
            };
            int d = operation(4, 5);
            Console.WriteLine(d);       // 14
            Console.Read();
        }
    }
}
