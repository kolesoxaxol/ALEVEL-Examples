using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_lvl_Practise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number of elements: ");
            int n = ReadNumberFromConsole();

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("enter a[{0}]: ", i);
                array[i] = ReadNumberFromConsole();
            }

            Console.WriteLine();
            Console.WriteLine("=============");
            Console.WriteLine();

            Console.WriteLine("Your array: ");
            PrintArray(array);

            Console.WriteLine($"{Environment.NewLine}============={Environment.NewLine}");

            int min = int.MaxValue, max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("max: {0}", max);
            Console.WriteLine("min: {0}", min);

            Console.WriteLine($"{Environment.NewLine}============={Environment.NewLine}");

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
                PrintArray(array, min, max);
            }

            Console.WriteLine();
            Console.WriteLine("Sorted array: ");
            PrintArray(array);

            Console.ReadKey();
        }

        static int ReadNumberFromConsole()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect number, try again");
            }

            return number;
        }

        static void PrintArray(int[] array, int? min = null, int? max = null)
        {
            var n = array.Length - 1;
            for (int i = 0; i < n; i++)
            {
                PrintNumber(array[i], max, min);
                Console.Write(", ");
            }

            PrintNumber(array[n], max, min);
            Console.WriteLine();
        }

        static void PrintNumber(int number, int? max = null, int? min = null)
        {
            if (min.HasValue && number == min.Value)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(number);
                Console.ResetColor();
            }
            else if (max.HasValue && number == max.Value)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(number);
                Console.ResetColor();
            }
            else
            {
                Console.Write(number);
            }
        }
    }
}
