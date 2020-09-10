using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Parts
{
    public class DieselEngine : Engine
    {
        public DieselEngine()
        {
            Console.WriteLine("Engine is Diesel");
        }
    }
}
