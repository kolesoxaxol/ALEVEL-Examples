using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        private static IEnumerable<int> GetNumbers()
        {
            var number = 0;
            while (true)
            {
                if (number > 10)
                    yield break;

                yield return number++;
            }
            // difference between break and yield break 
            yield return 10;
        }

        static void Main(string[] args)
        {
            foreach (var number in GetNumbers())
                Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
