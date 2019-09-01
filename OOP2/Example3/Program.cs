
// C# program to illustrate the 
// concept of 'as' operator 
using System;

// Classes 
class Y { }
class Z { }

class GFG
{

    // Main method 
    static void Main()
    {

        Class1 tt = new global::Class1();
        // creating and initializing object array 
        object[] o = new object[5];
        o[0] = new Y();
        o[1] = new Z();
        o[2] = "Hello";
        o[3] = 4759.0;
        o[4] = null;

        for (int q = 0; q < o.Length; ++q)
        {

            // using as operator 
            string str1 = o[q] as string;

            Console.Write("{0}:", q);

            // checking for the result 
            if (str1 != null)
            {
                Console.WriteLine("'" + str1 + "'");
            }
            else
            {
                Console.WriteLine("Is is not a string");
            }
        }

        Console.ReadLine();
    }
}