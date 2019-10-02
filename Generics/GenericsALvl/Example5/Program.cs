using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            //var number = new Nullable<int>();
            Console.WriteLine("Has Value " + number.HasValue);

            Console.WriteLine("Value " + number.GetValueOrDEfault());

        }
    }
}
