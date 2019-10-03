using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    class Program
    {
        abstract class Animal
        {
        }
        class Cat : Animal
        {
        }

        interface IPushable<in T> where T : Animal
        {
            void Push(T obj);

        }

         class Stack<T> : IPushable<T> where T : Animal
        {
            public void Push(T obj)
            {

            }
        }

        static void Main(string[] args)
        {
            // Контравариантноть позволяет наоборот использовать общие типы взамен конкретных
            // Найти задачу для этой фигни та еще проблема
            IPushable<Cat> cats = new Stack<Animal>();
            
        }
    }
}
