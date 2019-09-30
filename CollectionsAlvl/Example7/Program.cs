using System.Collections.Generic;

namespace Example7
{
    class Program
    {
        class SimpleCollection<T> : ICollection<T>
        {

            ICollection<T> _items;


            public SimpleCollection()
            {
                // Default to using a List<T>.
                _items = new List<T>();
            }

            protected SimpleCollection(ICollection<T> collection)
            {
                // Let derived classes specify the exact type of ICollection<T> to wrap.
                _items = collection;
            }

            public void Add(T item)
            {
                _items.Add(item);
            }

            public void Clear()
            {
                _items.Clear();
            }

            public bool Contains(T item)
            {
                return _items.Contains(item);
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                _items.CopyTo(array, arrayIndex);
            }

            public int Count
            {
                get { return _items.Count; }
            }

            public bool IsReadOnly
            {
                get { return false; }
            }

            public bool Remove(T item)
            {
                return _items.Remove(item);
            }

            // The generic enumerator obtained from IEnumerator<T>
            // by GetEnumerator can also be used with the non-generic IEnumerator.
            // To avoid a naming conflict, the non-generic IEnumerable method
            // is explicitly implemented.


            public IEnumerator<T> GetEnumerator()
            {
                return _items.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _items.GetEnumerator();
            }
        }

        static void Main(string[] args)
        {
            SimpleCollection<string> simpleCollection = new SimpleCollection<string>();
            
        }
    }
}
