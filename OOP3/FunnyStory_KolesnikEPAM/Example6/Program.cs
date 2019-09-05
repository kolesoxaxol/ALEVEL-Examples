using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {

        public class SomeRefType : ISomeInterface, IAnotherInterface
        {
            string ISomeInterface.SomeMethod(string param)
            {
                // реализация метода интерфейса ISomeInterface
                return "B";
            }

            string IAnotherInterface.SomeMethod(string param)
            {
                // реализация метода интерфейса IAnotherInterface
                return "A";
            }

            public string SomeMethod(string param)
            {
                // реализация метода который не имеет отношения к интерфейсам
                return "C";
            }
        }

        private interface ISomeInterface
        {
            string SomeMethod(string param);


        }

        private interface IAnotherInterface
        {
            string SomeMethod(string param);
        }


        static void Main(string[] args)
        {

            SomeRefType st = new SomeRefType();
            string p = "A";
            string rt;
            // вызывается метод не имеющий отношения к интерфейсам
            rt = st.SomeMethod(p);

            Console.WriteLine(rt);

            // вызывается реализация метода интерфейса ISomeInterface
            rt = ((ISomeInterface)st).SomeMethod(p);
            Console.WriteLine(rt);

            // вызывается реализация метода интерфейса IAnotherInterface
            rt = ((IAnotherInterface)st).SomeMethod(p);
            Console.WriteLine(rt);


            Console.ReadLine();
        }
    }
}
