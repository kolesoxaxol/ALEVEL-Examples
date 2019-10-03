using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.AddFirst(new LinkedListNode<int>(i));
            }

            int index = 5;


                LinkedListNode<int> currentNode = numbers.First;

                for (int i = 0; i <= index && currentNode != null; i++)
                {
                    if (i != index)
                    {
                        currentNode = currentNode.Next;
                        continue;
                    }

                    numbers.Remove(currentNode);
                    
                }

                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();


                LinkedListNode<int> currentNode2 = numbers.First;
                int value = 4;
                index = 4;
                for (int i = 0; i <= index && currentNode != null; i++)
                {
                    currentNode2 = currentNode2.Next;
                    if (i == index)
                    {
                        numbers.AddBefore(currentNode2, value);
                        break;
                    }
                }

            foreach (var item in numbers)
            {
                    Console.WriteLine(item);
            }

                Console.ReadLine();
        }
    }
}
