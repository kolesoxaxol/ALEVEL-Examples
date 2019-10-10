using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void StartThread()
        {
            System.Threading.Thread t1 = new System.Threading.Thread
            (delegate ()
            {
                System.Console.Write("Hello, ");
                System.Console.WriteLine("World!");
            });
            t1.Start();
        }

        static void Main(string[] args)
        {
            StartThread();
            Console.ReadLine();

        }
    }
}
