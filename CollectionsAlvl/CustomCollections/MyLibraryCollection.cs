using System;
using System.Collections;

namespace CustomCollections
{
    public class MyLibraryCollection: IEnumerable, IEnumerator
    {
        private string[] books = {"Book 1", "Book 2", "Book 3", };
        int index = -1;

        //Прежде чем получить доступ к коллекции с помощью перечислителя, необходимо получить его
        //В каждом классе коллекции для этой цели предоставляется метод GetEnumerator()
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index == books.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return books[index];
            }
        }
    }
}
