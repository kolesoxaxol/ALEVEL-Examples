using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    interface IEngine
    {
        void Start();       // метод для запуска
        void Stop();        // метод для остановки
        int Weight { get; } // масса двигателя 
        int Power { get; }  // мощность двигателя


    }
}

