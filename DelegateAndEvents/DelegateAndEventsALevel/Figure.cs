using System;

namespace DelegateAndEventsALevel
{
    public static class Figure
    {
        // объявление статических методов в классе
        // длина окружности
        public static double GetLength(double r)
        {
            double length;
            length = 2 * Math.PI * r;
            return length;
        }

        // площадь круга
        public static double GetArea(double r)
        {
            double area;
            area = Math.PI * r * r;
            return area;
        }

        // объем шара
        public static double GetVolume(double r)
        {
            double volume;
            volume = Math.PI * r * r * r * 4.0 / 3.0;
            return volume;
        }
    }
}
