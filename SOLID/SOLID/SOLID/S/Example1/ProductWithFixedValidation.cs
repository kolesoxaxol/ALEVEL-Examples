using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.S.Example1
{
    class ProductWithFixedValidation
    {
        public int Price { get; set; }

        public bool IsValid(bool isCustomerService)
        {
            if (isCustomerService == true)
                return Price > 100000;

            return Price > 0;
        }
    }
}
