using System;

namespace Example2.Engine
{
    class PoliticsTalksEngine  // Двигатель летающий на пиз..же политиков
    {
        public int Weight { get; }

        public int Power { get; }

        public PoliticsTalksEngine()
        {
            Weight = 100; // так мало весит, потому что пи*деть - не мешок ворочать
            Power = 5000;
        }

        public void Start()
        {
            Console.WriteLine("Чё там с дорогами?");
        }

        public void Stop()
        {
            Console.WriteLine("Приглашены СБУшники из антикоррупционного отдела");
        }
    }
}
