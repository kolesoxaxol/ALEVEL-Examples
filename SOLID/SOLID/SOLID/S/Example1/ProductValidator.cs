using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.S.Example1
{
    public interface IProductValidator
    {
        bool IsValid(ProductWithValidator product);
    }

    public class ProductDefaultValidator : IProductValidator
    {
        public bool IsValid(ProductWithValidator product)
        {
            return product.Price > 0;
        }
    }

    public class CustomerServiceProductValidator : IProductValidator
    {
        public bool IsValid(ProductWithValidator product)
        {
            return product.Price > 100000;
        }
    }

    public class ProductWithValidator
    {
        private readonly IProductValidator validator;

        public ProductWithValidator() : this(new ProductDefaultValidator())
        {
        }

        public ProductWithValidator(IProductValidator validator)
        {
            this.validator = validator;
        }

        public int Price { get; set; }

        public bool IsValid()
        {
            return validator.IsValid(this);
        }
    }
}
