using System;

namespace Example3.Engine
{
    class PoliticsTalksEngine : IEngine  // Двигатель летающий на пиз*еже политиков
    {
        public int Weight { get; }

        public int Power { get; }

        public PoliticsTalksEngine()
        {
            Weight = 100; // так мало весит, потому что пи*деть - не мешик ворочать
            Power = 5000;
        }

        public void Start()
        {
            Console.WriteLine("Чё там с дорогами?");
        }

        public void Stop()
        {
            Console.WriteLine("Приглашены СБушники из антикоррупционного отдела");
        }
    }
}
