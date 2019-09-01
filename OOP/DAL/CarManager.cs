using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public partial class CarManager
    {
        /* fields,

         Variables,

         Methods,

         Properties,

         */

     
        partial void SomeTestMethod()
        {
            Console.WriteLine("This partial method implementation");
        }

        internal void GetName()
        {
            Console.WriteLine(Name);
        }
 

        private Car CreateCar(int discountSize = 10, string name = "Honda") // параметры метода по умолчанию
        {
            Car car = new Car();
            car.color = "red";
            car.name = name;
            car.price = 1000;
            car.Discount = discountSize;
            return car;
        }

        public void SellCar()
        {
            Car car = CreateCar();
            Console.WriteLine($"discount {car.Discount}");
            Console.WriteLine("I sell Car with Name: {0}, Price: {1}, Color: {2}", car.name, car.price - car.Discount, car.color);


            //  discount hack
            Car car2 = CreateCar(20, "VAZ");
            Console.WriteLine($"discount {car.Discount}");
            Console.WriteLine("I sell Car2 with Name: {0}, Price: {1}, Color: {2}", car2.name, car2.price - car2.Discount, car2.color);

            //  discount hack
            car.Discount = 100;
            Console.WriteLine($"discount {car.Discount}");
            Console.WriteLine("I sell Car with Name: {0}, Price: {1}, Color: {2}", car.name, car.price - car.Discount, car.color);

            //  discount hack
            car.discount = 1000;
            Console.WriteLine($"discount {car.Discount}");
            Console.WriteLine("I sell Car with Name: {0}, Price: {1}, Color: {2}", car.name, car.price - car.Discount, car.color);
        }

    }

 
}
