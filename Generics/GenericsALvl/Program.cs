using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsALvl
{
    public class Document
    {
        public object Id { get; set; }
        public object Content { get; set; }
    }

    public class DocumentGeneric<T, TDocument>
    {
        public T Id { get; set; }
        public TDocument Content { get; set; }
    }

    class Program
    {
        static Document PrintDocument(int id, string content)
        {
           var doc = new Document();
           doc.Content = content;
           doc.Id = id;

           // тут могда быть ваша реклама
           return doc;
        }

        static DocumentGeneric<T,TContent> PrintDocumentGeneric<T, TContent>(T id, TContent content)
        {
            var doc = new DocumentGeneric<T, TContent> {Content = content, Id = id};

            // тут могда быть ваша реклама
            return doc;
        }

        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
       

            for (int i = 0; i < 10000000; i++)
            {
              var result = PrintDocument(i, i.ToString());
              string content = result.Content.ToString();
              int id = (int) result.Id;
            }
            watch.Stop();
            Console.WriteLine(" Non generic print " + watch.Elapsed);

            watch.Restart();
            for (int i = 0; i < 10000000; i++)
            {
               var result = PrintDocumentGeneric<int, string>(i, i.ToString());
               string content = result.Content;
               int id = result.Id;

            }
            watch.Stop();
            Console.WriteLine("generic print " + watch.Elapsed);
            Console.ReadLine();

        }
    }
}
