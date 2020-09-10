using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactorySample.Parts
{
    public class WhitePaint : Paint
    {
        public WhitePaint()
        {
            Console.WriteLine("Paint is White");
        }
    }
}
