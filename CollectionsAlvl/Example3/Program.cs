using System;
using System.Collections.Generic;

namespace Example3
{
    class Program
    {
        static IEnumerable<int> GenerateFibonacciNumbers(int n)
        {
            for (int i = 0, j = 0, k = 1; i < n; i++)
            {
                yield return j;
                int temp = j + k;
                j = k;
                k = temp;
            }
        }

        static void Main(string[] args)
        {
            foreach (int x in GenerateFibonacciNumbers(10))
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
