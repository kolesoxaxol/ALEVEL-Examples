using System;
using DAL;

namespace OOP
{   
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManger = new CarManager();
           // carManger.GetName();
            carManger.SellCar();

            Console.ReadKey();
        }
    }
}
