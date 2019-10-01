using System;
using System.Collections;

namespace Example6
{
    class Program : Hashtable
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            Hashtable ht = new Hashtable();

            ht.Add("Koliesnik Yevhenii", "099428555579");
            ht.Add("Tatyana Pupkina", "0951843456");
            ht.Add("Boris Shevchuk", "0994295695");
         
            // Считаем коллекцию ключей
            ICollection keys = ht.Keys;

            foreach (string s in keys)
            {
                Console.WriteLine(s + ": " + ht[s]);
               
                Console.WriteLine(pr.GetHash(s));
            }

            Console.ReadLine();
        }
    }
}
