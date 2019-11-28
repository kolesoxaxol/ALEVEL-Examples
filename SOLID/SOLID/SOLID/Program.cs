using SOLID.L;
using SOLID.S.Example1;
using System;


namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {

            // проверка на валидность
            var product = new Product { Price = 100 };
            var isValid = product.IsValid();

            // Теперь наш объект Product начал использовать в некоем CustomerService, который считает валидным продукт с ценой больше 100 тыс. рублей. Что делать?​
            var product2 = new ProductWithFixedValidation { Price = 100 };
            var isValid2 = product2.IsValid(true);

            // Решение с валидатором
         

            // используем объект продукта в новом сервисе
            var product3 = new ProductWithValidator(new CustomerServiceProductValidator()) { Price = 100 };



            Rectangle rect = new Square();
            rect.Width = 3;
            rect.Height = 10;

            Console.WriteLine(rect.GetRectangleArea());
            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }
}
