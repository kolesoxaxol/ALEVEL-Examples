using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.Engine;

namespace Example2.Rockets
{
    class CryRocket // ракета для движка на слезах фанатов
    {
        public RocketHeader Header { get; set; }  // головная часть
        public CryEngine Engine { get; set; }  // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }
    }
}
