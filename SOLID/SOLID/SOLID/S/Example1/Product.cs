using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.S.Example1
{
    public class Product
    {
        public int Price { get; set; }

        public bool IsValid()
        {
            return Price > 0;
        }

    }

  
}
