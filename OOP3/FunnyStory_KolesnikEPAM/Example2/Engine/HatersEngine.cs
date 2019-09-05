using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2.Engine
{
    class HatersEngine // двигатель летающий на тяге пердаков
    {
        public int Weight { get; }     // масса двигателя
        public int Power { get; }      // мощность двигателя
        public string GetCop { get; }  // получаем копирайты

        public HatersEngine()
        {
            Weight = 322;
            Power = 228;
            GetCop = "ExtremeCodeTV EngineCreator";
        }

        public void Start()
        {
            Console.WriteLine("Пуканы раскаляются, тяга на максимум");
        }

        public void Stop()
        {
            Console.WriteLine("Вброс годного контента. Пуканы остывают");
        }
    }
}
