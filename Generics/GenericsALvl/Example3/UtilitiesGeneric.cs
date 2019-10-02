using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class UtilitiesGeneric<T> where T : IComparable, new()
    {

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // this not works now need to derive IComparable
        //public T Max<T>(T a, T b)
        //{
        //    return a > b ? a : b;
        //} 



        // if u need to create instance new() contraint
        public void DoSomthing(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
