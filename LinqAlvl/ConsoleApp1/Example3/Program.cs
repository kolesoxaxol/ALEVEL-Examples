using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        // Declare a delegate. 
        delegate void Printer(string s);

        class TestClass
        {
            static void Main()
            {
                // Instantiate the delegate type using an anonymous method. 
                Printer p = delegate (string j)
                {
                    Console.WriteLine(j);
                };

                // Results from the anonymous delegate call. 
                p("The delegate using the anonymous method is called.");

                // The delegate instantiation using a named method "DoWork". 
                p = new Printer(TestClass.DoWork);

                // Results from the old style delegate call. 
                p("The delegate using the named method is called.");
            }

            // The method associated with the named delegate. 
            static void DoWork(string k)
            {
                Console.WriteLine(k);
            }
        }
        /* Output: 
            The delegate using the anonymous method is called. 
            The delegate using the named method is called. 
        */
    }
}
