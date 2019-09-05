using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example2.Engine;

namespace Example2.Rockets
{
    class PoliticRocket // Ракета на пи*деже политиков
    {
        public RocketHeader Header { get; set; }  // головная часть
        public PoliticsTalksEngine Engine { get; set; }  // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }
    }
}
