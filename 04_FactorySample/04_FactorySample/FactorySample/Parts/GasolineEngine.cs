using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Parts
{
    public class GasolineEngine : Engine
    {
        public GasolineEngine()
        {
            Console.WriteLine("Engine is gasoline");
        }
    }
}
