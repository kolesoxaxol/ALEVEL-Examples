using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LVL_Practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int arbuzi = 10;
            //int barani = 15;
            //int crokodili = default;

            //Console.WriteLine($"a: {arbuzi}, b: {barani}, c: {crokodili}");

            //Console.WriteLine(RefOutExample(barani, ref arbuzi, out crokodili) && crokodili > 100 ? "Succeed" : "Not Succeed");

            //Console.WriteLine($"a: {arbuzi}, b: {barani}, c: {crokodili}");

            //Console.ReadKey();

            var pointA = new Point(1.0m, 1.0m);
            var pointB = new Point(0m, 0m);

            Console.WriteLine("Initial points: ");
            Console.WriteLine($"A: {pointA}");
            Console.WriteLine($"B: {pointB}");

            MovePoint( pointA, 2, 1);
            MovePoint(pointB, 1, 2);

            Console.WriteLine("\nMoved points: ");
            Console.WriteLine($"A: {pointA}");
            Console.WriteLine($"B: {pointB}");

            Console.ReadKey();
        }

        private static void MovePoint( Point p, decimal distanceX = 0, decimal distanceY = 0)
        {
            p.X += distanceX;
            p.Y += distanceY;
        }

        public struct Point
        {
            public decimal X { get; set; }
            public decimal Y { get; set; }

            public Point(decimal x, decimal y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return $"{X};{Y}";
            }
        }

        //static bool RefOutExample(int a, ref int b, out int c)
        //{
        //    c = a * b;
        //    a = a * 10;
        //    b = c - a;

        //    return (a > c);
        //}
    }
}
