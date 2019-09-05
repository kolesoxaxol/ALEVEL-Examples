using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2.Engine
{
    class CryEngine // Двигатель летающий на слезах фанатов сборной Украины  по футболу
    {
        public int Weight { get; }
        public int Power { get; }

        public CryEngine()
        {
            Weight = 800;
            Power = 2000;
        }

        public void Start()
        {
            Console.WriteLine("То что этот двигатель не оправдывает ваши ожидания - ваши проблемы");
        }

        public void Stop()
        {
            Console.WriteLine("Прохождение в плей-оф");
        }

        public void BeginAdvertising()
        {
            Console.WriteLine("Мдаааа.....");
        }
    }
}
