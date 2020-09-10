using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Parts
{
    public class BlackPaint : Paint
    {
        public BlackPaint()
        {
            Console.WriteLine("Paint is Black");
        }
    }
}
