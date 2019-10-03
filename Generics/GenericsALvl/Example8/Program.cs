using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    class Program
    {
        public abstract class Engine
        {
        }

        public class EngineV8 : Engine
        {

        }

        interface ICar<out T> where T : Engine
        {
            T GetEngine();
        }

        public class Lada : ICar<EngineV8>
        {
            public EngineV8 GetEngine()
            {
                return new EngineV8();
            }
        }

        static void Main(string[] args)
        {
            Lada lada = new Lada();
            ICar<EngineV8> vEightCar = lada;

            // инвариантность мы пытаемся привести к более общему
            // как сделать ковариантным ? 
            ICar<Engine> somecar = lada;
        }
    }
}
