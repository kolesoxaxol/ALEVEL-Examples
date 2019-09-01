using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Car
    {
        //public string Color { get; set; }
        //public string Name { get; set; }
        //public decimal Price { get; set; }

        public string color;
        public string name;
        public decimal price;

        public int discount = 10;


        public int Discount
        {
            // Return the value stored in a field.
            get
            {
                if (DateTime.Today.DayOfWeek == DayOfWeek.Monday) { 
                return discount + 25;

                }
                if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
                {
                    return discount + 30;

                }

                if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
                {
                    return discount + 40;

                }

                if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
                {
                    return discount + 50;

                }
                if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
                {
                    return discount + 60;

                }

                return discount;
            }
            // Store the value in the field.
            set {
                if (value <= 60)
                {
                    discount = value;
                }
                else
                {
                    Console.WriteLine("wrong discount size you are fraud");
                    discount = 0;
                }
            }
        }
    }

}
