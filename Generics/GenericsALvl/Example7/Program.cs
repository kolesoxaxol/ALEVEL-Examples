using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        abstract class Animal
        {
        }

        class Cat : Animal
        {
        }

        static void Main(string[] args)
        {
            // Все обобщения инвариантны по умолчанию
            // Инвариантноть обязует вас использовать только тот тип который вы указали в обобщении
            // List<object> list = new List<string>();

          // ковариантность позволяет нам использовать более конкретные типы чем мы использовали ранее
          List<Cat> lisCat = new List<Cat>();
          IEnumerable<Cat> cats = lisCat;
          IEnumerable<Animal> animals = cats;
        }
    }
}
