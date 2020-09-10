using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Parts
{
    public class BigWheels : Wheels
    {
        public BigWheels()
        {
            Console.WriteLine("Wheels are 17\"");
        }
    }
}
