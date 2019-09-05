using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2.Engine
{
    class ShitEngine // двигатель летающий на искусстве российской эстрады
    {
        public int Weight { get; }

        public int Power { get; }

        public ShitEngine()
        {
            Weight = 2000;
            Power = 1000;
        }

        public void Start()
        {
            Console.WriteLine("Алла, спойте нам пожалуйста про розы!");
        }

        public void Stop()
        {
            Console.WriteLine("Лучше нагрузите Витю АК");
        }
    }
}
