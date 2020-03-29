using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv2_Practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
                // result = result * i;
            }

            Console.WriteLine("{0}! = {1}", n, result);
            //Console.Write("GIVE ME A NAME: ");

            //string name = Console.ReadLine();

            //Console.Write("GIVE ME AN AGE: ");

            ////int age = int.Parse(Console.ReadLine());
            //int age = Convert.ToInt32(Console.ReadLine());
            //int rost = (int)Console.ReadLine();

            //// trying to ask ROST from user
            //Console.WriteLine("GIVE ME A ROST: ");
            //// TODO: add input validation
            //rost = int.Parse(Console.ReadLine());

            ////string formatedString = string.Format("Hello {0}, your age is {1}!", name, age);
            ////Console.WriteLine(formatedString);

            ////Console.WriteLine("Hello " + name + ", your age is" + age + "!");

            //Console.WriteLine($"Hello {name}, your age is {age}");

            //if (age >= 18)
            //{
            //    Console.WriteLine("TOO OLD");
            //}
            //else
            //{
            //    Console.WriteLine("NOT OLD ENOUGH");
            //}

            Console.ReadKey();
        }
    }
}
