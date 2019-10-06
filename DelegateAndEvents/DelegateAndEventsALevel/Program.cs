using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventsALevel
{
    // объявление типа делегата CalcFigure
    delegate double CalcFigure(double r);

    class Program
    {
        static void Main(string[] args)
        {
            double radius, length, area, volume;


            radius = 3.0;

            // вызов делегата
            // сконструировать делегат
            CalcFigure CF = new CalcFigure(Figure.GetArea);
            area = CF(radius);

            CF = new CalcFigure(Figure.GetVolume);
            volume = CF(radius);

            CF = new CalcFigure(Figure.GetLength);
            length = CF(radius); 

            Console.WriteLine($"Площадь круга : {area}");
            Console.WriteLine($"Объем шара : {volume}");
            Console.WriteLine($"Длина окружности : {length}");

            Console.ReadLine();
        }
    }
}
