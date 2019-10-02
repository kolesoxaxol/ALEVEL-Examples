using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Product
    {
    }

    public class Order
    {
    }

    public class Customer
    {
    }

    public class ProductService
    {
        public void Add(Product product)
        {
        }

        public void Remove(Product product)
        {
        }

        public void Delete(Product product)
        {
        }
    }

    public class OrderService
    {
        public void Add(Order product)
        {
        }

        public void Remove(Order product)
        {
        }

        public void Delete(Order product)
        {
        }
    }

    public class CustomerService
    {
        public void Add(Customer product)
        {
        }

        public void Remove(Customer product)
        {
        }

        public void Delete(Customer product)
        {
        }
    }

    public class GenericService<T> where T: new()
    {
        public void Add(T product)
        {
        }

        public void Remove(T product)
        {
        }

        public void Delete(T product)
        {
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();
            OrderService  orderService = new OrderService();
            ProductService сustomerService = new ProductService();

            GenericService<Product> genericProductService = new GenericService<Product>();
            GenericService<Order> genericOrderService = new GenericService<Order>();
            GenericService<Customer> genericCustomerService = new GenericService<Customer>();
        }
    }
}
