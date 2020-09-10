using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Parts
{
    public class MediumWheels : Wheels
    {
        public MediumWheels()
        {
            Console.WriteLine("Wheels are 16\"");
        }
    }
}
