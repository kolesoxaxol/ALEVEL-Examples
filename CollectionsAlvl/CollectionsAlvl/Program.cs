using System;
using System.Collections;
using System.Collections.Generic;
using CustomCollections;

namespace CollectionsAlvl
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibraryCollection library = new MyLibraryCollection();


            Console.WriteLine("Первый вызов перечислителя:");
            // Используем перечислитель
            IEnumerator etr = library.GetEnumerator();
            while (etr.MoveNext())
                Console.Write(etr.Current + "\t");

            Console.WriteLine("\nПовторный вызов перечислителя:");
            // Сбросим значение и вновь используем перечислитель
            // для доступа к коллекции
            etr.Reset();
            while (etr.MoveNext())
                Console.Write(etr.Current + "\t");

        
            Console.WriteLine("\nВызов через foreach:");
            // перечисление с foreach
            foreach (var book in library)
            {
                Console.Write(book + "\t");
            }

           
            Console.WriteLine("\nВызов через развернутый foreach - (не используем синтаксический сахар):");
            // как развернтся foreach 
            IEnumerator enumerator = library.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    var item = enumerator.Current;
                    Console.Write(item + "\t");
                }
            }
            finally
            {
                if (enumerator is IDisposable disposable)
                    disposable.Dispose();
            }

            Console.ReadLine();
        }
    }
}
