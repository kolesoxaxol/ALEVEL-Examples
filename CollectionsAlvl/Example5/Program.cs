using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Program
    {
        private static IEnumerable<int> GetOddNumbers()
        {
            var previous = 0;
            while (true)
                if (++previous % 2 != 0)
                    yield return previous;
        }

        static void Main(string[] args)
        {
            foreach (var number in GetOddNumbers())
                Console.WriteLine(number);
        }
    }
}
