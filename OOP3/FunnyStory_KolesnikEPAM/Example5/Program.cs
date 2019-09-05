using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Program
    {
        interface IPrinter
        {
            void Print();
            int Scan();
        }

        class Printer: IPrinter
        {
            public void Revert()
            {
                Console.WriteLine("I revertImage");
            }

            public void Print()
            {
                Console.WriteLine("I pint something");
            }

            public int Scan()
            {
                Console.WriteLine("I scan something");
                Revert();
                return 0;
            }
        }

        static void Main(string[] args)
        {
            IPrinter printer = new Printer();
            printer.Print();
            printer.Scan();
            // Revert will be incapsulated 
        }
    }
}
